using PSP_Infrago.Data;
using PSP_Infrago.Entities;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace PSP_Infrago
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            bttCancel.Enabled = false;
            bttSave.Enabled = false;
            grpData.Enabled = false;
            using (DataContext dc = new DataContext())
            {
                orderBindingSource.DataSource = dc.Orders.ToList();
            }
            cmbDepartment.Items.Add("Departamento de Finazas");

            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dgrOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Order order = orderBindingSource.Current as Order;
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            grpData.Enabled = true;
            dgrOrder.Enabled = false;
            bttSave.Enabled = true;
            bttCancel.Enabled = true;
            bttNew.Enabled = false;
            bttUpdate.Enabled = false;
            bttDelete.Enabled = false;
            orderBindingSource.Add(new Order());
            orderBindingSource.MoveLast();
            txtDetails.Focus();
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrOrder.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            using (DataContext dc = new DataContext())
            {
                Order order = orderBindingSource.Current as Order;
                if (order != null)
                {
                    if (dc.Entry<Order>(order).State == EntityState.Detached)
                    {
                        dc.Set<Order>().Attach(order);
                    }
                    if (order.Id == 0)
                    {
                        dc.Entry<Order>(order).State = EntityState.Added;
                    }
                    else
                    {
                        dc.Entry<Order>(order).State = EntityState.Modified;
                    }
                    dc.SaveChanges();
                    MessageBox.Show(this, "Registro guardado exitosamente");
                    dgrOrder.Refresh();
                }
            }
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            grpData.Enabled = true;
            dgrOrder.Enabled = false;
            bttSave.Enabled = true;
            bttCancel.Enabled = true;
            bttNew.Enabled = false;
            bttUpdate.Enabled = false;
            bttDelete.Enabled = false;
            txtDetails.Focus();
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrOrder.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            orderBindingSource.ResetBindings(false);
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrOrder.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            if (MessageBox.Show(this, "Quieres eliminar el registro?", "CONFIRMACION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (DataContext dc = new DataContext())
                {
                    Order order = orderBindingSource.Current as Order;
                    if (order != null)
                    {
                        if (dc.Entry<Order>(order).State == EntityState.Detached)
                        {
                            dc.Set<Order>().Attach(order);
                        }
                        dc.Entry<Order>(order).State = EntityState.Deleted;
                        dc.SaveChanges();
                        orderBindingSource.RemoveCurrent();
                        MessageBox.Show(this, "Registro elimianado exitosamente");
                    }
                }
            }
        }
    }
}
