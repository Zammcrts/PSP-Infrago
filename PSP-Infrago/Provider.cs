using PSP_Infrago.Data;
using PSP_Infrago.Entities;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace PSP_Infrago
{
    public partial class frmProvider : Form
    {
        public frmProvider()
        {
            InitializeComponent();
        }

        private void frmProvider_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmProvider_Load(object sender, EventArgs e)
        {
            bttCancel.Enabled = false;
            bttSave.Enabled = false;
            grpData.Enabled = false;
            using (DataContext dc = new DataContext())
            {
                providerBindingSource.DataSource = dc.Providers.ToList();
            }
        }

        private void dgrProvider_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Provider provider = providerBindingSource.Current as Provider;
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            grpData.Enabled = true;
            dgrProvider.Enabled = false;
            bttSave.Enabled = true;
            bttCancel.Enabled = true;
            bttNew.Enabled = false;
            bttUpdate.Enabled = false;
            bttDelete.Enabled = false;
            providerBindingSource.Add(new Provider());
            providerBindingSource.MoveLast();
            txtProviderName.Focus();
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrProvider.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            using (DataContext dc = new DataContext())
            {
                Provider provider = providerBindingSource.Current as Provider;
                if (provider != null)
                {
                    if (dc.Entry<Provider>(provider).State == EntityState.Detached)
                    {
                        dc.Set<Provider>().Attach(provider);
                    }
                    if (provider.Id == 0)
                    {
                        dc.Entry<Provider>(provider).State = EntityState.Added;
                    }
                    else
                    {
                        dc.Entry<Provider>(provider).State = EntityState.Modified;
                    }
                    dc.SaveChanges();
                    MessageBox.Show(this, "Registro guardado exitosamente");
                    dgrProvider.Refresh();
                }
            }
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            grpData.Enabled = true;
            dgrProvider.Enabled = false;
            bttSave.Enabled = true;
            bttCancel.Enabled = true;
            bttNew.Enabled = false;
            bttUpdate.Enabled = false;
            bttDelete.Enabled = false;
            txtProviderName.Focus();
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrProvider.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            providerBindingSource.ResetBindings(false);
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrProvider.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            if (MessageBox.Show(this, "Quieres eliminar el registro?", "CONFIRMACION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (DataContext dc = new DataContext())
                {
                    Provider provider = providerBindingSource.Current as Provider;
                    if (provider != null)
                    {
                        if (dc.Entry<Provider>(provider).State == EntityState.Detached)
                        {
                            dc.Set<Provider>().Attach(provider);
                        }
                        dc.Entry<Provider>(provider).State = EntityState.Deleted;
                        dc.SaveChanges();
                        providerBindingSource.RemoveCurrent();
                        MessageBox.Show(this, "Registro elimianado exitosamente");
                    }
                }
            }
        }
    }
}
