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
            this.lblMaintenancePicture = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.grdMaintenance = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.maintenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pctMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaintenancePicture
            // 
            this.lblMaintenancePicture.AutoSize = true;
            this.lblMaintenancePicture.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenancePicture.Location = new System.Drawing.Point(740, 558);
            this.lblMaintenancePicture.Name = "lblMaintenancePicture";
            this.lblMaintenancePicture.Size = new System.Drawing.Size(208, 21);
            this.lblMaintenancePicture.TabIndex = 58;
            this.lblMaintenancePicture.Text = "Pieza de Mantenimiento";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.LightPink;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(706, 684);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(180, 38);
            this.btnNew.TabIndex = 57;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightPink;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(501, 684);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 38);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightPink;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(297, 684);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 38);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightPink;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(98, 684);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 38);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pctMaintenance
            // 
            this.pctMaintenance.BackColor = System.Drawing.Color.LightPink;
            this.pctMaintenance.Location = new System.Drawing.Point(706, 278);
            this.pctMaintenance.Name = "pctMaintenance";
            this.pctMaintenance.Size = new System.Drawing.Size(278, 262);
            this.pctMaintenance.TabIndex = 53;
            this.pctMaintenance.TabStop = false;
            // 
            // txtDetails
            // 
            this.txtDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceBindingSource, "Details", true));
            this.txtDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(308, 547);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(342, 32);
            this.txtDetails.TabIndex = 52;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(36, 556);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(90, 23);
            this.lblDetails.TabIndex = 51;
            this.lblDetails.Text = "Detalles";
            // 
            // txtCost
            // 
            this.txtCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceBindingSource, "Cost", true));
            this.txtCost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(308, 494);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(342, 32);
            this.txtCost.TabIndex = 50;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(36, 503);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(67, 23);
            this.lblCost.TabIndex = 49;
            this.lblCost.Text = "Costo";
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceBindingSource, "Description", true));
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(308, 438);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(342, 32);
            this.txtDescription.TabIndex = 48;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(36, 447);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(123, 23);
            this.lblDescription.TabIndex = 47;
            this.lblDescription.Text = "Descripción";
            // 
            // txtMaintenanceType
            // 
            this.txtMaintenanceType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceBindingSource, "MaintenanceType", true));
            this.txtMaintenanceType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaintenanceType.Location = new System.Drawing.Point(308, 381);
            this.txtMaintenanceType.Name = "txtMaintenanceType";
            this.txtMaintenanceType.Size = new System.Drawing.Size(342, 32);
            this.txtMaintenanceType.TabIndex = 46;
            // 
            // lblMaintenanceType
            // 
            this.lblMaintenanceType.AutoSize = true;
            this.lblMaintenanceType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceType.Location = new System.Drawing.Point(36, 390);
            this.lblMaintenanceType.Name = "lblMaintenanceType";
            this.lblMaintenanceType.Size = new System.Drawing.Size(232, 23);
            this.lblMaintenanceType.TabIndex = 45;
            this.lblMaintenanceType.Text = "Tipo de Mantenimiento";
            // 
            // txtEquipmentId
            // 
            this.txtEquipmentId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceBindingSource, "EquipmentId", true));
            this.txtEquipmentId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentId.Location = new System.Drawing.Point(308, 329);
            this.txtEquipmentId.Name = "txtEquipmentId";
            this.txtEquipmentId.Size = new System.Drawing.Size(342, 32);
            this.txtEquipmentId.TabIndex = 44;
            // 
            // lblEquipmentId
            // 
            this.lblEquipmentId.AutoSize = true;
            this.lblEquipmentId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentId.Location = new System.Drawing.Point(36, 338);
            this.lblEquipmentId.Name = "lblEquipmentId";
            this.lblEquipmentId.Size = new System.Drawing.Size(136, 23);
            this.lblEquipmentId.TabIndex = 43;
            this.lblEquipmentId.Text = "ID de Equipo";
            // 
            // txtMaintenanceId
            // 
            this.txtMaintenanceId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceBindingSource, "Id", true));
            this.txtMaintenanceId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaintenanceId.Location = new System.Drawing.Point(308, 278);
            this.txtMaintenanceId.Name = "txtMaintenanceId";
            this.txtMaintenanceId.Size = new System.Drawing.Size(342, 32);
            this.txtMaintenanceId.TabIndex = 42;
            // 
            // lblMaintenanceId
            // 
            this.lblMaintenanceId.AutoSize = true;
            this.lblMaintenanceId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceId.Location = new System.Drawing.Point(36, 287);
            this.lblMaintenanceId.Name = "lblMaintenanceId";
            this.lblMaintenanceId.Size = new System.Drawing.Size(214, 23);
            this.lblMaintenanceId.TabIndex = 41;
            this.lblMaintenanceId.Text = "ID de Mantenimiento";
            // 
            // lblManitenance
            // 
            this.lblManitenance.AutoSize = true;
            this.lblManitenance.BackColor = System.Drawing.Color.LightPink;
            this.lblManitenance.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManitenance.Location = new System.Drawing.Point(431, 162);
            this.lblManitenance.Name = "lblManitenance";
            this.lblManitenance.Size = new System.Drawing.Size(219, 34);
            this.lblManitenance.TabIndex = 40;
            this.lblManitenance.Text = "Mantenimiento";
            this.lblManitenance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.grdMaintenance.Location = new System.Drawing.Point(1055, 162);
            this.grdMaintenance.Name = "grdMaintenance";
            this.grdMaintenance.RowHeadersWidth = 51;
            this.grdMaintenance.RowTemplate.Height = 24;
            this.grdMaintenance.Size = new System.Drawing.Size(562, 534);
            this.grdMaintenance.TabIndex = 59;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightPink;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(391, 747);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 38);
            this.btnCancel.TabIndex = 60;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.LightPink;
            this.btnUpload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(759, 582);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(180, 38);
            this.btnUpload.TabIndex = 61;
            this.btnUpload.Text = "Cargar";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // maintenanceBindingSource
            // 
            this.maintenanceBindingSource.DataSource = typeof(PSP_Infrago.Entities.Maintenance);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // equipmentIdDataGridViewTextBoxColumn
            // 
            this.equipmentIdDataGridViewTextBoxColumn.DataPropertyName = "EquipmentId";
            this.equipmentIdDataGridViewTextBoxColumn.HeaderText = "EquipmentId";
            this.equipmentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.equipmentIdDataGridViewTextBoxColumn.Name = "equipmentIdDataGridViewTextBoxColumn";
            this.equipmentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // maintenanceDateDataGridViewTextBoxColumn
            // 
            this.maintenanceDateDataGridViewTextBoxColumn.DataPropertyName = "MaintenanceDate";
            this.maintenanceDateDataGridViewTextBoxColumn.HeaderText = "MaintenanceDate";
            this.maintenanceDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maintenanceDateDataGridViewTextBoxColumn.Name = "maintenanceDateDataGridViewTextBoxColumn";
            this.maintenanceDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // maintenanceTypeDataGridViewTextBoxColumn
            // 
            this.maintenanceTypeDataGridViewTextBoxColumn.DataPropertyName = "MaintenanceType";
            this.maintenanceTypeDataGridViewTextBoxColumn.HeaderText = "MaintenanceType";
            this.maintenanceTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maintenanceTypeDataGridViewTextBoxColumn.Name = "maintenanceTypeDataGridViewTextBoxColumn";
            this.maintenanceTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            this.detailsDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 859);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grdMaintenance);
            this.Controls.Add(this.lblMaintenancePicture);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pctMaintenance);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtMaintenanceType);
            this.Controls.Add(this.lblMaintenanceType);
            this.Controls.Add(this.txtEquipmentId);
            this.Controls.Add(this.lblEquipmentId);
            this.Controls.Add(this.txtMaintenanceId);
            this.Controls.Add(this.lblMaintenanceId);
            this.Controls.Add(this.lblManitenance);
            this.Name = "frmMaintenance";
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.frmMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaintenancePicture;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
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
        private System.Windows.Forms.DataGridView grdMaintenance;
        private System.Windows.Forms.BindingSource maintenanceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpload;
    }
}