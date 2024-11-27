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
    public partial class frmMachineryAssignment : Form
    {
        public frmMachineryAssignment()
        {
            InitializeComponent();
        }

        private void frmMachineryAssignment_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            using (DataContext dataContext = new DataContext())
            {
                machineryAssignmentBindingSource.DataSource = dataContext.MachineryAssignments.ToList();
            }
            grpData.Enabled = false;
            MachineryAssignment machineryAssignment = machineryAssignmentBindingSource.Current as MachineryAssignment;
            if (machineryAssignment != null && machineryAssignment.Photo != null)
            {
                pctMachine.Image = Image.FromFile(machineryAssignment.Photo);
            }
            else
            {
                pctMachine.Image = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            grdMachineryAssignment.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            using (DataContext dc = new DataContext())
            {
                MachineryAssignment machineryAssignment = machineryAssignmentBindingSource.Current as MachineryAssignment;
                if (machineryAssignment != null)
                {
                    if (dc.Entry<MachineryAssignment>(machineryAssignment).State == EntityState.Detached)
                    {
                        dc.Set<MachineryAssignment>().Attach(machineryAssignment);
                    }
                    if (machineryAssignment.Id == 0)
                    {
                        dc.Entry<MachineryAssignment>(machineryAssignment).State = EntityState.Added;
                    }
                    else
                    {
                        dc.Entry<MachineryAssignment>(machineryAssignment).State = EntityState.Modified;
                    }
                    dc.SaveChanges();
                    MessageBox.Show(this, "registro guardado :)");
                    grdMachineryAssignment.Refresh();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            grpData.Enabled = true;
            grpData.Enabled = true;
            grdMachineryAssignment.Enabled = false;
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
                    MachineryAssignment machineryAssignment = machineryAssignmentBindingSource.Current as MachineryAssignment;
                    if (machineryAssignment != null)
                    {
                        if (dc.Entry<MachineryAssignment>(machineryAssignment).State == EntityState.Detached)
                        {
                            dc.Set<MachineryAssignment>().Attach(machineryAssignment);
                        }
                        dc.Entry<MachineryAssignment>(machineryAssignment).State = EntityState.Deleted;
                        dc.SaveChanges();
                        MessageBox.Show(this, "Registro eliminado");
                        pctMachine.Image = null;
                    }
                }
            }
            grpData.Enabled = true;
            grdMachineryAssignment.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pctMachine.Image = null;
            grpData.Enabled = true;
            grdMachineryAssignment.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            machineryAssignmentBindingSource.Add(new MachineryAssignment());
            machineryAssignmentBindingSource.MoveLast();
            txtMachine.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            grdMachineryAssignment.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            machineryAssignmentBindingSource.ResetBindings(false);
            frmMachineryAssignment_Load(sender, e);
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
                    MachineryAssignment machineryAssignment = machineryAssignmentBindingSource.Current as MachineryAssignment;
                    if (machineryAssignment != null)
                    {
                        machineryAssignment.Photo = ofd.FileName;
                    }
                }
            }
        }

        private void btnUpload_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "JPEG|*.jpg"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pctMachine.Image = Image.FromFile(ofd.FileName);
                    MachineryAssignment machineryAssignment = machineryAssignmentBindingSource.Current as MachineryAssignment;
                    if (machineryAssignment != null)
                    {
                        machineryAssignment.Photo = ofd.FileName;
                    }
                }
            }
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            grdMachineryAssignment.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            using (DataContext dc = new DataContext())
            {
                MachineryAssignment machineryAssignment = machineryAssignmentBindingSource.Current as MachineryAssignment;
                if (machineryAssignment != null)
                {
                    if (dc.Entry<MachineryAssignment>(machineryAssignment).State == EntityState.Detached)
                    {
                        dc.Set<MachineryAssignment>().Attach(machineryAssignment);
                    }
                    if (machineryAssignment.Id == 0)
                    {
                        dc.Entry<MachineryAssignment>(machineryAssignment).State = EntityState.Added;
                    }
                    else
                    {
                        dc.Entry<MachineryAssignment>(machineryAssignment).State = EntityState.Modified;
                    }
                    dc.SaveChanges();
                    MessageBox.Show(this, "registro guardado :)");
                    grdMachineryAssignment.Refresh();
                }
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            grpData.Enabled = true;
            grpData.Enabled = true;
            grdMachineryAssignment.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtMachine.Focus();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Quieres eliminar el registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (DataContext dc = new DataContext())
                {
                    MachineryAssignment machineryAssignment = machineryAssignmentBindingSource.Current as MachineryAssignment;
                    if (machineryAssignment != null)
                    {
                        if (dc.Entry<MachineryAssignment>(machineryAssignment).State == EntityState.Detached)
                        {
                            dc.Set<MachineryAssignment>().Attach(machineryAssignment);
                        }
                        dc.Entry<MachineryAssignment>(machineryAssignment).State = EntityState.Deleted;
                        dc.SaveChanges();
                        MessageBox.Show(this, "Registro eliminado");
                        pctMachine.Image = null;
                    }
                }
            }
            grpData.Enabled = true;
            grdMachineryAssignment.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            pctMachine.Image = null;
            grpData.Enabled = true;
            grdMachineryAssignment.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            machineryAssignmentBindingSource.Add(new MachineryAssignment());
            machineryAssignmentBindingSource.MoveLast();
            txtMachine.Focus();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            grdMachineryAssignment.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            machineryAssignmentBindingSource.ResetBindings(false);
            frmMachineryAssignment_Load(sender, e);
        }
    }
}
