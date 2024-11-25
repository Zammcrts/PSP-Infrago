namespace PSP_Infrago
{
    partial class OrderDetail
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
            this.grpData = new System.Windows.Forms.GroupBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.txtPricePerUnit = new System.Windows.Forms.TextBox();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.txtQuantityInStock = new System.Windows.Forms.TextBox();
            this.lblQuantityInStock = new System.Windows.Forms.Label();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.pnlStyle1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bttNew = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.bttUpdate = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.panel1.Location = new System.Drawing.Point(-3, 453);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1618, 39);
            this.panel1.TabIndex = 16;
            // 
            // grpData
            // 
            this.grpData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.grpData.Controls.Add(this.bttNew);
            this.grpData.Controls.Add(this.bttCancel);
            this.grpData.Controls.Add(this.bttUpdate);
            this.grpData.Controls.Add(this.bttDelete);
            this.grpData.Controls.Add(this.bttSave);
            this.grpData.Controls.Add(this.txtMaterial);
            this.grpData.Controls.Add(this.lblMaterial);
            this.grpData.Controls.Add(this.txtPricePerUnit);
            this.grpData.Controls.Add(this.lblPricePerUnit);
            this.grpData.Controls.Add(this.txtQuantityInStock);
            this.grpData.Controls.Add(this.lblQuantityInStock);
            this.grpData.Controls.Add(this.txtOrder);
            this.grpData.Controls.Add(this.lblOrder);
            this.grpData.Controls.Add(this.lblProject);
            this.grpData.Font = new System.Drawing.Font("Typo Grotesk", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpData.Location = new System.Drawing.Point(18, 113);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(914, 338);
            this.grpData.TabIndex = 17;
            this.grpData.TabStop = false;
            this.grpData.Text = "Datos de la asignación del material";
            // 
            // txtMaterial
            // 
            this.txtMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaterial.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterial.Location = new System.Drawing.Point(127, 117);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(781, 34);
            this.txtMaterial.TabIndex = 31;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(23, 120);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(98, 26);
            this.lblMaterial.TabIndex = 30;
            this.lblMaterial.Text = "Material:";
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPricePerUnit.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePerUnit.Location = new System.Drawing.Point(232, 224);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.Size = new System.Drawing.Size(138, 34);
            this.txtPricePerUnit.TabIndex = 29;
            // 
            // lblPricePerUnit
            // 
            this.lblPricePerUnit.AutoSize = true;
            this.lblPricePerUnit.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerUnit.Location = new System.Drawing.Point(23, 226);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(203, 26);
            this.lblPricePerUnit.TabIndex = 28;
            this.lblPricePerUnit.Text = "Precio por unidad:\r\n";
            // 
            // txtQuantityInStock
            // 
            this.txtQuantityInStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantityInStock.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityInStock.Location = new System.Drawing.Point(368, 171);
            this.txtQuantityInStock.Name = "txtQuantityInStock";
            this.txtQuantityInStock.Size = new System.Drawing.Size(540, 34);
            this.txtQuantityInStock.TabIndex = 27;
            // 
            // lblQuantityInStock
            // 
            this.lblQuantityInStock.AutoSize = true;
            this.lblQuantityInStock.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityInStock.Location = new System.Drawing.Point(23, 174);
            this.lblQuantityInStock.Name = "lblQuantityInStock";
            this.lblQuantityInStock.Size = new System.Drawing.Size(339, 26);
            this.lblQuantityInStock.TabIndex = 26;
            this.lblQuantityInStock.Text = "Cantidad de material en stock:";
            // 
            // txtOrder
            // 
            this.txtOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrder.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrder.Location = new System.Drawing.Point(127, 62);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(781, 34);
            this.txtOrder.TabIndex = 10;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(23, 64);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(85, 26);
            this.lblOrder.TabIndex = 3;
            this.lblOrder.Text = "Orden:";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(17, 64);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(0, 26);
            this.lblProject.TabIndex = 2;
            // 
            // pnlStyle1
            // 
            this.pnlStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.pnlStyle1.Location = new System.Drawing.Point(-3, 0);
            this.pnlStyle1.Name = "pnlStyle1";
            this.pnlStyle1.Size = new System.Drawing.Size(1618, 39);
            this.pnlStyle1.TabIndex = 15;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Typo Grotesk", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(166, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(615, 53);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Registro detalles de Orden";
            // 
            // bttNew
            // 
            this.bttNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
            this.bttNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttNew.Font = new System.Drawing.Font("Typo Grotesk", 11.2F);
            this.bttNew.Location = new System.Drawing.Point(112, 299);
            this.bttNew.Name = "bttNew";
            this.bttNew.Size = new System.Drawing.Size(122, 33);
            this.bttNew.TabIndex = 36;
            this.bttNew.Text = "Nuevo";
            this.bttNew.UseVisualStyleBackColor = false;
            // 
            // bttCancel
            // 
            this.bttCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
            this.bttCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancel.Font = new System.Drawing.Font("Typo Grotesk", 11.2F);
            this.bttCancel.Location = new System.Drawing.Point(532, 299);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(122, 33);
            this.bttCancel.TabIndex = 35;
            this.bttCancel.Text = "Cancelar";
            this.bttCancel.UseVisualStyleBackColor = false;
            // 
            // bttUpdate
            // 
            this.bttUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
            this.bttUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttUpdate.Font = new System.Drawing.Font("Typo Grotesk", 11.2F);
            this.bttUpdate.Location = new System.Drawing.Point(394, 299);
            this.bttUpdate.Name = "bttUpdate";
            this.bttUpdate.Size = new System.Drawing.Size(122, 33);
            this.bttUpdate.TabIndex = 34;
            this.bttUpdate.Text = "Actualizar";
            this.bttUpdate.UseVisualStyleBackColor = false;
            // 
            // bttDelete
            // 
            this.bttDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
            this.bttDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDelete.Font = new System.Drawing.Font("Typo Grotesk", 11.2F);
            this.bttDelete.Location = new System.Drawing.Point(674, 299);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(122, 33);
            this.bttDelete.TabIndex = 33;
            this.bttDelete.Text = "Eliminar";
            this.bttDelete.UseVisualStyleBackColor = false;
            // 
            // bttSave
            // 
            this.bttSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
            this.bttSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSave.Font = new System.Drawing.Font("Typo Grotesk", 11.2F);
            this.bttSave.Location = new System.Drawing.Point(254, 299);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(122, 33);
            this.bttSave.TabIndex = 32;
            this.bttSave.Text = "Guardar";
            this.bttSave.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.orderDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.pricePerUnitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderDetailBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(938, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(677, 400);
            this.dataGridView1.TabIndex = 18;
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(PSP_Infrago.Entities.OrderDetail);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDataGridViewTextBoxColumn
            // 
            this.orderDataGridViewTextBoxColumn.DataPropertyName = "Order";
            this.orderDataGridViewTextBoxColumn.HeaderText = "Order";
            this.orderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDataGridViewTextBoxColumn.Name = "orderDataGridViewTextBoxColumn";
            this.orderDataGridViewTextBoxColumn.Width = 125;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "Material";
            this.materialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            this.materialDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // pricePerUnitDataGridViewTextBoxColumn
            // 
            this.pricePerUnitDataGridViewTextBoxColumn.DataPropertyName = "PricePerUnit";
            this.pricePerUnitDataGridViewTextBoxColumn.HeaderText = "PricePerUnit";
            this.pricePerUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pricePerUnitDataGridViewTextBoxColumn.Name = "pricePerUnitDataGridViewTextBoxColumn";
            this.pricePerUnitDataGridViewTextBoxColumn.Width = 125;
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1625, 493);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.pnlStyle1);
            this.Controls.Add(this.lblTitle);
            this.Name = "OrderDetail";
            this.Text = "OrderDetail";
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.TextBox txtPricePerUnit;
        private System.Windows.Forms.Label lblPricePerUnit;
        private System.Windows.Forms.TextBox txtQuantityInStock;
        private System.Windows.Forms.Label lblQuantityInStock;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Panel pnlStyle1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button bttNew;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.Button bttUpdate;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
    }
}