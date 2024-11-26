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

namespace PSP_Infrago
{
    public partial class frmMachinery : Form
    {
        public frmMachinery()
        {
            InitializeComponent();
        }

        private void frmMachinery_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            using (DataContext dataContext = new DataContext())
            {
                machineryBindingSource.DataSource = dataContext.Machineries.ToList();
            }
            Machinery machinery = machineryBindingSource.Current as Machinery;
            if (machinery != null && machinery.Photo != null)
            {
                pctMachine.Image = Image.FromFile(machinery.Photo);
            }
            else
            {
                pctMachine.Image = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdMachinery.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            using (DataContext dc = new DataContext())
            {
                Machinery machinery = machineryBindingSource.Current as Machinery;
                if (machinery != null)
                {
                    if (dc.Entry<Machinery>(machinery).State == EntityState.Detached)
                    {
                        dc.Set<Machinery>().Attach(machinery);
                    }
                    if (machinery.Id == 0)
                    {
                        dc.Entry<Machinery>(machinery).State = EntityState.Added;
                    }
                    else
                    {
                        dc.Entry<Machinery>(machinery).State = EntityState.Modified;
                    }
                    dc.SaveChanges();
                    MessageBox.Show(this, "registro guardado :)");
                    grdMachinery.Refresh();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            grdMachinery.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Quieres eliminar el registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (DataContext dc = new DataContext())
                {
                    Machinery machinery = machineryBindingSource.Current as Machinery;
                    if (machinery != null)
                    {
                        if (dc.Entry<Machinery>(machinery).State == EntityState.Detached)
                        {
                            dc.Set<Machinery>().Attach(machinery);
                        }
                        dc.Entry<Machinery>(machinery).State = EntityState.Deleted;
                        dc.SaveChanges();
                        MessageBox.Show(this, "Registro eliminado");
                        pctMachine.Image = null;
                    }
                }
            }
            grdMachinery.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pctMachine.Image = null;
            grdMachinery.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            machineryBindingSource.Add(new Tool());
            machineryBindingSource.MoveLast();
            txtName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grdMachinery.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            machineryBindingSource.ResetBindings(false);
            frmMachinery_Load(sender, e);
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
                    pctMachine.Image = Image.FromFile(ofd.FileName);
                    Tool tool = machineryBindingSource.Current as Tool;
                    if (tool != null)
                    {
                        tool.Photo = ofd.FileName;
                    }
                }
            }
        }
    }
}
