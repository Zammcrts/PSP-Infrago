using PSP_Infrago.Data;
using PSP_Infrago.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PSP_Infrago
{
    public partial class frmMaintenance : Form
    {
        public frmMaintenance()
        {
            InitializeComponent();
        }

        private void frmMaintenance_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            using (DataContext dataContext = new DataContext())
            {
                maintenanceBindingSource.DataSource = dataContext.Maintenances.ToList();
            }
            Maintenance maintenance = maintenanceBindingSource.Current as Maintenance;
            if (maintenance != null && maintenance.Photo != null)
            {
                pctMaintenance.Image = Image.FromFile(maintenance.Photo);
            }
            else
            {
                pctMaintenance.Image = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdMaintenance.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            using (DataContext dc = new DataContext())
            {
                Maintenance maintenance = maintenanceBindingSource.Current as Maintenance;
                if (maintenance != null)
                {
                    if (dc.Entry<Maintenance>(maintenance).State == EntityState.Detached)
                    {
                        dc.Set<Maintenance>().Attach(maintenance);
                    }
                    if (maintenance.Id == 0)
                    {
                        dc.Entry<Maintenance>(maintenance).State = EntityState.Added;
                    }
                    else
                    {
                        dc.Entry<Maintenance>(maintenance).State = EntityState.Modified;
                    }
                    dc.SaveChanges();
                    MessageBox.Show(this, "registro guardado :)");
                    grdMaintenance.Refresh();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            grdMaintenance.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtMaintenanceType.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Quieres eliminar el registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (DataContext dc = new DataContext())
                {
                    Maintenance maintenance = maintenanceBindingSource.Current as Maintenance;
                    if (maintenance != null)
                    {
                        if (dc.Entry<Maintenance>(maintenance).State == EntityState.Detached)
                        {
                            dc.Set<Maintenance>().Attach(maintenance);
                        }
                        dc.Entry<Maintenance>(maintenance).State = EntityState.Deleted;
                        dc.SaveChanges();
                        MessageBox.Show(this, "Registro eliminado");
                        pctMaintenance.Image = null;
                    }
                }
            }
            grdMaintenance.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pctMaintenance.Image = null;
            grdMaintenance.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            maintenanceBindingSource.Add(new Maintenance());
            maintenanceBindingSource.MoveLast();
            txtMaintenanceType.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grdMaintenance.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            maintenanceBindingSource.ResetBindings(false);
            frmMaintenance_Load(sender, e);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "JPEG|*.jpg"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pctMaintenance.Image = Image.FromFile(ofd.FileName);
                    Maintenance maintenance = maintenanceBindingSource.Current as Maintenance;
                    if (maintenance != null)
                    {
                        maintenance.Photo = ofd.FileName;
                    }
                }
            }
        }
    }
}
