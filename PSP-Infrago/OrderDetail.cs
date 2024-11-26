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
    public partial class frmOrderDetail : Form
    {
        public frmOrderDetail()
        {
            InitializeComponent();
        }

        private void frmOrderDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            bttCancel.Enabled = false;
            bttSave.Enabled = false;
            grpData.Enabled = false;
            using (DataContext dc = new DataContext())
            {
                orderDetailBindingSource.DataSource = dc.OrderDetails.ToList();
            }
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            grpData.Enabled = true;
            dgrOrderDetails.Enabled = false;
            bttSave.Enabled = true;
            bttCancel.Enabled = true;
            bttNew.Enabled = false;
            bttUpdate.Enabled = false;
            bttDelete.Enabled = false;
            orderDetailBindingSource.Add(new OrderDetail());
            orderDetailBindingSource.MoveLast();
            txtOrder.Focus();
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrOrderDetails.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            using (DataContext dc = new DataContext())
            {
                OrderDetail orderDetail = orderDetailBindingSource.Current as OrderDetail;
                if (orderDetail != null)
                {
                    if (dc.Entry<OrderDetail>(orderDetail).State == EntityState.Detached)
                    {
                        dc.Set<OrderDetail>().Attach(orderDetail);
                    }
                    if (orderDetail.Id == 0)
                    {
                        dc.Entry<OrderDetail>(orderDetail).State = EntityState.Added;
                    }
                    else
                    {
                        dc.Entry<OrderDetail>(orderDetail).State = EntityState.Modified;
                    }
                    dc.SaveChanges();
                    MessageBox.Show(this, "Registro guardado exitosamente");
                    dgrOrderDetails.Refresh();
                }
            }
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            grpData.Enabled = true;
            dgrOrderDetails.Enabled = false;
            bttSave.Enabled = true;
            bttCancel.Enabled = true;
            bttNew.Enabled = false;
            bttUpdate.Enabled = false;
            bttDelete.Enabled = false;
            txtOrder.Focus();
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrOrderDetails.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            orderDetailBindingSource.ResetBindings(false);
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrOrderDetails.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            if (MessageBox.Show(this, "Quieres eliminar el registro?", "CONFIRMACION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (DataContext dc = new DataContext())
                {
                    OrderDetail orderDetail = orderDetailBindingSource.Current as OrderDetail;
                    if (orderDetail != null)
                    {
                        if (dc.Entry<OrderDetail>(orderDetail).State == EntityState.Detached)
                        {
                            dc.Set<OrderDetail>().Attach(orderDetail);
                        }
                        dc.Entry<OrderDetail>(orderDetail).State = EntityState.Deleted;
                        dc.SaveChanges();
                        orderDetailBindingSource.RemoveCurrent();
                        MessageBox.Show(this, "Registro elimianado exitosamente");
                    }
                }
            }
        }

        private void dgrOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderDetail orderDetail = orderDetailBindingSource.Current as OrderDetail;
        }
    }
}
