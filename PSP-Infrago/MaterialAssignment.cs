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
    public partial class frmMaterialAssignment : Form
    {
        public frmMaterialAssignment()
        {
            InitializeComponent();
        }

        private void frmMaterialAssignment_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmMaterialAssignment_Load(object sender, EventArgs e)
        {
            bttCancel.Enabled = false;
            bttSave.Enabled = false;
            grpData.Enabled = false;
            using (DataContext dc = new DataContext())
            {
                materialAssignmentBindingSource.DataSource = dc.MaterialAssignments.ToList();
            }
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            grpData.Enabled = true;
            dgrMaterialAssignment.Enabled = false;
            bttSave.Enabled = true;
            bttCancel.Enabled = true;
            bttNew.Enabled = false;
            bttUpdate.Enabled = false;
            bttDelete.Enabled = false;
            materialAssignmentBindingSource.Add(new MaterialAssignment());
            materialAssignmentBindingSource.MoveLast();
            txtMaterial.Focus();
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrMaterialAssignment.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            using (DataContext dc = new DataContext())
            {
                MaterialAssignment materialAssignment = materialAssignmentBindingSource.Current as MaterialAssignment;
                if (materialAssignment != null)
                {
                    if (dc.Entry<MaterialAssignment>(materialAssignment).State == EntityState.Detached)
                    {
                        dc.Set<MaterialAssignment>().Attach(materialAssignment);
                    }
                    if (materialAssignment.Id == 0)
                    {
                        dc.Entry<MaterialAssignment>(materialAssignment).State = EntityState.Added;
                    }
                    else
                    {
                        dc.Entry<MaterialAssignment>(materialAssignment).State = EntityState.Modified;
                    }
                    dc.SaveChanges();
                    MessageBox.Show(this, "Registro guardado exitosamente");
                    dgrMaterialAssignment.Refresh();
                }
            }
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            grpData.Enabled = true;
            dgrMaterialAssignment.Enabled = false;
            bttSave.Enabled = true;
            bttCancel.Enabled = true;
            bttNew.Enabled = false;
            bttUpdate.Enabled = false;
            bttDelete.Enabled = false;
            txtMaterial.Focus();
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrMaterialAssignment.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            materialAssignmentBindingSource.ResetBindings(false);
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrMaterialAssignment.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            if (MessageBox.Show(this, "Quieres eliminar el registro?", "CONFIRMACION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (DataContext dc = new DataContext())
                {
                    MaterialAssignment materialAssignment = materialAssignmentBindingSource.Current as MaterialAssignment;
                    if (materialAssignment != null)
                    {
                        if (dc.Entry<MaterialAssignment>(materialAssignment).State == EntityState.Detached)
                        {
                            dc.Set<MaterialAssignment>().Attach(materialAssignment);
                        }
                        dc.Entry<MaterialAssignment>(materialAssignment).State = EntityState.Deleted;
                        dc.SaveChanges();
                        materialAssignmentBindingSource.RemoveCurrent();
                        MessageBox.Show(this, "Registro elimianado exitosamente");
                    }
                }
            }
        }
    }
}
