using PSP_Infrago.Data;
using PSP_Infrago.Entities;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace PSP_Infrago
{
    public partial class frmDepartment : Form
    {
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void frmDepartment_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            grpData.Enabled = true;
            dgrDepartment.Enabled = false;
            bttSave.Enabled = true;
            bttCancel.Enabled = true;
            bttNew.Enabled = false;
            bttUpdate.Enabled = false;
            bttDelete.Enabled = false;
            departmentBindingSource.Add(new Department());
            departmentBindingSource.MoveLast();
            txtDepartmentName.Focus();
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrDepartment.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            using (DataContext dc = new DataContext())
            {
                Department department = departmentBindingSource.Current as Department;
                if (department != null)
                {
                    if (dc.Entry<Department>(department).State == EntityState.Detached)
                    {
                        dc.Set<Department>().Attach(department);
                    }
                    if (department.Id == 0)
                    {
                        dc.Entry<Department>(department).State = EntityState.Added;
                    }
                    else
                    {
                        dc.Entry<Department>(department).State = EntityState.Modified;
                    }
                    dc.SaveChanges();
                    MessageBox.Show(this, "Registro guardado exitosamente");
                    dgrDepartment.Refresh();
                }
            }
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            grpData.Enabled = true;
            dgrDepartment.Enabled = false;
            bttSave.Enabled = true;
            bttCancel.Enabled = true;
            bttNew.Enabled = false;
            bttUpdate.Enabled = false;
            bttDelete.Enabled = false;
            txtDepartmentName.Focus();
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrDepartment.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            departmentBindingSource.ResetBindings(false);
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrDepartment.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            if (MessageBox.Show(this, "Quieres eliminar el registro?", "CONFIRMACION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (DataContext dc = new DataContext())
                {
                    Department department = departmentBindingSource.Current as Department;
                    if (department != null)
                    {
                        if (dc.Entry<Department>(department).State == EntityState.Detached)
                        {
                            dc.Set<Department>().Attach(department);
                        }
                        dc.Entry<Department>(department).State = EntityState.Deleted;
                        dc.SaveChanges();
                        departmentBindingSource.RemoveCurrent();
                        MessageBox.Show(this, "Registro elimianado exitosamente");
                    }
                }
            }
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            bttCancel.Enabled = false;
            bttSave.Enabled = false;
            grpData.Enabled = false;
            using (DataContext dc = new DataContext())
            {
                departmentBindingSource.DataSource = dc.Departments.ToList();
            }
        }

        private void dgrDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Department department = departmentBindingSource.Current as Department;
        }
    }
}
