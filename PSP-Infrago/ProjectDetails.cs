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
    public partial class frmProjectDetails : Form
    {
        public frmProjectDetails()
        {
            InitializeComponent();
        }

        private void frmProjectDetails_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            using (DataContext dataContext = new DataContext())
            {
                projectDetailsBindingSource.DataSource = dataContext.ProjectDetails.ToList();
            }
            ProjectDetails projectDetails = projectDetailsBindingSource.Current as ProjectDetails;
            if (projectDetails != null && projectDetails.Photo != null)
            {
                pctDetails.Image = Image.FromFile(projectDetails.Photo);
            }
            else
            {
                pctDetails.Image = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdProjectDetails.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            using (DataContext dc = new DataContext())
            {
                ProjectDetails projectDetails = projectDetailsBindingSource.Current as ProjectDetails;
                if (projectDetails != null)
                {
                    if (dc.Entry<ProjectDetails>(projectDetails).State == EntityState.Detached)
                    {
                        dc.Set<ProjectDetails>().Attach(projectDetails);
                    }
                    if (projectDetails.Id == 0)
                    {
                        dc.Entry<ProjectDetails>(projectDetails).State = EntityState.Added;
                    }
                    else
                    {
                        dc.Entry<ProjectDetails>(projectDetails).State = EntityState.Modified;
                    }
                    dc.SaveChanges();
                    MessageBox.Show(this, "registro guardado :)");
                    grdProjectDetails.Refresh();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            grdProjectDetails.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtService.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Quieres eliminar el registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (DataContext dc = new DataContext())
                {
                    ProjectDetails projectDetails = projectDetailsBindingSource.Current as ProjectDetails;
                    if (projectDetails != null)
                    {
                        if (dc.Entry<ProjectDetails>(projectDetails).State == EntityState.Detached)
                        {
                            dc.Set<ProjectDetails>().Attach(projectDetails);
                        }
                        dc.Entry<ProjectDetails>(projectDetails).State = EntityState.Deleted;
                        dc.SaveChanges();
                        MessageBox.Show(this, "Registro eliminado");
                        pctDetails.Image = null;
                    }
                }
            }
            grdProjectDetails.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pctDetails.Image = null;
            grdProjectDetails.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            projectDetailsBindingSource.Add(new Tool());
            projectDetailsBindingSource.MoveLast();
            txtService.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grdProjectDetails.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            projectDetailsBindingSource.ResetBindings(false);
            frmProjectDetails_Load(sender, e);
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
                    pctDetails.Image = Image.FromFile(ofd.FileName);
                    ProjectDetails projectDetails = projectDetailsBindingSource.Current as ProjectDetails;
                    if (projectDetails != null)
                    {
                        projectDetails.Photo = ofd.FileName;
                    }
                }
            }
        }
    }
}
