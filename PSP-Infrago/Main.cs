using System;
using System.Windows.Forms;

namespace PSP_Infrago
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClient frm = new frmClient();
            frm.MdiParent = this;
            frm.Show();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartment frm = new frmDepartment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterial frm = new frmMaterial();
            frm.MdiParent = this;
            frm.Show();
        }

        private void detallesDeOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderDetail frm = new frmOrderDetail();
            frm.MdiParent = this;
            frm.Show();
        }

        private void asignaciónDelMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterialAssignment frm = new frmMaterialAssignment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            frm.MdiParent = this;
            frm.Show();
        }

        private void proyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProject frm = new frmProject();
            frm.MdiParent = this;
            frm.Show();

        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProvider frm = new frmProvider();
            frm.MdiParent = this;
            frm.Show();
        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTool frm = new frmTool();
            frm.MdiParent = this;
            frm.Show();
        }

        private void asignaciónDeHerramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmToolAssignment frm = new frmToolAssignment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintenance frm = new frmMaintenance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void detallesDeMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintenanceDetails frm = new frmMaintenanceDetails();
            frm.MdiParent = this;
            frm.Show();
        }

        private void maquinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMachinery frm = new frmMachinery();
            frm.MdiParent = this;
            frm.Show();
        }

        private void asignaciónDeMaquinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMachineryAssignment frm = new frmMachineryAssignment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void detallesDelProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProjectDetails frm = new frmProjectDetails();
            frm.MdiParent = this;
            frm.Show();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmService frm = new frmService();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
