using System;

namespace PSP_Infrago
{
    partial class frmMaintenanceDetails
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
            this.grpData = new System.Windows.Forms.GroupBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblMaintenancePicture = new System.Windows.Forms.Label();
            this.pctMaintenance = new System.Windows.Forms.PictureBox();
            this.dtpMaintenanceDetails = new System.Windows.Forms.DateTimePicker();
            this.txtMaintenance = new System.Windows.Forms.TextBox();
            this.lblMaintenance = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtMachine = new System.Windows.Forms.TextBox();
            this.lblMachinery = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblMaintenanceDescrption = new System.Windows.Forms.Label();
            this.lblMaintenanceDate = new System.Windows.Forms.Label();
            this.lblManitenanceDetails = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grdMaintenanceDetails = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.maintenanceDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaintenanceDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.btnUpload);
            this.grpData.Controls.Add(this.lblMaintenancePicture);
            this.grpData.Controls.Add(this.pctMaintenance);
            this.grpData.Controls.Add(this.dtpMaintenanceDetails);
            this.grpData.Controls.Add(this.txtMaintenance);
            this.grpData.Controls.Add(this.lblMaintenance);
            this.grpData.Controls.Add(this.txtCost);
            this.grpData.Controls.Add(this.lblCost);
            this.grpData.Controls.Add(this.txtMachine);
            this.grpData.Controls.Add(this.lblMachinery);
            this.grpData.Controls.Add(this.txtDescription);
            this.grpData.Controls.Add(this.lblMaintenanceDescrption);
            this.grpData.Controls.Add(this.lblMaintenanceDate);
            this.grpData.Controls.Add(this.lblManitenanceDetails);
            this.grpData.Location = new System.Drawing.Point(63, 111);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(974, 531);
            this.grpData.TabIndex = 66;
            this.grpData.TabStop = false;
            this.grpData.Text = "información";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Violet;
            this.btnUpload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(746, 445);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(180, 38);
            this.btnUpload.TabIndex = 72;
            this.btnUpload.Text = "Cargar";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click_1);
            // 
            // lblMaintenancePicture
            // 
            this.lblMaintenancePicture.AutoSize = true;
            this.lblMaintenancePicture.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenancePicture.Location = new System.Drawing.Point(727, 412);
            this.lblMaintenancePicture.Name = "lblMaintenancePicture";
            this.lblMaintenancePicture.Size = new System.Drawing.Size(208, 21);
            this.lblMaintenancePicture.TabIndex = 71;
            this.lblMaintenancePicture.Text = "Pieza de Mantenimiento";
            // 
            // pctMaintenance
            // 
            this.pctMaintenance.BackColor = System.Drawing.Color.Violet;
            this.pctMaintenance.Location = new System.Drawing.Point(696, 134);
            this.pctMaintenance.Name = "pctMaintenance";
            this.pctMaintenance.Size = new System.Drawing.Size(278, 262);
            this.pctMaintenance.TabIndex = 70;
            this.pctMaintenance.TabStop = false;
            // 
            // dtpMaintenanceDetails
            // 
            this.dtpMaintenanceDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceDetailsBindingSource, "MaintenanceDate", true));
            this.dtpMaintenanceDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMaintenanceDetails.Location = new System.Drawing.Point(272, 179);
            this.dtpMaintenanceDetails.Name = "dtpMaintenanceDetails";
            this.dtpMaintenanceDetails.Size = new System.Drawing.Size(373, 32);
            this.dtpMaintenanceDetails.TabIndex = 69;
            // 
            // txtMaintenance
            // 
            this.txtMaintenance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceDetailsBindingSource, "Maintenance", true));
            this.txtMaintenance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaintenance.Location = new System.Drawing.Point(272, 390);
            this.txtMaintenance.Name = "txtMaintenance";
            this.txtMaintenance.Size = new System.Drawing.Size(373, 32);
            this.txtMaintenance.TabIndex = 68;
            // 
            // lblMaintenance
            // 
            this.lblMaintenance.AutoSize = true;
            this.lblMaintenance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenance.Location = new System.Drawing.Point(0, 399);
            this.lblMaintenance.Name = "lblMaintenance";
            this.lblMaintenance.Size = new System.Drawing.Size(155, 23);
            this.lblMaintenance.TabIndex = 67;
            this.lblMaintenance.Text = "Mantenimiento";
            // 
            // txtCost
            // 
            this.txtCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceDetailsBindingSource, "Cost", true));
            this.txtCost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(272, 337);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(373, 32);
            this.txtCost.TabIndex = 66;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(0, 346);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(67, 23);
            this.lblCost.TabIndex = 65;
            this.lblCost.Text = "Costo";
            // 
            // txtMachine
            // 
            this.txtMachine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceDetailsBindingSource, "Machinery", true));
            this.txtMachine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachine.Location = new System.Drawing.Point(272, 281);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.Size = new System.Drawing.Size(373, 32);
            this.txtMachine.TabIndex = 64;
            // 
            // lblMachinery
            // 
            this.lblMachinery.AutoSize = true;
            this.lblMachinery.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachinery.Location = new System.Drawing.Point(0, 290);
            this.lblMachinery.Name = "lblMachinery";
            this.lblMachinery.Size = new System.Drawing.Size(96, 23);
            this.lblMachinery.TabIndex = 63;
            this.lblMachinery.Text = "Máquina";
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceDetailsBindingSource, "Descrption", true));
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(272, 221);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(373, 32);
            this.txtDescription.TabIndex = 62;
            // 
            // lblMaintenanceDescrption
            // 
            this.lblMaintenanceDescrption.AutoSize = true;
            this.lblMaintenanceDescrption.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceDescrption.Location = new System.Drawing.Point(0, 230);
            this.lblMaintenanceDescrption.Name = "lblMaintenanceDescrption";
            this.lblMaintenanceDescrption.Size = new System.Drawing.Size(123, 23);
            this.lblMaintenanceDescrption.TabIndex = 61;
            this.lblMaintenanceDescrption.Text = "Descripción";
            // 
            // lblMaintenanceDate
            // 
            this.lblMaintenanceDate.AutoSize = true;
            this.lblMaintenanceDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceDate.Location = new System.Drawing.Point(0, 179);
            this.lblMaintenanceDate.Name = "lblMaintenanceDate";
            this.lblMaintenanceDate.Size = new System.Drawing.Size(256, 23);
            this.lblMaintenanceDate.TabIndex = 60;
            this.lblMaintenanceDate.Text = "Fecha de Mantenimiento";
            // 
            // lblManitenanceDetails
            // 
            this.lblManitenanceDetails.AutoSize = true;
            this.lblManitenanceDetails.BackColor = System.Drawing.Color.Violet;
            this.lblManitenanceDetails.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManitenanceDetails.Location = new System.Drawing.Point(277, 47);
            this.lblManitenanceDetails.Name = "lblManitenanceDetails";
            this.lblManitenanceDetails.Size = new System.Drawing.Size(379, 34);
            this.lblManitenanceDetails.TabIndex = 59;
            this.lblManitenanceDetails.Text = "Detalles de Mantenimiento";
            this.lblManitenanceDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Violet;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(460, 710);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 38);
            this.btnCancel.TabIndex = 65;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // grdMaintenanceDetails
            // 
            this.grdMaintenanceDetails.AutoGenerateColumns = false;
            this.grdMaintenanceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMaintenanceDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.maintenanceDateDataGridViewTextBoxColumn,
            this.descrptionDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.maintenanceDataGridViewTextBoxColumn,
            this.machineryDataGridViewTextBoxColumn});
            this.grdMaintenanceDetails.DataSource = this.maintenanceDetailsBindingSource;
            this.grdMaintenanceDetails.Location = new System.Drawing.Point(1075, 161);
            this.grdMaintenanceDetails.Name = "grdMaintenanceDetails";
            this.grdMaintenanceDetails.RowHeadersWidth = 51;
            this.grdMaintenanceDetails.RowTemplate.Height = 24;
            this.grdMaintenanceDetails.Size = new System.Drawing.Size(544, 525);
            this.grdMaintenanceDetails.TabIndex = 64;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Violet;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(717, 648);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(180, 38);
            this.btnNew.TabIndex = 63;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Violet;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(512, 648);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 38);
            this.btnDelete.TabIndex = 62;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Violet;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(308, 648);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 38);
            this.btnUpdate.TabIndex = 61;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Violet;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(109, 648);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 38);
            this.btnSave.TabIndex = 60;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // maintenanceDetailsBindingSource
            // 
            this.maintenanceDetailsBindingSource.DataSource = typeof(PSP_Infrago.Entities.MaintenanceDetails);
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
            // maintenanceDateDataGridViewTextBoxColumn
            // 
            this.maintenanceDateDataGridViewTextBoxColumn.DataPropertyName = "MaintenanceDate";
            this.maintenanceDateDataGridViewTextBoxColumn.HeaderText = "MaintenanceDate";
            this.maintenanceDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maintenanceDateDataGridViewTextBoxColumn.Name = "maintenanceDateDataGridViewTextBoxColumn";
            this.maintenanceDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.maintenanceDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // descrptionDataGridViewTextBoxColumn
            // 
            this.descrptionDataGridViewTextBoxColumn.DataPropertyName = "Descrption";
            this.descrptionDataGridViewTextBoxColumn.HeaderText = "Descrption";
            this.descrptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descrptionDataGridViewTextBoxColumn.Name = "descrptionDataGridViewTextBoxColumn";
            this.descrptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descrptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // maintenanceDataGridViewTextBoxColumn
            // 
            this.maintenanceDataGridViewTextBoxColumn.DataPropertyName = "Maintenance";
            this.maintenanceDataGridViewTextBoxColumn.HeaderText = "Maintenance";
            this.maintenanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maintenanceDataGridViewTextBoxColumn.Name = "maintenanceDataGridViewTextBoxColumn";
            this.maintenanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.maintenanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // machineryDataGridViewTextBoxColumn
            // 
            this.machineryDataGridViewTextBoxColumn.DataPropertyName = "Machinery";
            this.machineryDataGridViewTextBoxColumn.HeaderText = "Machinery";
            this.machineryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.machineryDataGridViewTextBoxColumn.Name = "machineryDataGridViewTextBoxColumn";
            this.machineryDataGridViewTextBoxColumn.ReadOnly = true;
            this.machineryDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmMaintenanceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 859);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grdMaintenanceDetails);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Name = "frmMaintenanceDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles de Mantenimiento";
            this.Load += new System.EventHandler(this.frmMaintenanceDetails_Load);
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaintenanceDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource maintenanceDetailsBindingSource;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblMaintenancePicture;
        private System.Windows.Forms.PictureBox pctMaintenance;
        private System.Windows.Forms.DateTimePicker dtpMaintenanceDetails;
        private System.Windows.Forms.TextBox txtMaintenance;
        private System.Windows.Forms.Label lblMaintenance;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtMachine;
        private System.Windows.Forms.Label lblMachinery;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblMaintenanceDescrption;
        private System.Windows.Forms.Label lblMaintenanceDate;
        private System.Windows.Forms.Label lblManitenanceDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView grdMaintenanceDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
    }
}