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
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private void frmClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void dgrClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Client client = clientBindingSource.Current as Client;
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            bttCancel.Enabled = false;
            bttSave.Enabled = false;
            grpData.Enabled = false;
            using (DataContext dc = new DataContext())
            {
                clientBindingSource.DataSource = dc.Clients.ToList();
            }
        }

        private void bttNew_Click_1(object sender, EventArgs e)
        {
            grpData.Enabled = true;
            dgrClient.Enabled = false;
            bttSave.Enabled = true;
            bttCancel.Enabled = true;
            bttNew.Enabled = false;
            bttUpdate.Enabled = false;
            bttDelete.Enabled = false;
            clientBindingSource.Add(new Client());
            clientBindingSource.MoveLast();
            txtClientName.Focus();
        }

        private void bttSave_Click_1(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrClient.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            using (DataContext dc = new DataContext())
            {
                Client client = clientBindingSource.Current as Client;
                if (client != null)
                {
                    if (dc.Entry<Client>(client).State == EntityState.Detached)
                    {
                        dc.Set<Client>().Attach(client);
                    }
                    if (client.Id == 0)
                    {
                        dc.Entry<Client>(client).State = EntityState.Added;
                    }
                    else
                    {
                        dc.Entry<Client>(client).State = EntityState.Modified;
                    }
                    dc.SaveChanges();
                    MessageBox.Show(this, "Registro guardado exitosamente");
                    dgrClient.Refresh();
                }
            }
        }

        private void bttUpdate_Click_1(object sender, EventArgs e)
        {
            grpData.Enabled = true;
            dgrClient.Enabled = false;
            bttSave.Enabled = true;
            bttCancel.Enabled = true;
            bttNew.Enabled = false;
            bttUpdate.Enabled = false;
            bttDelete.Enabled = false;
            txtClientName.Focus();
        }

        private void bttCancel_Click_1(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrClient.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            clientBindingSource.ResetBindings(false);
        }

        private void bttDelete_Click_1(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrClient.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            if (MessageBox.Show(this, "Quieres eliminar el registro?", "CONFIRMACION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (DataContext dc = new DataContext())
                {
                    Client client = clientBindingSource.Current as Client;
                    if (client != null)
                    {
                        if (dc.Entry<Client>(client).State == EntityState.Detached)
                        {
                            dc.Set<Client>().Attach(client);
                        }
                        dc.Entry<Client>(client).State = EntityState.Deleted;
                        dc.SaveChanges();
                        clientBindingSource.RemoveCurrent();
                        MessageBox.Show(this, "Registro elimianado exitosamente");
                    }
                }
            }
        }
    }
}
