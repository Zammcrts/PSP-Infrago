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
    public partial class frmProject : Form
    {
        public frmProject()
        {
            InitializeComponent();
        }

        private void frmProject_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmProject_Load(object sender, EventArgs e)
        {
            bttCancel.Enabled = false;
            bttSave.Enabled = false;
            grpData.Enabled = false;
            using (DataContext dc = new DataContext())
            {
                projectBindingSource.DataSource = dc.Projects.ToList();
            }
            cmbStatus.Items.Add("Activo");
            cmbStatus.Items.Add("Pendiente");
            cmbStatus.Items.Add("Terminado");
            cmbStatus.Items.Add("Cancelado");

            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void grdProject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Project project = projectBindingSource.Current as Project;
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            grpData.Enabled = true;
            dgrProject.Enabled = false;
            bttSave.Enabled = true;
            bttCancel.Enabled = true;
            bttNew.Enabled = false;
            bttUpdate.Enabled = false;
            bttDelete.Enabled = false;
            projectBindingSource.Add(new Project());
            projectBindingSource.MoveLast();
            txtProject.Focus();
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrProject.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            using (DataContext dc = new DataContext())
            {
                Project project = projectBindingSource.Current as Project;
                if (project != null)
                {
                    if (dc.Entry<Project>(project).State == EntityState.Detached)
                    {
                        dc.Set<Project>().Attach(project);
                    }
                    if (project.Id == 0)
                    {
                        dc.Entry<Project>(project).State = EntityState.Added;
                    }
                    else
                    {
                        dc.Entry<Project>(project).State = EntityState.Modified;
                    }
                    dc.SaveChanges();
                    MessageBox.Show(this, "Registro guardado exitosamente");
                    dgrProject.Refresh();
                }
            }
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            grpData.Enabled = true;
            dgrProject.Enabled = false;
            bttSave.Enabled = true;
            bttCancel.Enabled = true;
            bttNew.Enabled = false;
            bttUpdate.Enabled = false;
            bttDelete.Enabled = false;
            txtProject.Focus();
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrProject.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            projectBindingSource.ResetBindings(false);
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrProject.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            if (MessageBox.Show(this, "Quieres eliminar el registro?", "CONFIRMACION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (DataContext dc = new DataContext())
                {
                    Project project = projectBindingSource.Current as Project;
                    if (project != null)
                    {
                        if (dc.Entry<Project>(project).State == EntityState.Detached)
                        {
                            dc.Set<Project>().Attach(project);
                        }
                        dc.Entry<Project>(project).State = EntityState.Deleted;
                        dc.SaveChanges();
                        projectBindingSource.RemoveCurrent();
                        MessageBox.Show(this, "Registro elimianado exitosamente");
                    }
                }
            }
        }
    }
}
