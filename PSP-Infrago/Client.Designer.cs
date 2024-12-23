﻿namespace PSP_Infrago
{
    partial class frmClient
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
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.txtTownship = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtExteriorNumber = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.lblTownship = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblExteriorNumber = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlStyle2 = new System.Windows.Forms.Panel();
            this.pnlStyle1 = new System.Windows.Forms.Panel();
            this.dgrClient = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exteriorNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.townshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttNew = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.bttUpdate = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrClient)).BeginInit();
            this.SuspendLayout();
            // 
            // grpData
            // 
            this.grpData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.grpData.Controls.Add(this.lblCity);
            this.grpData.Controls.Add(this.txtCity);
            this.grpData.Controls.Add(this.txtZipcode);
            this.grpData.Controls.Add(this.txtTownship);
            this.grpData.Controls.Add(this.txtState);
            this.grpData.Controls.Add(this.txtExteriorNumber);
            this.grpData.Controls.Add(this.txtStreet);
            this.grpData.Controls.Add(this.txtEmail);
            this.grpData.Controls.Add(this.txtPhoneNumber);
            this.grpData.Controls.Add(this.txtProject);
            this.grpData.Controls.Add(this.lblZipcode);
            this.grpData.Controls.Add(this.lblTownship);
            this.grpData.Controls.Add(this.txtClientName);
            this.grpData.Controls.Add(this.lblState);
            this.grpData.Controls.Add(this.lblExteriorNumber);
            this.grpData.Controls.Add(this.lblStreet);
            this.grpData.Controls.Add(this.lblEmail);
            this.grpData.Controls.Add(this.lblPhoneNumber);
            this.grpData.Controls.Add(this.lblProject);
            this.grpData.Controls.Add(this.lblClientName);
            this.grpData.Font = new System.Drawing.Font("Typo Grotesk", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpData.Location = new System.Drawing.Point(18, 111);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(914, 431);
            this.grpData.TabIndex = 12;
            this.grpData.TabStop = false;
            this.grpData.Text = "Datos del cliente";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(17, 336);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(93, 26);
            this.lblCity.TabIndex = 32;
            this.lblCity.Text = "Ciudad:";
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "City", true));
            this.txtCity.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(130, 334);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(430, 34);
            this.txtCity.TabIndex = 31;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(PSP_Infrago.Entities.Client);
            // 
            // txtZipcode
            // 
            this.txtZipcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZipcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ZipCode", true));
            this.txtZipcode.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZipcode.Location = new System.Drawing.Point(733, 333);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(132, 34);
            this.txtZipcode.TabIndex = 30;
            // 
            // txtTownship
            // 
            this.txtTownship.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTownship.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Township", true));
            this.txtTownship.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTownship.Location = new System.Drawing.Point(591, 276);
            this.txtTownship.Name = "txtTownship";
            this.txtTownship.Size = new System.Drawing.Size(274, 34);
            this.txtTownship.TabIndex = 29;
            // 
            // txtState
            // 
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "State", true));
            this.txtState.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(130, 272);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(316, 34);
            this.txtState.TabIndex = 28;
            // 
            // txtExteriorNumber
            // 
            this.txtExteriorNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExteriorNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ExteriorNumber", true));
            this.txtExteriorNumber.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExteriorNumber.Location = new System.Drawing.Point(663, 216);
            this.txtExteriorNumber.Name = "txtExteriorNumber";
            this.txtExteriorNumber.Size = new System.Drawing.Size(202, 34);
            this.txtExteriorNumber.TabIndex = 27;
            // 
            // txtStreet
            // 
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Street", true));
            this.txtStreet.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(130, 216);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(316, 34);
            this.txtStreet.TabIndex = 26;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Email", true));
            this.txtEmail.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(551, 158);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(314, 34);
            this.txtEmail.TabIndex = 25;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Phone", true));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(132, 160);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(314, 34);
            this.txtPhoneNumber.TabIndex = 24;
            // 
            // txtProject
            // 
            this.txtProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Project", true));
            this.txtProject.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProject.Location = new System.Drawing.Point(132, 104);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(732, 34);
            this.txtProject.TabIndex = 23;
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipcode.Location = new System.Drawing.Point(566, 336);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(161, 26);
            this.lblZipcode.TabIndex = 22;
            this.lblZipcode.Text = "Código postal:";
            // 
            // lblTownship
            // 
            this.lblTownship.AutoSize = true;
            this.lblTownship.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTownship.Location = new System.Drawing.Point(472, 278);
            this.lblTownship.Name = "lblTownship";
            this.lblTownship.Size = new System.Drawing.Size(113, 26);
            this.lblTownship.TabIndex = 21;
            this.lblTownship.Text = "Municipio:";
            // 
            // txtClientName
            // 
            this.txtClientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Name", true));
            this.txtClientName.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.Location = new System.Drawing.Point(243, 52);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(621, 34);
            this.txtClientName.TabIndex = 10;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(17, 278);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(86, 26);
            this.lblState.TabIndex = 7;
            this.lblState.Text = "Estado:";
            // 
            // lblExteriorNumber
            // 
            this.lblExteriorNumber.AutoSize = true;
            this.lblExteriorNumber.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExteriorNumber.Location = new System.Drawing.Point(472, 218);
            this.lblExteriorNumber.Name = "lblExteriorNumber";
            this.lblExteriorNumber.Size = new System.Drawing.Size(185, 26);
            this.lblExteriorNumber.TabIndex = 6;
            this.lblExteriorNumber.Text = "Número exterior:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(17, 222);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(72, 26);
            this.lblStreet.TabIndex = 5;
            this.lblStreet.Text = "Calle:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(472, 162);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(75, 26);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(17, 162);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(109, 26);
            this.lblPhoneNumber.TabIndex = 3;
            this.lblPhoneNumber.Text = "Teléfono:";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(17, 106);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(109, 26);
            this.lblProject.TabIndex = 2;
            this.lblProject.Text = "Proyecto:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Typo Grotesk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(17, 54);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(220, 26);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "Nombre del cliente:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Typo Grotesk", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(237, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(451, 53);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Registro del Cliente";
            // 
            // pnlStyle2
            // 
            this.pnlStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.pnlStyle2.Location = new System.Drawing.Point(-4, 634);
            this.pnlStyle2.Name = "pnlStyle2";
            this.pnlStyle2.Size = new System.Drawing.Size(1686, 40);
            this.pnlStyle2.TabIndex = 10;
            // 
            // pnlStyle1
            // 
            this.pnlStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.pnlStyle1.Location = new System.Drawing.Point(-6, -2);
            this.pnlStyle1.Name = "pnlStyle1";
            this.pnlStyle1.Size = new System.Drawing.Size(1688, 39);
            this.pnlStyle1.TabIndex = 9;
            // 
            // dgrClient
            // 
            this.dgrClient.AutoGenerateColumns = false;
            this.dgrClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.exteriorNumberDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.townshipDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.zipCodeDataGridViewTextBoxColumn,
            this.projectDataGridViewTextBoxColumn});
            this.dgrClient.DataSource = this.clientBindingSource;
            this.dgrClient.EnableHeadersVisualStyles = false;
            this.dgrClient.Location = new System.Drawing.Point(938, 44);
            this.dgrClient.Name = "dgrClient";
            this.dgrClient.RowHeadersWidth = 51;
            this.dgrClient.RowTemplate.Height = 24;
            this.dgrClient.Size = new System.Drawing.Size(732, 584);
            this.dgrClient.TabIndex = 13;
            this.dgrClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrClient_CellClick);
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
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.Width = 125;
            // 
            // exteriorNumberDataGridViewTextBoxColumn
            // 
            this.exteriorNumberDataGridViewTextBoxColumn.DataPropertyName = "ExteriorNumber";
            this.exteriorNumberDataGridViewTextBoxColumn.HeaderText = "ExteriorNumber";
            this.exteriorNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.exteriorNumberDataGridViewTextBoxColumn.Name = "exteriorNumberDataGridViewTextBoxColumn";
            this.exteriorNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.Width = 125;
            // 
            // townshipDataGridViewTextBoxColumn
            // 
            this.townshipDataGridViewTextBoxColumn.DataPropertyName = "Township";
            this.townshipDataGridViewTextBoxColumn.HeaderText = "Township";
            this.townshipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.townshipDataGridViewTextBoxColumn.Name = "townshipDataGridViewTextBoxColumn";
            this.townshipDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.HeaderText = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            this.zipCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // projectDataGridViewTextBoxColumn
            // 
            this.projectDataGridViewTextBoxColumn.DataPropertyName = "Project";
            this.projectDataGridViewTextBoxColumn.HeaderText = "Project";
            this.projectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectDataGridViewTextBoxColumn.Name = "projectDataGridViewTextBoxColumn";
            this.projectDataGridViewTextBoxColumn.Width = 125;
            // 
            // bttNew
            // 
            this.bttNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
            this.bttNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttNew.Font = new System.Drawing.Font("Typo Grotesk", 11.2F);
            this.bttNew.Location = new System.Drawing.Point(146, 568);
            this.bttNew.Name = "bttNew";
            this.bttNew.Size = new System.Drawing.Size(122, 33);
            this.bttNew.TabIndex = 25;
            this.bttNew.Text = "Nuevo";
            this.bttNew.UseVisualStyleBackColor = false;
            this.bttNew.Click += new System.EventHandler(this.bttNew_Click_1);
            // 
            // bttCancel
            // 
            this.bttCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
            this.bttCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancel.Font = new System.Drawing.Font("Typo Grotesk", 11.2F);
            this.bttCancel.Location = new System.Drawing.Point(566, 568);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(122, 33);
            this.bttCancel.TabIndex = 24;
            this.bttCancel.Text = "Cancelar";
            this.bttCancel.UseVisualStyleBackColor = false;
            this.bttCancel.Click += new System.EventHandler(this.bttCancel_Click_1);
            // 
            // bttUpdate
            // 
            this.bttUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
            this.bttUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttUpdate.Font = new System.Drawing.Font("Typo Grotesk", 11.2F);
            this.bttUpdate.Location = new System.Drawing.Point(428, 568);
            this.bttUpdate.Name = "bttUpdate";
            this.bttUpdate.Size = new System.Drawing.Size(122, 33);
            this.bttUpdate.TabIndex = 23;
            this.bttUpdate.Text = "Actualizar";
            this.bttUpdate.UseVisualStyleBackColor = false;
            this.bttUpdate.Click += new System.EventHandler(this.bttUpdate_Click_1);
            // 
            // bttDelete
            // 
            this.bttDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
            this.bttDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDelete.Font = new System.Drawing.Font("Typo Grotesk", 11.2F);
            this.bttDelete.Location = new System.Drawing.Point(708, 568);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(122, 33);
            this.bttDelete.TabIndex = 22;
            this.bttDelete.Text = "Eliminar";
            this.bttDelete.UseVisualStyleBackColor = false;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click_1);
            // 
            // bttSave
            // 
            this.bttSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
            this.bttSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSave.Font = new System.Drawing.Font("Typo Grotesk", 11.2F);
            this.bttSave.Location = new System.Drawing.Point(288, 568);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(122, 33);
            this.bttSave.TabIndex = 21;
            this.bttSave.Text = "Guardar";
            this.bttSave.UseVisualStyleBackColor = false;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click_1);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1682, 673);
            this.Controls.Add(this.bttNew);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.bttUpdate);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.dgrClient);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlStyle2);
            this.Controls.Add(this.pnlStyle1);
            this.Name = "frmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmClient_FormClosed);
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.TextBox txtTownship;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtExteriorNumber;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.Label lblTownship;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblExteriorNumber;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlStyle2;
        private System.Windows.Forms.Panel pnlStyle1;
        private System.Windows.Forms.DataGridView dgrClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exteriorNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn townshipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Button bttNew;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.Button bttUpdate;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttSave;
    }
}