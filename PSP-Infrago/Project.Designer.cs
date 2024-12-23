﻿namespace PSP_Infrago
{
    partial class frmProject
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
            this.pnlStyle2 = new System.Windows.Forms.Panel();
            this.pnlStyle1 = new System.Windows.Forms.Panel();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dttAssignationDate = new System.Windows.Forms.DateTimePicker();
            this.dttEndDate = new System.Windows.Forms.DateTimePicker();
            this.dttStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAssignationDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.bttNew = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.bttUpdate = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgrProject = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrProject)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStyle2
            // 
            this.pnlStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.pnlStyle2.Location = new System.Drawing.Point(-3, 639);
            this.pnlStyle2.Name = "pnlStyle2";
            this.pnlStyle2.Size = new System.Drawing.Size(1692, 37);
            this.pnlStyle2.TabIndex = 8;
            // 
            // pnlStyle1
            // 
            this.pnlStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.pnlStyle1.Location = new System.Drawing.Point(-3, -4);
            this.pnlStyle1.Name = "pnlStyle1";
            this.pnlStyle1.Size = new System.Drawing.Size(1686, 39);
            this.pnlStyle1.TabIndex = 7;
            // 
            // grpData
            // 
            this.grpData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.grpData.Controls.Add(this.cmbStatus);
            this.grpData.Controls.Add(this.dttAssignationDate);
            this.grpData.Controls.Add(this.dttEndDate);
            this.grpData.Controls.Add(this.dttStartDate);
            this.grpData.Controls.Add(this.txtBudget);
            this.grpData.Controls.Add(this.txtProject);
            this.grpData.Controls.Add(this.txtClient);
            this.grpData.Controls.Add(this.lblStatus);
            this.grpData.Controls.Add(this.lblAssignationDate);
            this.grpData.Controls.Add(this.lblEndDate);
            this.grpData.Controls.Add(this.lblStartDate);
            this.grpData.Controls.Add(this.lblBudget);
            this.grpData.Controls.Add(this.lblProject);
            this.grpData.Controls.Add(this.lblClient);
            this.grpData.Font = new System.Drawing.Font("Typo Grotesk", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpData.Location = new System.Drawing.Point(22, 111);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(914, 467);
            this.grpData.TabIndex = 6;
            this.grpData.TabStop = false;
            this.grpData.Text = "Datos del proyecto";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "Status", true));
            this.cmbStatus.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(249, 397);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(637, 34);
            this.cmbStatus.TabIndex = 14;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(PSP_Infrago.Entities.Project);
            // 
            // dttAssignationDate
            // 
            this.dttAssignationDate.CalendarFont = new System.Drawing.Font("Typo Grotesk", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttAssignationDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "AssignationDate", true));
            this.dttAssignationDate.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttAssignationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttAssignationDate.Location = new System.Drawing.Point(262, 341);
            this.dttAssignationDate.Name = "dttAssignationDate";
            this.dttAssignationDate.Size = new System.Drawing.Size(163, 34);
            this.dttAssignationDate.TabIndex = 13;
            // 
            // dttEndDate
            // 
            this.dttEndDate.CalendarFont = new System.Drawing.Font("Typo Grotesk", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "EndDate", true));
            this.dttEndDate.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttEndDate.Location = new System.Drawing.Point(262, 279);
            this.dttEndDate.Name = "dttEndDate";
            this.dttEndDate.Size = new System.Drawing.Size(163, 34);
            this.dttEndDate.TabIndex = 12;
            // 
            // dttStartDate
            // 
            this.dttStartDate.CalendarFont = new System.Drawing.Font("Typo Grotesk", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "StartDate", true));
            this.dttStartDate.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttStartDate.Location = new System.Drawing.Point(262, 214);
            this.dttStartDate.Name = "dttStartDate";
            this.dttStartDate.Size = new System.Drawing.Size(163, 34);
            this.dttStartDate.TabIndex = 11;
            // 
            // txtBudget
            // 
            this.txtBudget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBudget.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "Budget", true));
            this.txtBudget.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBudget.Location = new System.Drawing.Point(159, 154);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(142, 34);
            this.txtBudget.TabIndex = 10;
            // 
            // txtProject
            // 
            this.txtProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "ProjectName", true));
            this.txtProject.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProject.Location = new System.Drawing.Point(159, 102);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(727, 34);
            this.txtProject.TabIndex = 9;
            // 
            // txtClient
            // 
            this.txtClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "Client", true));
            this.txtClient.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClient.Location = new System.Drawing.Point(159, 47);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(727, 34);
            this.txtClient.TabIndex = 8;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(17, 404);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(226, 26);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Estado del Proyecto:";
            // 
            // lblAssignationDate
            // 
            this.lblAssignationDate.AutoSize = true;
            this.lblAssignationDate.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignationDate.Location = new System.Drawing.Point(17, 342);
            this.lblAssignationDate.Name = "lblAssignationDate";
            this.lblAssignationDate.Size = new System.Drawing.Size(241, 26);
            this.lblAssignationDate.TabIndex = 6;
            this.lblAssignationDate.Text = "Fecha de Asignación:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(17, 280);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(214, 26);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "Fecha de Termino:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(17, 215);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(182, 26);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Fecha de Inicio:";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.Location = new System.Drawing.Point(17, 157);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(141, 26);
            this.lblBudget.TabIndex = 3;
            this.lblBudget.Text = "Presupuesto:";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(17, 105);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(109, 26);
            this.lblProject.TabIndex = 2;
            this.lblProject.Text = "Proyecto:";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(17, 50);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(91, 26);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "Cliente:";
            // 
            // bttNew
            // 
            this.bttNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
            this.bttNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttNew.Font = new System.Drawing.Font("Typo Grotesk", 11.2F);
            this.bttNew.Location = new System.Drawing.Point(127, 599);
            this.bttNew.Name = "bttNew";
            this.bttNew.Size = new System.Drawing.Size(122, 33);
            this.bttNew.TabIndex = 25;
            this.bttNew.Text = "Nuevo";
            this.bttNew.UseVisualStyleBackColor = false;
            this.bttNew.Click += new System.EventHandler(this.bttNew_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
            this.bttCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancel.Font = new System.Drawing.Font("Typo Grotesk", 11.2F);
            this.bttCancel.Location = new System.Drawing.Point(547, 599);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(122, 33);
            this.bttCancel.TabIndex = 24;
            this.bttCancel.Text = "Cancelar";
            this.bttCancel.UseVisualStyleBackColor = false;
            this.bttCancel.Click += new System.EventHandler(this.bttCancel_Click);
            // 
            // bttUpdate
            // 
            this.bttUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
            this.bttUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttUpdate.Font = new System.Drawing.Font("Typo Grotesk", 11.2F);
            this.bttUpdate.Location = new System.Drawing.Point(409, 599);
            this.bttUpdate.Name = "bttUpdate";
            this.bttUpdate.Size = new System.Drawing.Size(122, 33);
            this.bttUpdate.TabIndex = 23;
            this.bttUpdate.Text = "Actualizar";
            this.bttUpdate.UseVisualStyleBackColor = false;
            this.bttUpdate.Click += new System.EventHandler(this.bttUpdate_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
            this.bttDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDelete.Font = new System.Drawing.Font("Typo Grotesk", 11.2F);
            this.bttDelete.Location = new System.Drawing.Point(689, 599);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(122, 33);
            this.bttDelete.TabIndex = 22;
            this.bttDelete.Text = "Eliminar";
            this.bttDelete.UseVisualStyleBackColor = false;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttSave
            // 
            this.bttSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
            this.bttSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSave.Font = new System.Drawing.Font("Typo Grotesk", 11.2F);
            this.bttSave.Location = new System.Drawing.Point(269, 599);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(122, 33);
            this.bttSave.TabIndex = 21;
            this.bttSave.Text = "Guardar";
            this.bttSave.UseVisualStyleBackColor = false;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Typo Grotesk", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(241, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(479, 53);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Registro de Proyecto";
            // 
            // dgrProject
            // 
            this.dgrProject.AutoGenerateColumns = false;
            this.dgrProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.projectNameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.assignationDateDataGridViewTextBoxColumn,
            this.budgetDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgrProject.DataSource = this.projectBindingSource;
            this.dgrProject.Location = new System.Drawing.Point(942, 42);
            this.dgrProject.Name = "dgrProject";
            this.dgrProject.RowHeadersWidth = 51;
            this.dgrProject.RowTemplate.Height = 24;
            this.dgrProject.Size = new System.Drawing.Size(728, 590);
            this.dgrProject.TabIndex = 9;
            this.dgrProject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProject_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.Width = 125;
            // 
            // projectNameDataGridViewTextBoxColumn
            // 
            this.projectNameDataGridViewTextBoxColumn.DataPropertyName = "ProjectName";
            this.projectNameDataGridViewTextBoxColumn.HeaderText = "ProjectName";
            this.projectNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectNameDataGridViewTextBoxColumn.Name = "projectNameDataGridViewTextBoxColumn";
            this.projectNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // assignationDateDataGridViewTextBoxColumn
            // 
            this.assignationDateDataGridViewTextBoxColumn.DataPropertyName = "AssignationDate";
            this.assignationDateDataGridViewTextBoxColumn.HeaderText = "AssignationDate";
            this.assignationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assignationDateDataGridViewTextBoxColumn.Name = "assignationDateDataGridViewTextBoxColumn";
            this.assignationDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // budgetDataGridViewTextBoxColumn
            // 
            this.budgetDataGridViewTextBoxColumn.DataPropertyName = "Budget";
            this.budgetDataGridViewTextBoxColumn.HeaderText = "Budget";
            this.budgetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.budgetDataGridViewTextBoxColumn.Name = "budgetDataGridViewTextBoxColumn";
            this.budgetDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1682, 673);
            this.Controls.Add(this.bttNew);
            this.Controls.Add(this.dgrProject);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.pnlStyle2);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.pnlStyle1);
            this.Controls.Add(this.bttUpdate);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProject_FormClosed);
            this.Load += new System.EventHandler(this.frmProject_Load);
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlStyle2;
        private System.Windows.Forms.Panel pnlStyle1;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.DateTimePicker dttAssignationDate;
        private System.Windows.Forms.DateTimePicker dttEndDate;
        private System.Windows.Forms.DateTimePicker dttStartDate;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAssignationDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button bttNew;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.Button bttUpdate;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.DataGridView dgrProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}