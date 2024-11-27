namespace PSP_Infrago
{
    partial class frmProjectDetails
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
            this.projectDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpData = new System.Windows.Forms.GroupBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblProjectPicture = new System.Windows.Forms.Label();
            this.pctDetails = new System.Windows.Forms.PictureBox();
            this.txtService = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtServiceType = new System.Windows.Forms.TextBox();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblProjectDetail = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grdProjectDetails = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projectDetailsBindingSource)).BeginInit();
            this.grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProjectDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // projectDetailsBindingSource
            // 
            this.projectDetailsBindingSource.DataSource = typeof(PSP_Infrago.Entities.ProjectDetails);
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.btnUpload);
            this.grpData.Controls.Add(this.lblProjectPicture);
            this.grpData.Controls.Add(this.pctDetails);
            this.grpData.Controls.Add(this.txtService);
            this.grpData.Controls.Add(this.lblService);
            this.grpData.Controls.Add(this.txtProject);
            this.grpData.Controls.Add(this.lblProject);
            this.grpData.Controls.Add(this.txtCost);
            this.grpData.Controls.Add(this.lblCost);
            this.grpData.Controls.Add(this.txtServiceType);
            this.grpData.Controls.Add(this.lblServiceType);
            this.grpData.Controls.Add(this.txtDescription);
            this.grpData.Controls.Add(this.lblDescription);
            this.grpData.Controls.Add(this.lblProjectDetail);
            this.grpData.Location = new System.Drawing.Point(49, 104);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(990, 525);
            this.grpData.TabIndex = 85;
            this.grpData.TabStop = false;
            this.grpData.Text = "información";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.GreenYellow;
            this.btnUpload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(742, 434);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(180, 38);
            this.btnUpload.TabIndex = 90;
            this.btnUpload.Text = "Cargar";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click_2);
            // 
            // lblProjectPicture
            // 
            this.lblProjectPicture.AutoSize = true;
            this.lblProjectPicture.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectPicture.Location = new System.Drawing.Point(728, 410);
            this.lblProjectPicture.Name = "lblProjectPicture";
            this.lblProjectPicture.Size = new System.Drawing.Size(183, 21);
            this.lblProjectPicture.TabIndex = 89;
            this.lblProjectPicture.Text = "Imágen del Proyecto";
            // 
            // pctDetails
            // 
            this.pctDetails.BackColor = System.Drawing.Color.GreenYellow;
            this.pctDetails.Location = new System.Drawing.Point(691, 131);
            this.pctDetails.Name = "pctDetails";
            this.pctDetails.Size = new System.Drawing.Size(278, 262);
            this.pctDetails.TabIndex = 88;
            this.pctDetails.TabStop = false;
            // 
            // txtService
            // 
            this.txtService.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectDetailsBindingSource, "Service", true));
            this.txtService.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtService.Location = new System.Drawing.Point(293, 378);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(342, 32);
            this.txtService.TabIndex = 87;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(21, 387);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(84, 23);
            this.lblService.TabIndex = 86;
            this.lblService.Text = "Servicio";
            // 
            // txtProject
            // 
            this.txtProject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectDetailsBindingSource, "Project", true));
            this.txtProject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProject.Location = new System.Drawing.Point(293, 322);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(342, 32);
            this.txtProject.TabIndex = 85;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(21, 331);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(98, 23);
            this.lblProject.TabIndex = 84;
            this.lblProject.Text = "Proyecto";
            // 
            // txtCost
            // 
            this.txtCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectDetailsBindingSource, "Cost", true));
            this.txtCost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(293, 265);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(342, 32);
            this.txtCost.TabIndex = 83;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(21, 274);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(67, 23);
            this.lblCost.TabIndex = 82;
            this.lblCost.Text = "Costo";
            // 
            // txtServiceType
            // 
            this.txtServiceType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectDetailsBindingSource, "ServiceType", true));
            this.txtServiceType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceType.Location = new System.Drawing.Point(293, 213);
            this.txtServiceType.Name = "txtServiceType";
            this.txtServiceType.Size = new System.Drawing.Size(342, 32);
            this.txtServiceType.TabIndex = 81;
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.Location = new System.Drawing.Point(21, 222);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(161, 23);
            this.lblServiceType.TabIndex = 80;
            this.lblServiceType.Text = "Tipo de Servicio";
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectDetailsBindingSource, "Description", true));
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(293, 162);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(342, 32);
            this.txtDescription.TabIndex = 79;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(21, 171);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(123, 23);
            this.lblDescription.TabIndex = 78;
            this.lblDescription.Text = "Descripción";
            // 
            // lblProjectDetail
            // 
            this.lblProjectDetail.AutoSize = true;
            this.lblProjectDetail.BackColor = System.Drawing.Color.GreenYellow;
            this.lblProjectDetail.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectDetail.Location = new System.Drawing.Point(349, 52);
            this.lblProjectDetail.Name = "lblProjectDetail";
            this.lblProjectDetail.Size = new System.Drawing.Size(296, 34);
            this.lblProjectDetail.TabIndex = 77;
            this.lblProjectDetail.Text = "Detalles de Proyecto";
            this.lblProjectDetail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.GreenYellow;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(442, 716);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 38);
            this.btnCancel.TabIndex = 84;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // grdProjectDetails
            // 
            this.grdProjectDetails.AutoGenerateColumns = false;
            this.grdProjectDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProjectDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.serviceTypeDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.projectDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn});
            this.grdProjectDetails.DataSource = this.projectDetailsBindingSource;
            this.grdProjectDetails.Location = new System.Drawing.Point(1058, 149);
            this.grdProjectDetails.Name = "grdProjectDetails";
            this.grdProjectDetails.RowHeadersWidth = 51;
            this.grdProjectDetails.RowTemplate.Height = 24;
            this.grdProjectDetails.Size = new System.Drawing.Size(576, 545);
            this.grdProjectDetails.TabIndex = 83;
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
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceTypeDataGridViewTextBoxColumn
            // 
            this.serviceTypeDataGridViewTextBoxColumn.DataPropertyName = "ServiceType";
            this.serviceTypeDataGridViewTextBoxColumn.HeaderText = "ServiceType";
            this.serviceTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceTypeDataGridViewTextBoxColumn.Name = "serviceTypeDataGridViewTextBoxColumn";
            this.serviceTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 125;
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
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "Service";
            this.serviceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.GreenYellow;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(727, 656);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(180, 38);
            this.btnNew.TabIndex = 82;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(522, 656);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 38);
            this.btnDelete.TabIndex = 81;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.GreenYellow;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(318, 656);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 38);
            this.btnUpdate.TabIndex = 80;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(119, 656);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 38);
            this.btnSave.TabIndex = 79;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // frmProjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 859);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grdProjectDetails);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Name = "frmProjectDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles del Projecto";
            this.Load += new System.EventHandler(this.frmProjectDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectDetailsBindingSource)).EndInit();
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProjectDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource projectDetailsBindingSource;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblProjectPicture;
        private System.Windows.Forms.PictureBox pctDetails;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtServiceType;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblProjectDetail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView grdProjectDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
    }
}