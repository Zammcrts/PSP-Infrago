namespace PSP_Infrago
{
    partial class frmMaintenance
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
            this.maintenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpData = new System.Windows.Forms.GroupBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblMaintenancePicture = new System.Windows.Forms.Label();
            this.pctMaintenance = new System.Windows.Forms.PictureBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtMaintenanceType = new System.Windows.Forms.TextBox();
            this.lblMaintenanceType = new System.Windows.Forms.Label();
            this.txtEquipmentId = new System.Windows.Forms.TextBox();
            this.lblEquipmentId = new System.Windows.Forms.Label();
            this.txtMaintenanceId = new System.Windows.Forms.TextBox();
            this.lblMaintenanceId = new System.Windows.Forms.Label();
            this.lblManitenance = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grdMaintenance = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingSource)).BeginInit();
            this.grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaintenance)).BeginInit();
            this.SuspendLayout();
            // 
            // maintenanceBindingSource
            // 
            this.maintenanceBindingSource.DataSource = typeof(PSP_Infrago.Entities.Maintenance);
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.btnUpload);
            this.grpData.Controls.Add(this.lblMaintenancePicture);
            this.grpData.Controls.Add(this.pctMaintenance);
            this.grpData.Controls.Add(this.txtDetails);
            this.grpData.Controls.Add(this.lblDetails);
            this.grpData.Controls.Add(this.txtCost);
            this.grpData.Controls.Add(this.lblCost);
            this.grpData.Controls.Add(this.txtDescription);
            this.grpData.Controls.Add(this.lblDescription);
            this.grpData.Controls.Add(this.txtMaintenanceType);
            this.grpData.Controls.Add(this.lblMaintenanceType);
            this.grpData.Controls.Add(this.txtEquipmentId);
            this.grpData.Controls.Add(this.lblEquipmentId);
            this.grpData.Controls.Add(this.txtMaintenanceId);
            this.grpData.Controls.Add(this.lblMaintenanceId);
            this.grpData.Controls.Add(this.lblManitenance);
            this.grpData.Location = new System.Drawing.Point(53, 90);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(987, 557);
            this.grpData.TabIndex = 69;
            this.grpData.TabStop = false;
            this.grpData.Text = "Información";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.LightPink;
            this.btnUpload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(742, 469);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(180, 38);
            this.btnUpload.TabIndex = 77;
            this.btnUpload.Text = "Cargar";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click_1);
            // 
            // lblMaintenancePicture
            // 
            this.lblMaintenancePicture.AutoSize = true;
            this.lblMaintenancePicture.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenancePicture.Location = new System.Drawing.Point(723, 445);
            this.lblMaintenancePicture.Name = "lblMaintenancePicture";
            this.lblMaintenancePicture.Size = new System.Drawing.Size(208, 21);
            this.lblMaintenancePicture.TabIndex = 76;
            this.lblMaintenancePicture.Text = "Pieza de Mantenimiento";
            // 
            // pctMaintenance
            // 
            this.pctMaintenance.BackColor = System.Drawing.Color.LightPink;
            this.pctMaintenance.Location = new System.Drawing.Point(689, 165);
            this.pctMaintenance.Name = "pctMaintenance";
            this.pctMaintenance.Size = new System.Drawing.Size(278, 262);
            this.pctMaintenance.TabIndex = 75;
            this.pctMaintenance.TabStop = false;
            // 
            // txtDetails
            // 
            this.txtDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceBindingSource, "Details", true));
            this.txtDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(291, 434);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(342, 32);
            this.txtDetails.TabIndex = 74;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(19, 443);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(90, 23);
            this.lblDetails.TabIndex = 73;
            this.lblDetails.Text = "Detalles";
            // 
            // txtCost
            // 
            this.txtCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceBindingSource, "Cost", true));
            this.txtCost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(291, 381);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(342, 32);
            this.txtCost.TabIndex = 72;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(19, 390);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(67, 23);
            this.lblCost.TabIndex = 71;
            this.lblCost.Text = "Costo";
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceBindingSource, "Description", true));
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(291, 325);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(342, 32);
            this.txtDescription.TabIndex = 70;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(19, 334);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(123, 23);
            this.lblDescription.TabIndex = 69;
            this.lblDescription.Text = "Descripción";
            // 
            // txtMaintenanceType
            // 
            this.txtMaintenanceType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceBindingSource, "MaintenanceType", true));
            this.txtMaintenanceType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaintenanceType.Location = new System.Drawing.Point(291, 268);
            this.txtMaintenanceType.Name = "txtMaintenanceType";
            this.txtMaintenanceType.Size = new System.Drawing.Size(342, 32);
            this.txtMaintenanceType.TabIndex = 68;
            // 
            // lblMaintenanceType
            // 
            this.lblMaintenanceType.AutoSize = true;
            this.lblMaintenanceType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceType.Location = new System.Drawing.Point(19, 277);
            this.lblMaintenanceType.Name = "lblMaintenanceType";
            this.lblMaintenanceType.Size = new System.Drawing.Size(232, 23);
            this.lblMaintenanceType.TabIndex = 67;
            this.lblMaintenanceType.Text = "Tipo de Mantenimiento";
            // 
            // txtEquipmentId
            // 
            this.txtEquipmentId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceBindingSource, "EquipmentId", true));
            this.txtEquipmentId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentId.Location = new System.Drawing.Point(291, 216);
            this.txtEquipmentId.Name = "txtEquipmentId";
            this.txtEquipmentId.Size = new System.Drawing.Size(342, 32);
            this.txtEquipmentId.TabIndex = 66;
            // 
            // lblEquipmentId
            // 
            this.lblEquipmentId.AutoSize = true;
            this.lblEquipmentId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentId.Location = new System.Drawing.Point(19, 225);
            this.lblEquipmentId.Name = "lblEquipmentId";
            this.lblEquipmentId.Size = new System.Drawing.Size(136, 23);
            this.lblEquipmentId.TabIndex = 65;
            this.lblEquipmentId.Text = "ID de Equipo";
            // 
            // txtMaintenanceId
            // 
            this.txtMaintenanceId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceBindingSource, "Id", true));
            this.txtMaintenanceId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaintenanceId.Location = new System.Drawing.Point(291, 165);
            this.txtMaintenanceId.Name = "txtMaintenanceId";
            this.txtMaintenanceId.Size = new System.Drawing.Size(342, 32);
            this.txtMaintenanceId.TabIndex = 64;
            // 
            // lblMaintenanceId
            // 
            this.lblMaintenanceId.AutoSize = true;
            this.lblMaintenanceId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceId.Location = new System.Drawing.Point(19, 174);
            this.lblMaintenanceId.Name = "lblMaintenanceId";
            this.lblMaintenanceId.Size = new System.Drawing.Size(214, 23);
            this.lblMaintenanceId.TabIndex = 63;
            this.lblMaintenanceId.Text = "ID de Mantenimiento";
            // 
            // lblManitenance
            // 
            this.lblManitenance.AutoSize = true;
            this.lblManitenance.BackColor = System.Drawing.Color.LightPink;
            this.lblManitenance.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManitenance.Location = new System.Drawing.Point(414, 49);
            this.lblManitenance.Name = "lblManitenance";
            this.lblManitenance.Size = new System.Drawing.Size(219, 34);
            this.lblManitenance.TabIndex = 62;
            this.lblManitenance.Text = "Mantenimiento";
            this.lblManitenance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightPink;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(403, 731);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 38);
            this.btnCancel.TabIndex = 68;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // grdMaintenance
            // 
            this.grdMaintenance.AutoGenerateColumns = false;
            this.grdMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMaintenance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.equipmentIdDataGridViewTextBoxColumn,
            this.maintenanceDateDataGridViewTextBoxColumn,
            this.maintenanceTypeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn});
            this.grdMaintenance.DataSource = this.maintenanceBindingSource;
            this.grdMaintenance.Location = new System.Drawing.Point(1067, 146);
            this.grdMaintenance.Name = "grdMaintenance";
            this.grdMaintenance.RowHeadersWidth = 51;
            this.grdMaintenance.RowTemplate.Height = 24;
            this.grdMaintenance.Size = new System.Drawing.Size(562, 534);
            this.grdMaintenance.TabIndex = 67;
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
            // equipmentIdDataGridViewTextBoxColumn
            // 
            this.equipmentIdDataGridViewTextBoxColumn.DataPropertyName = "EquipmentId";
            this.equipmentIdDataGridViewTextBoxColumn.HeaderText = "EquipmentId";
            this.equipmentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.equipmentIdDataGridViewTextBoxColumn.Name = "equipmentIdDataGridViewTextBoxColumn";
            this.equipmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipmentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // maintenanceDateDataGridViewTextBoxColumn
            // 
            this.maintenanceDateDataGridViewTextBoxColumn.DataPropertyName = "MaintenanceDate";
            this.maintenanceDateDataGridViewTextBoxColumn.HeaderText = "MaintenanceDate";
            this.maintenanceDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maintenanceDateDataGridViewTextBoxColumn.Name = "maintenanceDateDataGridViewTextBoxColumn";
            this.maintenanceDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.maintenanceDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // maintenanceTypeDataGridViewTextBoxColumn
            // 
            this.maintenanceTypeDataGridViewTextBoxColumn.DataPropertyName = "MaintenanceType";
            this.maintenanceTypeDataGridViewTextBoxColumn.HeaderText = "MaintenanceType";
            this.maintenanceTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maintenanceTypeDataGridViewTextBoxColumn.Name = "maintenanceTypeDataGridViewTextBoxColumn";
            this.maintenanceTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.maintenanceTypeDataGridViewTextBoxColumn.Width = 125;
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
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            this.detailsDataGridViewTextBoxColumn.ReadOnly = true;
            this.detailsDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.LightPink;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(718, 668);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(180, 38);
            this.btnNew.TabIndex = 66;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightPink;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(513, 668);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 38);
            this.btnDelete.TabIndex = 65;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightPink;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(309, 668);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 38);
            this.btnUpdate.TabIndex = 64;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightPink;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(110, 668);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 38);
            this.btnSave.TabIndex = 63;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // frmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 859);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grdMaintenance);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Name = "frmMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.frmMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingSource)).EndInit();
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaintenance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource maintenanceBindingSource;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblMaintenancePicture;
        private System.Windows.Forms.PictureBox pctMaintenance;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtMaintenanceType;
        private System.Windows.Forms.Label lblMaintenanceType;
        private System.Windows.Forms.TextBox txtEquipmentId;
        private System.Windows.Forms.Label lblEquipmentId;
        private System.Windows.Forms.TextBox txtMaintenanceId;
        private System.Windows.Forms.Label lblMaintenanceId;
        private System.Windows.Forms.Label lblManitenance;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView grdMaintenance;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
    }
}