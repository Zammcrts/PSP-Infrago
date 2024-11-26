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
    public partial class frmToolAssignment : Form
    {
        public frmToolAssignment()
        {
            InitializeComponent();
        }

        private void frmToolAssignment_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            using (DataContext dataContext = new DataContext())
            {
                toolAssignmentBindingSource.DataSource = dataContext.ToolAssignments.ToList();
            }
            ToolAssignment toolAssignment = toolAssignmentBindingSource.Current as ToolAssignment;
            if (toolAssignment != null && toolAssignment.Photo != null)
            {
                pctAssignation.Image = Image.FromFile(toolAssignment.Photo);
            }
            else
            {
                pctAssignation.Image = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdToolAssignment.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            using (DataContext dc = new DataContext())
            {
                ToolAssignment toolAssignment = toolAssignmentBindingSource.Current as ToolAssignment;
                if (toolAssignment != null)
                {
                    if (dc.Entry<ToolAssignment>(toolAssignment).State == EntityState.Detached)
                    {
                        dc.Set<ToolAssignment>().Attach(toolAssignment);
                    }
                    if (toolAssignment.Id == 0)
                    {
                        dc.Entry<ToolAssignment>(toolAssignment).State = EntityState.Added;
                    }
                    else
                    {
                        dc.Entry<ToolAssignment>(toolAssignment).State = EntityState.Modified;
                    }
                    dc.SaveChanges();
                    MessageBox.Show(this, "registro guardado :)");
                    grdToolAssignment.Refresh();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            grdToolAssignment.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtTool.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Quieres eliminar el registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (DataContext dc = new DataContext())
                {
                    ToolAssignment toolAssignment = toolAssignmentBindingSource.Current as ToolAssignment;
                    if (toolAssignment != null)
                    {
                        if (dc.Entry<ToolAssignment>(toolAssignment).State == EntityState.Detached)
                        {
                            dc.Set<ToolAssignment>().Attach(toolAssignment);
                        }
                        dc.Entry<ToolAssignment>(toolAssignment).State = EntityState.Deleted;
                        dc.SaveChanges();
                        MessageBox.Show(this, "Registro eliminado");
                        pctAssignation.Image = null;
                    }
                }
            }
            grdToolAssignment.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pctAssignation.Image = null;
            grdToolAssignment.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            toolAssignmentBindingSource.Add(new Tool());
            toolAssignmentBindingSource.MoveLast();
            txtTool.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grdToolAssignment.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            toolAssignmentBindingSource.ResetBindings(false);
            frmToolAssignment_Load(sender, e);
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
                    pctAssignation.Image = Image.FromFile(ofd.FileName);
                    ToolAssignment toolAssignment = toolAssignmentBindingSource.Current as ToolAssignment;
                    if (toolAssignment != null)
                    {
                        toolAssignment.Photo = ofd.FileName;
                    }
                }
            }
        }
    }
}
