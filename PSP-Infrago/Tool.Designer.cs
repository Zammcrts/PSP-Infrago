namespace PSP_Infrago
{
    partial class frmTool
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
            this.lblProjectPicture = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pctTool = new System.Windows.Forms.PictureBox();
            this.txtAssignation = new System.Windows.Forms.TextBox();
            this.lblAssignment = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtToolId = new System.Windows.Forms.TextBox();
            this.lblToolID = new System.Windows.Forms.Label();
            this.lblTool = new System.Windows.Forms.Label();
            this.grdTools = new System.Windows.Forms.DataGridView();
            this.toolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolAssignmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProjectPicture
            // 
            this.lblProjectPicture.AutoSize = true;
            this.lblProjectPicture.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectPicture.Location = new System.Drawing.Point(726, 494);
            this.lblProjectPicture.Name = "lblProjectPicture";
            this.lblProjectPicture.Size = new System.Drawing.Size(226, 21);
            this.lblProjectPicture.TabIndex = 73;
            this.lblProjectPicture.Text = "Imágen de la Herramienta";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.PeachPuff;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(627, 653);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(180, 38);
            this.btnNew.TabIndex = 72;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(422, 653);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 38);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PeachPuff;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(218, 653);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 38);
            this.btnUpdate.TabIndex = 70;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(19, 653);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 38);
            this.btnSave.TabIndex = 69;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pctTool
            // 
            this.pctTool.BackColor = System.Drawing.Color.PeachPuff;
            this.pctTool.Location = new System.Drawing.Point(703, 217);
            this.pctTool.Name = "pctTool";
            this.pctTool.Size = new System.Drawing.Size(278, 262);
            this.pctTool.TabIndex = 68;
            this.pctTool.TabStop = false;
            // 
            // txtAssignation
            // 
            this.txtAssignation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolBindingSource, "ToolAssignment", true));
            this.txtAssignation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignation.Location = new System.Drawing.Point(311, 466);
            this.txtAssignation.Name = "txtAssignation";
            this.txtAssignation.Size = new System.Drawing.Size(342, 32);
            this.txtAssignation.TabIndex = 67;
            // 
            // lblAssignment
            // 
            this.lblAssignment.AutoSize = true;
            this.lblAssignment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignment.Location = new System.Drawing.Point(39, 475);
            this.lblAssignment.Name = "lblAssignment";
            this.lblAssignment.Size = new System.Drawing.Size(116, 23);
            this.lblAssignment.TabIndex = 66;
            this.lblAssignment.Text = "Asignación";
            // 
            // txtQuantity
            // 
            this.txtQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolBindingSource, "QuantityAvailable", true));
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(311, 410);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(342, 32);
            this.txtQuantity.TabIndex = 65;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(39, 419);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(209, 23);
            this.lblQuantity.TabIndex = 64;
            this.lblQuantity.Text = "Cantidad disponible";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolBindingSource, "Name", true));
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(311, 353);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(342, 32);
            this.txtName.TabIndex = 63;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(39, 362);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 23);
            this.lblName.TabIndex = 62;
            this.lblName.Text = "Nombre";
            // 
            // txtToolId
            // 
            this.txtToolId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolBindingSource, "Id", true));
            this.txtToolId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToolId.Location = new System.Drawing.Point(311, 297);
            this.txtToolId.Name = "txtToolId";
            this.txtToolId.Size = new System.Drawing.Size(342, 32);
            this.txtToolId.TabIndex = 61;
            this.txtToolId.TextChanged += new System.EventHandler(this.frmTool_Load);
            // 
            // lblToolID
            // 
            this.lblToolID.AutoSize = true;
            this.lblToolID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolID.Location = new System.Drawing.Point(39, 306);
            this.lblToolID.Name = "lblToolID";
            this.lblToolID.Size = new System.Drawing.Size(215, 23);
            this.lblToolID.TabIndex = 60;
            this.lblToolID.Text = "ID de la Herramienta";
            // 
            // lblTool
            // 
            this.lblTool.AutoSize = true;
            this.lblTool.BackColor = System.Drawing.Color.PeachPuff;
            this.lblTool.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTool.Location = new System.Drawing.Point(417, 168);
            this.lblTool.Name = "lblTool";
            this.lblTool.Size = new System.Drawing.Size(182, 34);
            this.lblTool.TabIndex = 59;
            this.lblTool.Text = "Herramienta";
            this.lblTool.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grdTools
            // 
            this.grdTools.AutoGenerateColumns = false;
            this.grdTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTools.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityAvailableDataGridViewTextBoxColumn,
            this.toolAssignmentDataGridViewTextBoxColumn});
            this.grdTools.DataSource = this.toolBindingSource;
            this.grdTools.Location = new System.Drawing.Point(1033, 168);
            this.grdTools.Name = "grdTools";
            this.grdTools.RowHeadersWidth = 51;
            this.grdTools.RowTemplate.Height = 24;
            this.grdTools.Size = new System.Drawing.Size(605, 523);
            this.grdTools.TabIndex = 74;
            // 
            // toolBindingSource
            // 
            this.toolBindingSource.DataSource = typeof(PSP_Infrago.Entities.Tool);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityAvailableDataGridViewTextBoxColumn
            // 
            this.quantityAvailableDataGridViewTextBoxColumn.DataPropertyName = "QuantityAvailable";
            this.quantityAvailableDataGridViewTextBoxColumn.HeaderText = "QuantityAvailable";
            this.quantityAvailableDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityAvailableDataGridViewTextBoxColumn.Name = "quantityAvailableDataGridViewTextBoxColumn";
            this.quantityAvailableDataGridViewTextBoxColumn.Width = 125;
            // 
            // toolAssignmentDataGridViewTextBoxColumn
            // 
            this.toolAssignmentDataGridViewTextBoxColumn.DataPropertyName = "ToolAssignment";
            this.toolAssignmentDataGridViewTextBoxColumn.HeaderText = "ToolAssignment";
            this.toolAssignmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toolAssignmentDataGridViewTextBoxColumn.Name = "toolAssignmentDataGridViewTextBoxColumn";
            this.toolAssignmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.PeachPuff;
            this.btnUpload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(752, 528);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(180, 38);
            this.btnUpload.TabIndex = 75;
            this.btnUpload.Text = "Cargar";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(824, 653);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 38);
            this.btnCancel.TabIndex = 76;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 859);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.grdTools);
            this.Controls.Add(this.lblProjectPicture);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pctTool);
            this.Controls.Add(this.txtAssignation);
            this.Controls.Add(this.lblAssignment);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtToolId);
            this.Controls.Add(this.lblToolID);
            this.Controls.Add(this.lblTool);
            this.Name = "frmTool";
            this.Text = "Herramienta";
            this.Load += new System.EventHandler(this.frmTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectPicture;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pctTool;
        private System.Windows.Forms.TextBox txtAssignation;
        private System.Windows.Forms.Label lblAssignment;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtToolId;
        private System.Windows.Forms.Label lblToolID;
        private System.Windows.Forms.Label lblTool;
        private System.Windows.Forms.DataGridView grdTools;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolAssignmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource toolBindingSource;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnCancel;
    }
}