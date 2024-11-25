namespace PSP_Infrago
{
    partial class frmOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlStyle1 = new System.Windows.Forms.Panel();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.bttNew = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.bttUpdate = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.grpDepartment = new System.Windows.Forms.GroupBox();
            this.rdbDepartment = new System.Windows.Forms.RadioButton();
            this.dttDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.dttOrdeDate = new System.Windows.Forms.DateTimePicker();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.txtProvider = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblProvider = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpData.SuspendLayout();
            this.grpDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.panel1.Location = new System.Drawing.Point(-3, 569);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1687, 39);
            this.panel1.TabIndex = 11;
            // 
            // pnlStyle1
            // 
            this.pnlStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.pnlStyle1.Location = new System.Drawing.Point(-3, -1);
            this.pnlStyle1.Name = "pnlStyle1";
            this.pnlStyle1.Size = new System.Drawing.Size(1687, 39);
            this.pnlStyle1.TabIndex = 10;
            // 
            // grpData
            // 
            this.grpData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.grpData.Controls.Add(this.bttNew);
            this.grpData.Controls.Add(this.bttCancel);
            this.grpData.Controls.Add(this.bttUpdate);
            this.grpData.Controls.Add(this.bttDelete);
            this.grpData.Controls.Add(this.bttSave);
            this.grpData.Controls.Add(this.grpDepartment);
            this.grpData.Controls.Add(this.dttDeliveryDate);
            this.grpData.Controls.Add(this.dttOrdeDate);
            this.grpData.Controls.Add(this.txtTotalCost);
            this.grpData.Controls.Add(this.txtProvider);
            this.grpData.Controls.Add(this.txtDetails);
            this.grpData.Controls.Add(this.lblDepartment);
            this.grpData.Controls.Add(this.lblDeliveryDate);
            this.grpData.Controls.Add(this.lblOrderDate);
            this.grpData.Controls.Add(this.lblTotalCost);
            this.grpData.Controls.Add(this.lblProvider);
            this.grpData.Controls.Add(this.lblDetail);
            this.grpData.Font = new System.Drawing.Font("Typo Grotesk", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpData.Location = new System.Drawing.Point(22, 114);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(914, 466);
            this.grpData.TabIndex = 9;
            this.grpData.TabStop = false;
            this.grpData.Text = "Datos de la orden";
            // 
            // bttNew
            // 
            this.bttNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
            this.bttNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttNew.Font = new System.Drawing.Font("Typo Grotesk", 11.2F);
            this.bttNew.Location = new System.Drawing.Point(106, 416);
            this.bttNew.Name = "bttNew";
            this.bttNew.Size = new System.Drawing.Size(122, 33);
            this.bttNew.TabIndex = 25;
            this.bttNew.Text = "Nuevo";
            this.bttNew.UseVisualStyleBackColor = false;
            // 
            // bttCancel
            // 
            this.bttCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
            this.bttCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancel.Font = new System.Drawing.Font("Typo Grotesk", 11.2F);
            this.bttCancel.Location = new System.Drawing.Point(526, 416);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(122, 33);
            this.bttCancel.TabIndex = 24;
            this.bttCancel.Text = "Cancelar";
            this.bttCancel.UseVisualStyleBackColor = false;
            // 
            // bttUpdate
            // 
            this.bttUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
            this.bttUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttUpdate.Font = new System.Drawing.Font("Typo Grotesk", 11.2F);
            this.bttUpdate.Location = new System.Drawing.Point(388, 416);
            this.bttUpdate.Name = "bttUpdate";
            this.bttUpdate.Size = new System.Drawing.Size(122, 33);
            this.bttUpdate.TabIndex = 23;
            this.bttUpdate.Text = "Actualizar";
            this.bttUpdate.UseVisualStyleBackColor = false;
            // 
            // bttDelete
            // 
            this.bttDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
            this.bttDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDelete.Font = new System.Drawing.Font("Typo Grotesk", 11.2F);
            this.bttDelete.Location = new System.Drawing.Point(668, 416);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(122, 33);
            this.bttDelete.TabIndex = 22;
            this.bttDelete.Text = "Eliminar";
            this.bttDelete.UseVisualStyleBackColor = false;
            // 
            // bttSave
            // 
            this.bttSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
            this.bttSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSave.Font = new System.Drawing.Font("Typo Grotesk", 11.2F);
            this.bttSave.Location = new System.Drawing.Point(248, 416);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(122, 33);
            this.bttSave.TabIndex = 21;
            this.bttSave.Text = "Guardar";
            this.bttSave.UseVisualStyleBackColor = false;
            // 
            // grpDepartment
            // 
            this.grpDepartment.Controls.Add(this.rdbDepartment);
            this.grpDepartment.Location = new System.Drawing.Point(329, 326);
            this.grpDepartment.Name = "grpDepartment";
            this.grpDepartment.Size = new System.Drawing.Size(297, 61);
            this.grpDepartment.TabIndex = 15;
            this.grpDepartment.TabStop = false;
            // 
            // rdbDepartment
            // 
            this.rdbDepartment.AutoSize = true;
            this.rdbDepartment.Font = new System.Drawing.Font("Typo Grotesk", 10F);
            this.rdbDepartment.Location = new System.Drawing.Point(6, 20);
            this.rdbDepartment.Name = "rdbDepartment";
            this.rdbDepartment.Size = new System.Drawing.Size(242, 24);
            this.rdbDepartment.TabIndex = 14;
            this.rdbDepartment.TabStop = true;
            this.rdbDepartment.Text = "Departamento de Finanzas";
            this.rdbDepartment.UseVisualStyleBackColor = true;
            // 
            // dttDeliveryDate
            // 
            this.dttDeliveryDate.CalendarFont = new System.Drawing.Font("Typo Grotesk", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttDeliveryDate.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttDeliveryDate.Location = new System.Drawing.Point(258, 279);
            this.dttDeliveryDate.Name = "dttDeliveryDate";
            this.dttDeliveryDate.Size = new System.Drawing.Size(163, 34);
            this.dttDeliveryDate.TabIndex = 12;
            // 
            // dttOrdeDate
            // 
            this.dttOrdeDate.CalendarFont = new System.Drawing.Font("Typo Grotesk", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttOrdeDate.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttOrdeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttOrdeDate.Location = new System.Drawing.Point(258, 214);
            this.dttOrdeDate.Name = "dttOrdeDate";
            this.dttOrdeDate.Size = new System.Drawing.Size(163, 34);
            this.dttOrdeDate.TabIndex = 11;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalCost.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCost.Location = new System.Drawing.Point(157, 154);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(142, 34);
            this.txtTotalCost.TabIndex = 10;
            // 
            // txtProvider
            // 
            this.txtProvider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProvider.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvider.Location = new System.Drawing.Point(157, 102);
            this.txtProvider.Name = "txtProvider";
            this.txtProvider.Size = new System.Drawing.Size(727, 34);
            this.txtProvider.TabIndex = 9;
            // 
            // txtDetails
            // 
            this.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetails.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(229, 47);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(655, 34);
            this.txtDetails.TabIndex = 8;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(17, 341);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(306, 26);
            this.lblDepartment.TabIndex = 7;
            this.lblDepartment.Text = "Departamento responsable:\r\n";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryDate.Location = new System.Drawing.Point(17, 280);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(212, 26);
            this.lblDeliveryDate.TabIndex = 5;
            this.lblDeliveryDate.Text = "Fecha de entrega:\r\n";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(17, 215);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(191, 26);
            this.lblOrderDate.TabIndex = 4;
            this.lblOrderDate.Text = "Fecha de orden:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(17, 159);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(127, 26);
            this.lblTotalCost.TabIndex = 3;
            this.lblTotalCost.Text = "Costo total:";
            // 
            // lblProvider
            // 
            this.lblProvider.AutoSize = true;
            this.lblProvider.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvider.Location = new System.Drawing.Point(17, 105);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(123, 26);
            this.lblProvider.TabIndex = 2;
            this.lblProvider.Text = "Proveedor:";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.Location = new System.Drawing.Point(17, 50);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(206, 26);
            this.lblDetail.TabIndex = 1;
            this.lblDetail.Text = "Detalles de orden:\r\n";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Typo Grotesk", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(277, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(426, 53);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Registro de Orden";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.providerDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(942, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(728, 523);
            this.dataGridView1.TabIndex = 12;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            this.detailsDataGridViewTextBoxColumn.Width = 125;
            // 
            // providerDataGridViewTextBoxColumn
            // 
            this.providerDataGridViewTextBoxColumn.DataPropertyName = "Provider";
            this.providerDataGridViewTextBoxColumn.HeaderText = "Provider";
            this.providerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
            this.providerDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(PSP_Infrago.Entities.Order);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1682, 606);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlStyle1);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmOrder";
            this.Text = "Order";
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.grpDepartment.ResumeLayout(false);
            this.grpDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlStyle1;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.GroupBox grpDepartment;
        private System.Windows.Forms.RadioButton rdbDepartment;
        private System.Windows.Forms.DateTimePicker dttDeliveryDate;
        private System.Windows.Forms.DateTimePicker dttOrdeDate;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.TextBox txtProvider;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblProvider;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button bttNew;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.Button bttUpdate;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
    }
}