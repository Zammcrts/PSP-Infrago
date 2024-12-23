﻿namespace PSP_Infrago
{
    partial class frmToolAssignment
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
            this.toolAssignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpData = new System.Windows.Forms.GroupBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblProjectPicture = new System.Windows.Forms.Label();
            this.dtpToolAssignment = new System.Windows.Forms.DateTimePicker();
            this.pctAssignation = new System.Windows.Forms.PictureBox();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.txtTool = new System.Windows.Forms.TextBox();
            this.lblTool = new System.Windows.Forms.Label();
            this.lblAssignationDate = new System.Windows.Forms.Label();
            this.txtAssignationID = new System.Windows.Forms.TextBox();
            this.lblAssignationID = new System.Windows.Forms.Label();
            this.lblToolAssignment = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grdToolAssignment = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.toolAssignmentBindingSource)).BeginInit();
            this.grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAssignation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdToolAssignment)).BeginInit();
            this.SuspendLayout();
            // 
            // toolAssignmentBindingSource
            // 
            this.toolAssignmentBindingSource.DataSource = typeof(PSP_Infrago.Entities.ToolAssignment);
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.btnUpload);
            this.grpData.Controls.Add(this.lblProjectPicture);
            this.grpData.Controls.Add(this.dtpToolAssignment);
            this.grpData.Controls.Add(this.pctAssignation);
            this.grpData.Controls.Add(this.txtProject);
            this.grpData.Controls.Add(this.lblProject);
            this.grpData.Controls.Add(this.txtTool);
            this.grpData.Controls.Add(this.lblTool);
            this.grpData.Controls.Add(this.lblAssignationDate);
            this.grpData.Controls.Add(this.txtAssignationID);
            this.grpData.Controls.Add(this.lblAssignationID);
            this.grpData.Controls.Add(this.lblToolAssignment);
            this.grpData.Location = new System.Drawing.Point(42, 114);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(977, 499);
            this.grpData.TabIndex = 84;
            this.grpData.TabStop = false;
            this.grpData.Text = "Información";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Lavender;
            this.btnUpload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(729, 420);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(180, 38);
            this.btnUpload.TabIndex = 88;
            this.btnUpload.Text = "Cargar";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click_1);
            // 
            // lblProjectPicture
            // 
            this.lblProjectPicture.AutoSize = true;
            this.lblProjectPicture.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectPicture.Location = new System.Drawing.Point(662, 396);
            this.lblProjectPicture.Name = "lblProjectPicture";
            this.lblProjectPicture.Size = new System.Drawing.Size(306, 21);
            this.lblProjectPicture.TabIndex = 87;
            this.lblProjectPicture.Text = "Imágen de la Herramienta asignada";
            // 
            // dtpToolAssignment
            // 
            this.dtpToolAssignment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolAssignmentBindingSource, "Date", true));
            this.dtpToolAssignment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToolAssignment.Location = new System.Drawing.Point(280, 227);
            this.dtpToolAssignment.Name = "dtpToolAssignment";
            this.dtpToolAssignment.Size = new System.Drawing.Size(373, 32);
            this.dtpToolAssignment.TabIndex = 86;
            // 
            // pctAssignation
            // 
            this.pctAssignation.BackColor = System.Drawing.Color.Lavender;
            this.pctAssignation.Location = new System.Drawing.Point(675, 113);
            this.pctAssignation.Name = "pctAssignation";
            this.pctAssignation.Size = new System.Drawing.Size(278, 262);
            this.pctAssignation.TabIndex = 85;
            this.pctAssignation.TabStop = false;
            // 
            // txtProject
            // 
            this.txtProject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolAssignmentBindingSource, "Project", true));
            this.txtProject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProject.Location = new System.Drawing.Point(280, 334);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(373, 32);
            this.txtProject.TabIndex = 84;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(8, 343);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(98, 23);
            this.lblProject.TabIndex = 83;
            this.lblProject.Text = "Proyecto";
            // 
            // txtTool
            // 
            this.txtTool.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolAssignmentBindingSource, "Tool", true));
            this.txtTool.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTool.Location = new System.Drawing.Point(280, 277);
            this.txtTool.Name = "txtTool";
            this.txtTool.Size = new System.Drawing.Size(373, 32);
            this.txtTool.TabIndex = 82;
            // 
            // lblTool
            // 
            this.lblTool.AutoSize = true;
            this.lblTool.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTool.Location = new System.Drawing.Point(8, 286);
            this.lblTool.Name = "lblTool";
            this.lblTool.Size = new System.Drawing.Size(131, 23);
            this.lblTool.TabIndex = 81;
            this.lblTool.Text = "Herramienta";
            // 
            // lblAssignationDate
            // 
            this.lblAssignationDate.AutoSize = true;
            this.lblAssignationDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignationDate.Location = new System.Drawing.Point(8, 234);
            this.lblAssignationDate.Name = "lblAssignationDate";
            this.lblAssignationDate.Size = new System.Drawing.Size(205, 23);
            this.lblAssignationDate.TabIndex = 80;
            this.lblAssignationDate.Text = "Feca de Asignación";
            // 
            // txtAssignationID
            // 
            this.txtAssignationID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolAssignmentBindingSource, "Id", true));
            this.txtAssignationID.Enabled = false;
            this.txtAssignationID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignationID.Location = new System.Drawing.Point(280, 174);
            this.txtAssignationID.Name = "txtAssignationID";
            this.txtAssignationID.Size = new System.Drawing.Size(373, 32);
            this.txtAssignationID.TabIndex = 79;
            // 
            // lblAssignationID
            // 
            this.lblAssignationID.AutoSize = true;
            this.lblAssignationID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignationID.Location = new System.Drawing.Point(8, 183);
            this.lblAssignationID.Name = "lblAssignationID";
            this.lblAssignationID.Size = new System.Drawing.Size(175, 23);
            this.lblAssignationID.TabIndex = 78;
            this.lblAssignationID.Text = "ID de Asignación";
            // 
            // lblToolAssignment
            // 
            this.lblToolAssignment.AutoSize = true;
            this.lblToolAssignment.BackColor = System.Drawing.Color.Lavender;
            this.lblToolAssignment.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolAssignment.Location = new System.Drawing.Point(302, 41);
            this.lblToolAssignment.Name = "lblToolAssignment";
            this.lblToolAssignment.Size = new System.Drawing.Size(387, 34);
            this.lblToolAssignment.TabIndex = 77;
            this.lblToolAssignment.Text = "Asignación de Herramienta";
            this.lblToolAssignment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Lavender;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(344, 706);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 38);
            this.btnCancel.TabIndex = 83;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // grdToolAssignment
            // 
            this.grdToolAssignment.AutoGenerateColumns = false;
            this.grdToolAssignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdToolAssignment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.toolDataGridViewTextBoxColumn,
            this.projectDataGridViewTextBoxColumn});
            this.grdToolAssignment.DataSource = this.toolAssignmentBindingSource;
            this.grdToolAssignment.Location = new System.Drawing.Point(1044, 173);
            this.grdToolAssignment.Name = "grdToolAssignment";
            this.grdToolAssignment.RowHeadersWidth = 51;
            this.grdToolAssignment.RowTemplate.Height = 24;
            this.grdToolAssignment.Size = new System.Drawing.Size(597, 509);
            this.grdToolAssignment.TabIndex = 82;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // toolDataGridViewTextBoxColumn
            // 
            this.toolDataGridViewTextBoxColumn.DataPropertyName = "Tool";
            this.toolDataGridViewTextBoxColumn.HeaderText = "Tool";
            this.toolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toolDataGridViewTextBoxColumn.Name = "toolDataGridViewTextBoxColumn";
            this.toolDataGridViewTextBoxColumn.ReadOnly = true;
            this.toolDataGridViewTextBoxColumn.Width = 125;
            // 
            // projectDataGridViewTextBoxColumn
            // 
            this.projectDataGridViewTextBoxColumn.DataPropertyName = "Project";
            this.projectDataGridViewTextBoxColumn.HeaderText = "Project";
            this.projectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectDataGridViewTextBoxColumn.Name = "projectDataGridViewTextBoxColumn";
            this.projectDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Lavender;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(650, 644);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(180, 38);
            this.btnNew.TabIndex = 81;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Lavender;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(445, 644);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 38);
            this.btnDelete.TabIndex = 80;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lavender;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(241, 644);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 38);
            this.btnUpdate.TabIndex = 79;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lavender;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(42, 644);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 38);
            this.btnSave.TabIndex = 78;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // frmToolAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 859);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grdToolAssignment);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Name = "frmToolAssignment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignación de Herramienta";
            this.Load += new System.EventHandler(this.frmToolAssignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toolAssignmentBindingSource)).EndInit();
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAssignation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdToolAssignment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource toolAssignmentBindingSource;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblProjectPicture;
        private System.Windows.Forms.DateTimePicker dtpToolAssignment;
        private System.Windows.Forms.PictureBox pctAssignation;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.TextBox txtTool;
        private System.Windows.Forms.Label lblTool;
        private System.Windows.Forms.Label lblAssignationDate;
        private System.Windows.Forms.TextBox txtAssignationID;
        private System.Windows.Forms.Label lblAssignationID;
        private System.Windows.Forms.Label lblToolAssignment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView grdToolAssignment;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
    }
}