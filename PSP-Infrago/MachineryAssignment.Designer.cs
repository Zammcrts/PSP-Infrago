namespace PSP_Infrago
{
    partial class frmMachineryAssignment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMachinePicture = new System.Windows.Forms.Label();
            this.pctMachine = new System.Windows.Forms.PictureBox();
            this.dtpAssignation = new System.Windows.Forms.DateTimePicker();
            this.machineryAssignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMachine = new System.Windows.Forms.TextBox();
            this.lblMachinery = new System.Windows.Forms.Label();
            this.lblAssignmentDate = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblMachineryAssignment = new System.Windows.Forms.Label();
            this.grdMachineryAssignment = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineryAssignmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMachineryAssignment)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMachinePicture
            // 
            this.lblMachinePicture.AutoSize = true;
            this.lblMachinePicture.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachinePicture.Location = new System.Drawing.Point(749, 553);
            this.lblMachinePicture.Name = "lblMachinePicture";
            this.lblMachinePicture.Size = new System.Drawing.Size(197, 21);
            this.lblMachinePicture.TabIndex = 69;
            this.lblMachinePicture.Text = "Imágen de la Máquina";
            // 
            // pctMachine
            // 
            this.pctMachine.BackColor = System.Drawing.Color.Aquamarine;
            this.pctMachine.Location = new System.Drawing.Point(708, 277);
            this.pctMachine.Name = "pctMachine";
            this.pctMachine.Size = new System.Drawing.Size(278, 262);
            this.pctMachine.TabIndex = 68;
            this.pctMachine.TabStop = false;
            // 
            // dtpAssignation
            // 
            this.dtpAssignation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machineryAssignmentBindingSource, "AssignationDate", true));
            this.dtpAssignation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAssignation.Location = new System.Drawing.Point(306, 408);
            this.dtpAssignation.Name = "dtpAssignation";
            this.dtpAssignation.Size = new System.Drawing.Size(373, 32);
            this.dtpAssignation.TabIndex = 67;
            // 
            // machineryAssignmentBindingSource
            // 
            this.machineryAssignmentBindingSource.DataSource = typeof(PSP_Infrago.Entities.MachineryAssignment);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Aquamarine;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(737, 659);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(180, 38);
            this.btnNew.TabIndex = 66;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Aquamarine;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(532, 659);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 38);
            this.btnDelete.TabIndex = 65;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Aquamarine;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(328, 659);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 38);
            this.btnUpdate.TabIndex = 64;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(129, 659);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 38);
            this.btnSave.TabIndex = 63;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMachine
            // 
            this.txtMachine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machineryAssignmentBindingSource, "Machine", true));
            this.txtMachine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachine.Location = new System.Drawing.Point(306, 458);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.Size = new System.Drawing.Size(373, 32);
            this.txtMachine.TabIndex = 62;
            // 
            // lblMachinery
            // 
            this.lblMachinery.AutoSize = true;
            this.lblMachinery.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachinery.Location = new System.Drawing.Point(34, 467);
            this.lblMachinery.Name = "lblMachinery";
            this.lblMachinery.Size = new System.Drawing.Size(96, 23);
            this.lblMachinery.TabIndex = 61;
            this.lblMachinery.Text = "Maquina";
            // 
            // lblAssignmentDate
            // 
            this.lblAssignmentDate.AutoSize = true;
            this.lblAssignmentDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignmentDate.Location = new System.Drawing.Point(34, 415);
            this.lblAssignmentDate.Name = "lblAssignmentDate";
            this.lblAssignmentDate.Size = new System.Drawing.Size(217, 23);
            this.lblAssignmentDate.TabIndex = 60;
            this.lblAssignmentDate.Text = "Fecha de Asignación";
            // 
            // txtProject
            // 
            this.txtProject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machineryAssignmentBindingSource, "Project", true));
            this.txtProject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProject.Location = new System.Drawing.Point(306, 355);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(373, 32);
            this.txtProject.TabIndex = 59;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(34, 364);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(98, 23);
            this.lblProject.TabIndex = 58;
            this.lblProject.Text = "Proyecto";
            // 
            // lblMachineryAssignment
            // 
            this.lblMachineryAssignment.AutoSize = true;
            this.lblMachineryAssignment.BackColor = System.Drawing.Color.Aquamarine;
            this.lblMachineryAssignment.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineryAssignment.Location = new System.Drawing.Point(338, 187);
            this.lblMachineryAssignment.Name = "lblMachineryAssignment";
            this.lblMachineryAssignment.Size = new System.Drawing.Size(374, 34);
            this.lblMachineryAssignment.TabIndex = 57;
            this.lblMachineryAssignment.Text = "Asignación de Maquinaria";
            this.lblMachineryAssignment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grdMachineryAssignment
            // 
            this.grdMachineryAssignment.AutoGenerateColumns = false;
            this.grdMachineryAssignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMachineryAssignment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.projectDataGridViewTextBoxColumn,
            this.assignationDateDataGridViewTextBoxColumn,
            this.machineDataGridViewTextBoxColumn});
            this.grdMachineryAssignment.DataSource = this.machineryAssignmentBindingSource;
            this.grdMachineryAssignment.Location = new System.Drawing.Point(1072, 187);
            this.grdMachineryAssignment.Name = "grdMachineryAssignment";
            this.grdMachineryAssignment.RowHeadersWidth = 51;
            this.grdMachineryAssignment.RowTemplate.Height = 24;
            this.grdMachineryAssignment.Size = new System.Drawing.Size(541, 484);
            this.grdMachineryAssignment.TabIndex = 70;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // projectDataGridViewTextBoxColumn
            // 
            this.projectDataGridViewTextBoxColumn.DataPropertyName = "Project";
            this.projectDataGridViewTextBoxColumn.HeaderText = "Project";
            this.projectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectDataGridViewTextBoxColumn.Name = "projectDataGridViewTextBoxColumn";
            this.projectDataGridViewTextBoxColumn.Width = 125;
            // 
            // assignationDateDataGridViewTextBoxColumn
            // 
            this.assignationDateDataGridViewTextBoxColumn.DataPropertyName = "AssignationDate";
            this.assignationDateDataGridViewTextBoxColumn.HeaderText = "AssignationDate";
            this.assignationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assignationDateDataGridViewTextBoxColumn.Name = "assignationDateDataGridViewTextBoxColumn";
            this.assignationDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // machineDataGridViewTextBoxColumn
            // 
            this.machineDataGridViewTextBoxColumn.DataPropertyName = "Machine";
            this.machineDataGridViewTextBoxColumn.HeaderText = "Machine";
            this.machineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.machineDataGridViewTextBoxColumn.Name = "machineDataGridViewTextBoxColumn";
            this.machineDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Aquamarine;
            this.btnUpload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(753, 577);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(180, 38);
            this.btnUpload.TabIndex = 71;
            this.btnUpload.Text = "Cargar";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(434, 718);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 38);
            this.btnCancel.TabIndex = 72;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmMachineryAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 859);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.grdMachineryAssignment);
            this.Controls.Add(this.lblMachinePicture);
            this.Controls.Add(this.pctMachine);
            this.Controls.Add(this.dtpAssignation);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMachine);
            this.Controls.Add(this.lblMachinery);
            this.Controls.Add(this.lblAssignmentDate);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblMachineryAssignment);
            this.Name = "frmMachineryAssignment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignación de Maquinaria";
            this.Load += new System.EventHandler(this.frmMachineryAssignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineryAssignmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMachineryAssignment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMachinePicture;
        private System.Windows.Forms.PictureBox pctMachine;
        private System.Windows.Forms.DateTimePicker dtpAssignation;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMachine;
        private System.Windows.Forms.Label lblMachinery;
        private System.Windows.Forms.Label lblAssignmentDate;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblMachineryAssignment;
        private System.Windows.Forms.DataGridView grdMachineryAssignment;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource machineryAssignmentBindingSource;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnCancel;
    }
}