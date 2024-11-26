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
    public partial class frmMaintenanceDetails : Form
    {
        public frmMaintenanceDetails()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdMaintenanceDetails.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            using (DataContext dc = new DataContext())
            {
                MaintenanceDetails maintenanceDetails = maintenanceDetailsBindingSource.Current as MaintenanceDetails;
                if (maintenanceDetails != null)
                {
                    if (dc.Entry<MaintenanceDetails>(maintenanceDetails).State == EntityState.Detached)
                    {
                        dc.Set<MaintenanceDetails>().Attach(maintenanceDetails);
                    }
                    if (maintenanceDetails.Id == 0)
                    {
                        dc.Entry<MaintenanceDetails>(maintenanceDetails).State = EntityState.Added;
                    }
                    else
                    {
                        dc.Entry<MaintenanceDetails>(maintenanceDetails).State = EntityState.Modified;
                    }
                    dc.SaveChanges();
                    MessageBox.Show(this, "registro guardado :)");
                    grdMaintenanceDetails.Refresh();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            grdMaintenanceDetails.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtMachine.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Quieres eliminar el registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (DataContext dc = new DataContext())
                {
                    MaintenanceDetails maintenanceDetails = maintenanceDetailsBindingSource.Current as MaintenanceDetails;
                    if (maintenanceDetails != null)
                    {
                        if (dc.Entry<MaintenanceDetails>(maintenanceDetails).State == EntityState.Detached)
                        {
                            dc.Set<MaintenanceDetails>().Attach(maintenanceDetails);
                        }
                        dc.Entry<MaintenanceDetails>(maintenanceDetails).State = EntityState.Deleted;
                        dc.SaveChanges();
                        MessageBox.Show(this, "Registro eliminado");
                        pctMaintenance.Image = null;
                    }
                }
            }
            grdMaintenanceDetails.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pctMaintenance.Image = null;
            grdMaintenanceDetails.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            maintenanceDetailsBindingSource.Add(new Tool());
            maintenanceDetailsBindingSource.MoveLast();
            txtMachine.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grdMaintenanceDetails.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            maintenanceDetailsBindingSource.ResetBindings(false);
            frmMaintenanceDetails_Load(sender, e);
        }

        private void frmMaintenanceDetails_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            using (DataContext dataContext = new DataContext())
            {
                maintenanceDetailsBindingSource.DataSource = dataContext.MaintenanceDetails.ToList();
            }
            MaintenanceDetails maintenanceDetails = maintenanceDetailsBindingSource.Current as MaintenanceDetails;
            if (maintenanceDetails != null && maintenanceDetails.Photo != null)
            {
                pctMaintenance.Image = Image.FromFile(maintenanceDetails.Photo);
            }
            else
            {
                pctMaintenance.Image = null;
            }
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
                    MaintenanceDetails maintenanceDetails = maintenanceDetailsBindingSource.Current as MaintenanceDetails;
                    if (maintenanceDetails != null)
                    {
                        maintenanceDetails.Photo = ofd.FileName;
                    }
                }
            }
        }
    }
}
