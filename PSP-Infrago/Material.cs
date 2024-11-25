using PSP_Infrago.Data;
using PSP_Infrago.Entities;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace PSP_Infrago
{
    public partial class frmMaterial : Form
    {
        public frmMaterial()
        {
            InitializeComponent();
        }

        private void frmMaterial_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrMaterial.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            if (MessageBox.Show(this, "Quieres eliminar el registro?", "CONFIRMACION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (DataContext dc = new DataContext())
                {
                    Material material = materialBindingSource.Current as Material;
                    if (material != null)
                    {
                        if (dc.Entry<Material>(material).State == EntityState.Detached)
                        {
                            dc.Set<Material>().Attach(material);
                        }
                        dc.Entry<Material>(material).State = EntityState.Deleted;
                        dc.SaveChanges();
                        materialBindingSource.RemoveCurrent();
                        MessageBox.Show(this, "Registro elimianado exitosamente");
                    }
                }
            }
        }
        private void bttSave_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrMaterial.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            using (DataContext dc = new DataContext())
            {
                Material material = materialBindingSource.Current as Material;
                if (material != null)
                {
                    if (dc.Entry<Material>(material).State == EntityState.Detached)
                    {
                        dc.Set<Material>().Attach(material);
                    }
                    if (material.Id == 0)
                    {
                        dc.Entry<Material>(material).State = EntityState.Added;
                    }
                    else
                    {
                        dc.Entry<Material>(material).State = EntityState.Modified;
                    }
                    dc.SaveChanges();
                    MessageBox.Show(this, "Registro guardado exitosamente");
                    dgrMaterial.Refresh();
                }
            }
        }
        private void bttUpdate_Click(object sender, EventArgs e)
        {
            grpData.Enabled = true;
            dgrMaterial.Enabled = false;
            bttSave.Enabled = true;
            bttCancel.Enabled = true;
            bttNew.Enabled = false;
            bttUpdate.Enabled = false;
            bttDelete.Enabled = false;
            txtMaterialName.Focus();
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            grpData.Enabled = false;
            dgrMaterial.Enabled = true;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttNew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            materialBindingSource.ResetBindings(false);
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            grpData.Enabled = true;
            dgrMaterial.Enabled = false;
            bttSave.Enabled = true;
            bttCancel.Enabled = true;
            bttNew.Enabled = false;
            bttUpdate.Enabled = false;
            bttDelete.Enabled = false;
            materialBindingSource.Add(new Material());
            materialBindingSource.MoveLast();
            txtMaterialName.Focus();
        }

        private void frmMaterial_Load(object sender, EventArgs e)
        {
            bttCancel.Enabled = false;
            bttSave.Enabled = false;
            grpData.Enabled = false;
            using (DataContext dc = new DataContext())
            {
                materialBindingSource.DataSource = dc.Materials.ToList();
            }
        }

        private void dgrMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Material material = materialBindingSource.Current as Material;
        }
    }
}
