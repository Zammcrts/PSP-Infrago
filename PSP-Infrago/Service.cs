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
    public partial class frmService : Form
    {
        public frmService()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmService_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            using (DataContext dataContext = new DataContext())
            {
                serviceBindingSource.DataSource = dataContext.Services.ToList();
            }
            Service service = serviceBindingSource.Current as Service;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdService.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            using (DataContext dc = new DataContext())
            {
                Service service = serviceBindingSource.Current as Service;
                if (service != null)
                {
                    if (dc.Entry<Service>(service).State == EntityState.Detached)
                    {
                        dc.Set<Service>().Attach(service);
                    }
                    if (service.Id == 0)
                    {
                        dc.Entry<Service>(service).State = EntityState.Added;
                    }
                    else
                    {
                        dc.Entry<Service>(service).State = EntityState.Modified;
                    }
                    dc.SaveChanges();
                    MessageBox.Show(this, "registro guardado :)");
                    grdService.Refresh();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            grdService.Enabled = false;
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
                    Service service = serviceBindingSource.Current as Service;
                    if (service != null)
                    {
                        if (dc.Entry<Service>(service).State == EntityState.Detached)
                        {
                            dc.Set<Service>().Attach(service);
                        }
                        dc.Entry<Service>(service).State = EntityState.Deleted;
                        dc.SaveChanges();
                        MessageBox.Show(this, "Registro eliminado");
                    }
                }
            }
            grdService.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            grdService.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            serviceBindingSource.Add(new Tool());
            serviceBindingSource.MoveLast();
            txtName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grdService.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            serviceBindingSource.ResetBindings(false);
            frmService_Load(sender, e);
        }
    }
}
