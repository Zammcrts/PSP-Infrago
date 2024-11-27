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
    public partial class frmTool : Form
    {
        public frmTool()
        {
            InitializeComponent();
        }

        private void frmTool_Load(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            using (DataContext dataContext = new DataContext())
            {
                toolBindingSource.DataSource = dataContext.Tools.ToList();
            }
            grpData.Enabled = false;
            Tool tool = toolBindingSource.Current as Tool;
            if (tool != null && tool.Photo != null)
            {
                pctTool.Image = Image.FromFile(tool.Photo);
            }
            else
            {
                pctTool.Image = null;
            }
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
                    pctTool.Image = Image.FromFile(ofd.FileName);
                    Tool tool = toolBindingSource.Current as Tool;
                    if (tool != null)
                    {
                        tool.Photo = ofd.FileName;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            using (DataContext dc = new DataContext())
            {
                Tool tool = toolBindingSource.Current as Tool;
                if (tool != null)
                {
                    if (dc.Entry<Tool>(tool).State == EntityState.Detached)
                    {
                        dc.Set<Tool>().Attach(tool);
                    }
                    if (tool.Id == 0)
                    {
                        dc.Entry<Tool>(tool).State = EntityState.Added;
                    }
                    else
                    {
                        dc.Entry<Tool>(tool).State = EntityState.Modified;
                    }
                    dc.SaveChanges();
                    MessageBox.Show(this, "registro guardado :)");
                    grdTools.Refresh();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pctTool.Image = null;
            grpData.Enabled = true;
            grdTools.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            toolBindingSource.Add(new Tool());
            toolBindingSource.MoveLast();
            txtName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            grpData.Enabled = true;
            grpData.Enabled = true;
            grdTools.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Quieres eliminar el registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (DataContext dc = new DataContext())
                {
                    Tool tool = toolBindingSource.Current as Tool;
                    if (tool != null)
                    {
                        if (dc.Entry<Tool>(tool).State == EntityState.Detached)
                        {
                            dc.Set<Tool>().Attach(tool);
                        }
                        dc.Entry<Tool>(tool).State = EntityState.Deleted;
                        dc.SaveChanges();
                        MessageBox.Show(this, "Registro eliminado");
                        pctTool.Image = null;
                    }
                }
            }
            grpData.Enabled = true;
            grdTools.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            grdTools.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            toolBindingSource.ResetBindings(false);
            frmTool_Load(sender, e);
        }

        private void grdTools_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Tool tool = toolBindingSource.Current as Tool;
            if (tool != null && tool.Photo != null)
            {
                pctTool.Image = Image.FromFile(tool.Photo);
            }
            else
            {
                pctTool.Image = null;
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
                    pctTool.Image = Image.FromFile(ofd.FileName);
                    Tool tool = toolBindingSource.Current as Tool;
                    if (tool != null)
                    {
                        tool.Photo = ofd.FileName;
                    }
                }
            }
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            pctTool.Image = null;
            grpData.Enabled = true;
            grdTools.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            toolBindingSource.Add(new Tool());
            toolBindingSource.MoveLast();
            txtName.Focus();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            using (DataContext dc = new DataContext())
            {
                Tool tool = toolBindingSource.Current as Tool;
                if (tool != null)
                {
                    if (dc.Entry<Tool>(tool).State == EntityState.Detached)
                    {
                        dc.Set<Tool>().Attach(tool);
                    }
                    if (tool.Id == 0)
                    {
                        dc.Entry<Tool>(tool).State = EntityState.Added;
                    }
                    else
                    {
                        dc.Entry<Tool>(tool).State = EntityState.Modified;
                    }
                    dc.SaveChanges();
                    MessageBox.Show(this, "registro guardado :)");
                    grdTools.Refresh();
                }
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            grpData.Enabled = true;
            grpData.Enabled = true;
            grdTools.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtName.Focus();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Quieres eliminar el registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (DataContext dc = new DataContext())
                {
                    Tool tool = toolBindingSource.Current as Tool;
                    if (tool != null)
                    {
                        if (dc.Entry<Tool>(tool).State == EntityState.Detached)
                        {
                            dc.Set<Tool>().Attach(tool);
                        }
                        dc.Entry<Tool>(tool).State = EntityState.Deleted;
                        dc.SaveChanges();
                        MessageBox.Show(this, "Registro eliminado");
                        pctTool.Image = null;
                    }
                }
            }
            grpData.Enabled = true;
            grdTools.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            grdTools.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            toolBindingSource.ResetBindings(false);
            frmTool_Load(sender, e);
        }

        private void btnUpload_Click_2(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "JPEG|*.jpg"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pctTool.Image = Image.FromFile(ofd.FileName);
                    Tool tool = toolBindingSource.Current as Tool;
                    if (tool != null)
                    {
                        tool.Photo = ofd.FileName;
                    }
                }
            }
        }
    }
}
