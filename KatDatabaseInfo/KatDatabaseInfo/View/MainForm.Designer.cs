
namespace KatDatabaseInfo
{
    partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDI = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDell = new System.Windows.Forms.Button();
            this.cbCategories = new System.Windows.Forms.CheckedListBox();
            this.cbSearchDriver = new System.Windows.Forms.ComboBox();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new DatabaseDataSet();
            this.lblSearchDriver = new System.Windows.Forms.Label();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.gbImage = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbLicense = new System.Windows.Forms.GroupBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.cbPointsLeft = new System.Windows.Forms.ComboBox();
            this.lblLicenseId = new System.Windows.Forms.Label();
            this.txtBoxLicenseId = new System.Windows.Forms.TextBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblCatecories = new System.Windows.Forms.Label();
            this.gbPerfonalData = new System.Windows.Forms.GroupBox();
            this.txtBoxBirthDate = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.blbAddress = new System.Windows.Forms.Label();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtBoxCountry = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtBoxMiddleName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblIdentityNumber = new System.Windows.Forms.Label();
            this.tabPageF = new System.Windows.Forms.TabPage();
            this.gbFine = new System.Windows.Forms.GroupBox();
            this.btnClearFine = new System.Windows.Forms.Button();
            this.btnUpdateFine = new System.Windows.Forms.Button();
            this.btnDeleteFine = new System.Windows.Forms.Button();
            this.btnAddFine = new System.Windows.Forms.Button();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBoxFineId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxOffenderDLN = new System.Windows.Forms.TextBox();
            this.lblOffenderDLN = new System.Windows.Forms.Label();
            this.txtBoxReason = new System.Windows.Forms.TextBox();
            this.txtBoxPoliceman = new System.Windows.Forms.TextBox();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.cbPaid = new System.Windows.Forms.ComboBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lblPoliceman = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cbFineIds = new System.Windows.Forms.ComboBox();
            this.finesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblFineId = new System.Windows.Forms.Label();
            this.tabPageV = new System.Windows.Forms.TabPage();
            this.gbCarData = new System.Windows.Forms.GroupBox();
            this.btnClearVehicle = new System.Windows.Forms.Button();
            this.btnUpdateVehicle = new System.Windows.Forms.Button();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.txtBoxOwnerDLN = new System.Windows.Forms.TextBox();
            this.txtBoxRegNumber = new System.Windows.Forms.TextBox();
            this.txtBoxRegDate = new System.Windows.Forms.TextBox();
            this.txtBoxColor = new System.Windows.Forms.TextBox();
            this.txtBoxWeight = new System.Windows.Forms.TextBox();
            this.txtBoxSeats = new System.Windows.Forms.TextBox();
            this.txtBoxType = new System.Windows.Forms.TextBox();
            this.txtBoxModel = new System.Windows.Forms.TextBox();
            this.txtBoxBrand = new System.Windows.Forms.TextBox();
            this.txtBoxEngineNumber = new System.Windows.Forms.TextBox();
            this.txtBoxFrameNumber = new System.Windows.Forms.TextBox();
            this.lblOwnerDLN = new System.Windows.Forms.Label();
            this.lblRegNumberForAdd = new System.Windows.Forms.Label();
            this.lblRegistryDate = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblTypeVehicle = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblEngine = new System.Windows.Forms.Label();
            this.lblFrameNumber = new System.Windows.Forms.Label();
            this.cbRegistryNumber = new System.Windows.Forms.ComboBox();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRegNumber = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversTableAdapter = new DatabaseDataSetTableAdapters.DriversTableAdapter();
            this.finesTableAdapter = new DatabaseDataSetTableAdapters.FinesTableAdapter();
            this.vehicleTableAdapter = new DatabaseDataSetTableAdapters.VehicleTableAdapter();
            this.tabControl.SuspendLayout();
            this.tabPageDI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.gbImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbLicense.SuspendLayout();
            this.gbPerfonalData.SuspendLayout();
            this.tabPageF.SuspendLayout();
            this.gbFine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finesBindingSource)).BeginInit();
            this.tabPageV.SuspendLayout();
            this.gbCarData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageDI);
            this.tabControl.Controls.Add(this.tabPageF);
            this.tabControl.Controls.Add(this.tabPageV);
            this.tabControl.Location = new System.Drawing.Point(3, 37);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(855, 511);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageDI
            // 
            this.tabPageDI.Controls.Add(this.btnClear);
            this.tabPageDI.Controls.Add(this.btnUpdate);
            this.tabPageDI.Controls.Add(this.btnDell);
            this.tabPageDI.Controls.Add(this.cbCategories);
            this.tabPageDI.Controls.Add(this.cbSearchDriver);
            this.tabPageDI.Controls.Add(this.lblSearchDriver);
            this.tabPageDI.Controls.Add(this.btnAddDriver);
            this.tabPageDI.Controls.Add(this.gbImage);
            this.tabPageDI.Controls.Add(this.gbLicense);
            this.tabPageDI.Controls.Add(this.gbPerfonalData);
            this.tabPageDI.Location = new System.Drawing.Point(4, 22);
            this.tabPageDI.Name = "tabPageDI";
            this.tabPageDI.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDI.Size = new System.Drawing.Size(847, 485);
            this.tabPageDI.TabIndex = 0;
            this.tabPageDI.Text = "Driver Info";
            this.tabPageDI.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(250, 459);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(550, 459);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 23);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDell
            // 
            this.btnDell.Location = new System.Drawing.Point(400, 459);
            this.btnDell.Name = "btnDell";
            this.btnDell.Size = new System.Drawing.Size(128, 23);
            this.btnDell.TabIndex = 18;
            this.btnDell.Text = "Delete Driver";
            this.btnDell.UseVisualStyleBackColor = true;
            this.btnDell.Click += new System.EventHandler(this.btnDell_Click);
            // 
            // cbCategories
            // 
            this.cbCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbCategories.CheckOnClick = true;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "BE",
            "CE",
            "DE",
            "Ttb",
            "Ttm",
            "Tkt",
            "M"});
            this.cbCategories.Location = new System.Drawing.Point(516, 332);
            this.cbCategories.MaximumSize = new System.Drawing.Size(400, 100);
            this.cbCategories.MultiColumn = true;
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbCategories.Size = new System.Drawing.Size(298, 90);
            this.cbCategories.TabIndex = 12;
            // 
            // cbSearchDriver
            // 
            this.cbSearchDriver.DataSource = this.driversBindingSource;
            this.cbSearchDriver.DisplayMember = "DrivingLicenseNumber";
            this.cbSearchDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchDriver.FormattingEnabled = true;
            this.cbSearchDriver.Location = new System.Drawing.Point(701, 6);
            this.cbSearchDriver.Name = "cbSearchDriver";
            this.cbSearchDriver.Size = new System.Drawing.Size(140, 21);
            this.cbSearchDriver.TabIndex = 17;
            this.cbSearchDriver.ValueMember = "DrivingLicenseNumber";
            this.cbSearchDriver.SelectedIndexChanged += new System.EventHandler(this.cbSearchDriver_SelectedIndexChanged);
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataMember = "Drivers";
            this.driversBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSearchDriver
            // 
            this.lblSearchDriver.AutoSize = true;
            this.lblSearchDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSearchDriver.Location = new System.Drawing.Point(480, 7);
            this.lblSearchDriver.Name = "lblSearchDriver";
            this.lblSearchDriver.Size = new System.Drawing.Size(214, 16);
            this.lblSearchDriver.TabIndex = 16;
            this.lblSearchDriver.Text = "Select Driver License Number";
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(700, 459);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(128, 23);
            this.btnAddDriver.TabIndex = 15;
            this.btnAddDriver.Text = "Add Driver";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // gbImage
            // 
            this.gbImage.Controls.Add(this.pictureBox1);
            this.gbImage.Location = new System.Drawing.Point(6, 17);
            this.gbImage.Name = "gbImage";
            this.gbImage.Size = new System.Drawing.Size(298, 306);
            this.gbImage.TabIndex = 14;
            this.gbImage.TabStop = false;
            this.gbImage.Text = "Image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 281);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbLicense
            // 
            this.gbLicense.Controls.Add(this.cbRole);
            this.gbLicense.Controls.Add(this.cbPointsLeft);
            this.gbLicense.Controls.Add(this.lblLicenseId);
            this.gbLicense.Controls.Add(this.txtBoxLicenseId);
            this.gbLicense.Controls.Add(this.lblPoints);
            this.gbLicense.Controls.Add(this.lblRole);
            this.gbLicense.Controls.Add(this.lblCatecories);
            this.gbLicense.Location = new System.Drawing.Point(6, 332);
            this.gbLicense.Name = "gbLicense";
            this.gbLicense.Size = new System.Drawing.Size(814, 121);
            this.gbLicense.TabIndex = 13;
            this.gbLicense.TabStop = false;
            this.gbLicense.Text = "License Data";
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "CITIZEN",
            "ADMIN",
            ""});
            this.cbRole.Location = new System.Drawing.Point(132, 87);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(90, 21);
            this.cbRole.TabIndex = 12;
            // 
            // cbPointsLeft
            // 
            this.cbPointsLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPointsLeft.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39"});
            this.cbPointsLeft.Location = new System.Drawing.Point(133, 59);
            this.cbPointsLeft.Name = "cbPointsLeft";
            this.cbPointsLeft.Size = new System.Drawing.Size(90, 21);
            this.cbPointsLeft.TabIndex = 11;
            // 
            // lblLicenseId
            // 
            this.lblLicenseId.AutoSize = true;
            this.lblLicenseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseId.Location = new System.Drawing.Point(28, 31);
            this.lblLicenseId.Name = "lblLicenseId";
            this.lblLicenseId.Size = new System.Drawing.Size(81, 16);
            this.lblLicenseId.TabIndex = 6;
            this.lblLicenseId.Text = "License ID";
            // 
            // txtBoxLicenseId
            // 
            this.txtBoxLicenseId.Location = new System.Drawing.Point(133, 31);
            this.txtBoxLicenseId.Name = "txtBoxLicenseId";
            this.txtBoxLicenseId.ReadOnly = true;
            this.txtBoxLicenseId.Size = new System.Drawing.Size(167, 20);
            this.txtBoxLicenseId.TabIndex = 7;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(29, 59);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(80, 16);
            this.lblPoints.TabIndex = 10;
            this.lblPoints.Text = "Poinst Left";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(28, 87);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(41, 16);
            this.lblRole.TabIndex = 8;
            this.lblRole.Text = "Role";
            // 
            // lblCatecories
            // 
            this.lblCatecories.AutoSize = true;
            this.lblCatecories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatecories.Location = new System.Drawing.Point(384, 0);
            this.lblCatecories.Name = "lblCatecories";
            this.lblCatecories.Size = new System.Drawing.Size(84, 16);
            this.lblCatecories.TabIndex = 8;
            this.lblCatecories.Text = "Categories";
            // 
            // gbPerfonalData
            // 
            this.gbPerfonalData.Controls.Add(this.txtBoxBirthDate);
            this.gbPerfonalData.Controls.Add(this.lblBirthDate);
            this.gbPerfonalData.Controls.Add(this.cbGender);
            this.gbPerfonalData.Controls.Add(this.txtBoxAddress);
            this.gbPerfonalData.Controls.Add(this.blbAddress);
            this.gbPerfonalData.Controls.Add(this.txtBoxCity);
            this.gbPerfonalData.Controls.Add(this.lblCity);
            this.gbPerfonalData.Controls.Add(this.txtBoxCountry);
            this.gbPerfonalData.Controls.Add(this.lbCountry);
            this.gbPerfonalData.Controls.Add(this.lblName);
            this.gbPerfonalData.Controls.Add(this.txtBoxName);
            this.gbPerfonalData.Controls.Add(this.lblGender);
            this.gbPerfonalData.Controls.Add(this.lblMiddleName);
            this.gbPerfonalData.Controls.Add(this.txtBoxMiddleName);
            this.gbPerfonalData.Controls.Add(this.lblLastName);
            this.gbPerfonalData.Controls.Add(this.txtBoxId);
            this.gbPerfonalData.Controls.Add(this.txtBoxLastName);
            this.gbPerfonalData.Controls.Add(this.lblIdentityNumber);
            this.gbPerfonalData.Location = new System.Drawing.Point(344, 29);
            this.gbPerfonalData.Name = "gbPerfonalData";
            this.gbPerfonalData.Size = new System.Drawing.Size(497, 288);
            this.gbPerfonalData.TabIndex = 12;
            this.gbPerfonalData.TabStop = false;
            this.gbPerfonalData.Text = "Personal Data";
            // 
            // txtBoxBirthDate
            // 
            this.txtBoxBirthDate.Location = new System.Drawing.Point(153, 136);
            this.txtBoxBirthDate.Name = "txtBoxBirthDate";
            this.txtBoxBirthDate.ReadOnly = true;
            this.txtBoxBirthDate.Size = new System.Drawing.Size(197, 20);
            this.txtBoxBirthDate.TabIndex = 20;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(48, 136);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(76, 16);
            this.lblBirthDate.TabIndex = 19;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(153, 161);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(91, 21);
            this.cbGender.TabIndex = 18;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(153, 249);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.ReadOnly = true;
            this.txtBoxAddress.Size = new System.Drawing.Size(329, 20);
            this.txtBoxAddress.TabIndex = 17;
            // 
            // blbAddress
            // 
            this.blbAddress.AutoSize = true;
            this.blbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbAddress.Location = new System.Drawing.Point(48, 250);
            this.blbAddress.Name = "blbAddress";
            this.blbAddress.Size = new System.Drawing.Size(66, 16);
            this.blbAddress.TabIndex = 16;
            this.blbAddress.Text = "Address";
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(153, 221);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.ReadOnly = true;
            this.txtBoxCity.Size = new System.Drawing.Size(329, 20);
            this.txtBoxCity.TabIndex = 15;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(48, 222);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 16);
            this.lblCity.TabIndex = 14;
            this.lblCity.Text = "City";
            // 
            // txtBoxCountry
            // 
            this.txtBoxCountry.Location = new System.Drawing.Point(153, 194);
            this.txtBoxCountry.Name = "txtBoxCountry";
            this.txtBoxCountry.ReadOnly = true;
            this.txtBoxCountry.Size = new System.Drawing.Size(329, 20);
            this.txtBoxCountry.TabIndex = 13;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry.Location = new System.Drawing.Point(48, 195);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 16);
            this.lbCountry.TabIndex = 12;
            this.lbCountry.Text = "Country";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(48, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "First Name";
            this.lblName.UseWaitCursor = true;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(153, 36);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.ReadOnly = true;
            this.txtBoxName.Size = new System.Drawing.Size(197, 20);
            this.txtBoxName.TabIndex = 1;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(48, 164);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(59, 16);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(48, 61);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(100, 16);
            this.lblMiddleName.TabIndex = 2;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // txtBoxMiddleName
            // 
            this.txtBoxMiddleName.Location = new System.Drawing.Point(153, 61);
            this.txtBoxMiddleName.Name = "txtBoxMiddleName";
            this.txtBoxMiddleName.ReadOnly = true;
            this.txtBoxMiddleName.Size = new System.Drawing.Size(197, 20);
            this.txtBoxMiddleName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(48, 86);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 16);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(153, 111);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.Size = new System.Drawing.Size(197, 20);
            this.txtBoxId.TabIndex = 7;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(153, 86);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.ReadOnly = true;
            this.txtBoxLastName.Size = new System.Drawing.Size(197, 20);
            this.txtBoxLastName.TabIndex = 5;
            // 
            // lblIdentityNumber
            // 
            this.lblIdentityNumber.AutoSize = true;
            this.lblIdentityNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentityNumber.Location = new System.Drawing.Point(48, 111);
            this.lblIdentityNumber.Name = "lblIdentityNumber";
            this.lblIdentityNumber.Size = new System.Drawing.Size(23, 16);
            this.lblIdentityNumber.TabIndex = 6;
            this.lblIdentityNumber.Text = "ID";
            // 
            // tabPageF
            // 
            this.tabPageF.Controls.Add(this.gbFine);
            this.tabPageF.Controls.Add(this.cbFineIds);
            this.tabPageF.Controls.Add(this.lblFineId);
            this.tabPageF.Location = new System.Drawing.Point(4, 22);
            this.tabPageF.Name = "tabPageF";
            this.tabPageF.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageF.Size = new System.Drawing.Size(847, 485);
            this.tabPageF.TabIndex = 1;
            this.tabPageF.Text = "Fines";
            this.tabPageF.UseVisualStyleBackColor = true;
            // 
            // gbFine
            // 
            this.gbFine.Controls.Add(this.btnClearFine);
            this.gbFine.Controls.Add(this.btnUpdateFine);
            this.gbFine.Controls.Add(this.btnDeleteFine);
            this.gbFine.Controls.Add(this.btnAddFine);
            this.gbFine.Controls.Add(this.txtBoxPrice);
            this.gbFine.Controls.Add(this.lblPrice);
            this.gbFine.Controls.Add(this.txtBoxFineId);
            this.gbFine.Controls.Add(this.label2);
            this.gbFine.Controls.Add(this.txtBoxOffenderDLN);
            this.gbFine.Controls.Add(this.lblOffenderDLN);
            this.gbFine.Controls.Add(this.txtBoxReason);
            this.gbFine.Controls.Add(this.txtBoxPoliceman);
            this.gbFine.Controls.Add(this.txtBoxDate);
            this.gbFine.Controls.Add(this.lblReason);
            this.gbFine.Controls.Add(this.cbPaid);
            this.gbFine.Controls.Add(this.lblPaid);
            this.gbFine.Controls.Add(this.lblPoliceman);
            this.gbFine.Controls.Add(this.lblDate);
            this.gbFine.Controls.Add(this.cbType);
            this.gbFine.Controls.Add(this.lblType);
            this.gbFine.Location = new System.Drawing.Point(28, 59);
            this.gbFine.Name = "gbFine";
            this.gbFine.Size = new System.Drawing.Size(793, 406);
            this.gbFine.TabIndex = 2;
            this.gbFine.TabStop = false;
            this.gbFine.Text = "Fine\'s Data";
            // 
            // btnClearFine
            // 
            this.btnClearFine.Location = new System.Drawing.Point(209, 383);
            this.btnClearFine.Name = "btnClearFine";
            this.btnClearFine.Size = new System.Drawing.Size(128, 23);
            this.btnClearFine.TabIndex = 25;
            this.btnClearFine.Text = "Clear";
            this.btnClearFine.UseVisualStyleBackColor = true;
            this.btnClearFine.Click += new System.EventHandler(this.btnClearFine_Click);
            // 
            // btnUpdateFine
            // 
            this.btnUpdateFine.Location = new System.Drawing.Point(509, 383);
            this.btnUpdateFine.Name = "btnUpdateFine";
            this.btnUpdateFine.Size = new System.Drawing.Size(128, 23);
            this.btnUpdateFine.TabIndex = 24;
            this.btnUpdateFine.Text = "Update";
            this.btnUpdateFine.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFine
            // 
            this.btnDeleteFine.Location = new System.Drawing.Point(359, 383);
            this.btnDeleteFine.Name = "btnDeleteFine";
            this.btnDeleteFine.Size = new System.Drawing.Size(128, 23);
            this.btnDeleteFine.TabIndex = 23;
            this.btnDeleteFine.Text = "Delete Fine";
            this.btnDeleteFine.UseVisualStyleBackColor = true;
            this.btnDeleteFine.Click += new System.EventHandler(this.btnDeleteFine_Click);
            // 
            // btnAddFine
            // 
            this.btnAddFine.Location = new System.Drawing.Point(659, 383);
            this.btnAddFine.Name = "btnAddFine";
            this.btnAddFine.Size = new System.Drawing.Size(128, 23);
            this.btnAddFine.TabIndex = 22;
            this.btnAddFine.Text = "Add Fine";
            this.btnAddFine.UseVisualStyleBackColor = true;
            this.btnAddFine.Click += new System.EventHandler(this.btnAddFine_Click);
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(148, 129);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.ReadOnly = true;
            this.txtBoxPrice.Size = new System.Drawing.Size(237, 20);
            this.txtBoxPrice.TabIndex = 21;
            this.txtBoxPrice.Visible = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(32, 130);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 16);
            this.lblPrice.TabIndex = 20;
            this.lblPrice.Text = "Amount";
            this.lblPrice.Visible = false;
            // 
            // txtBoxFineId
            // 
            this.txtBoxFineId.Location = new System.Drawing.Point(148, 179);
            this.txtBoxFineId.Name = "txtBoxFineId";
            this.txtBoxFineId.ReadOnly = true;
            this.txtBoxFineId.Size = new System.Drawing.Size(237, 20);
            this.txtBoxFineId.TabIndex = 19;
            this.txtBoxFineId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(32, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fine ID";
            this.label2.Visible = false;
            // 
            // txtBoxOffenderDLN
            // 
            this.txtBoxOffenderDLN.Location = new System.Drawing.Point(148, 154);
            this.txtBoxOffenderDLN.Name = "txtBoxOffenderDLN";
            this.txtBoxOffenderDLN.ReadOnly = true;
            this.txtBoxOffenderDLN.Size = new System.Drawing.Size(237, 20);
            this.txtBoxOffenderDLN.TabIndex = 17;
            this.txtBoxOffenderDLN.Visible = false;
            // 
            // lblOffenderDLN
            // 
            this.lblOffenderDLN.AutoSize = true;
            this.lblOffenderDLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblOffenderDLN.Location = new System.Drawing.Point(32, 155);
            this.lblOffenderDLN.Name = "lblOffenderDLN";
            this.lblOffenderDLN.Size = new System.Drawing.Size(101, 16);
            this.lblOffenderDLN.TabIndex = 16;
            this.lblOffenderDLN.Text = "Offender DLN";
            this.lblOffenderDLN.Visible = false;
            // 
            // txtBoxReason
            // 
            this.txtBoxReason.Location = new System.Drawing.Point(148, 215);
            this.txtBoxReason.Multiline = true;
            this.txtBoxReason.Name = "txtBoxReason";
            this.txtBoxReason.ReadOnly = true;
            this.txtBoxReason.Size = new System.Drawing.Size(579, 127);
            this.txtBoxReason.TabIndex = 14;
            // 
            // txtBoxPoliceman
            // 
            this.txtBoxPoliceman.Location = new System.Drawing.Point(148, 79);
            this.txtBoxPoliceman.Name = "txtBoxPoliceman";
            this.txtBoxPoliceman.ReadOnly = true;
            this.txtBoxPoliceman.Size = new System.Drawing.Size(237, 20);
            this.txtBoxPoliceman.TabIndex = 13;
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Location = new System.Drawing.Point(148, 54);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.ReadOnly = true;
            this.txtBoxDate.Size = new System.Drawing.Size(122, 20);
            this.txtBoxDate.TabIndex = 12;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblReason.Location = new System.Drawing.Point(32, 216);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(62, 16);
            this.lblReason.TabIndex = 10;
            this.lblReason.Text = "Reason";
            // 
            // cbPaid
            // 
            this.cbPaid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaid.FormattingEnabled = true;
            this.cbPaid.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cbPaid.Location = new System.Drawing.Point(148, 104);
            this.cbPaid.Name = "cbPaid";
            this.cbPaid.Size = new System.Drawing.Size(121, 21);
            this.cbPaid.TabIndex = 9;
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPaid.Location = new System.Drawing.Point(32, 105);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(40, 16);
            this.lblPaid.TabIndex = 8;
            this.lblPaid.Text = "Paid";
            // 
            // lblPoliceman
            // 
            this.lblPoliceman.AutoSize = true;
            this.lblPoliceman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPoliceman.Location = new System.Drawing.Point(32, 80);
            this.lblPoliceman.Name = "lblPoliceman";
            this.lblPoliceman.Size = new System.Drawing.Size(81, 16);
            this.lblPoliceman.TabIndex = 6;
            this.lblPoliceman.Text = "Policeman";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(32, 55);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 16);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Ticket",
            "Act"});
            this.cbType.Location = new System.Drawing.Point(148, 29);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblType.Location = new System.Drawing.Point(32, 30);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 16);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // cbFineIds
            // 
            this.cbFineIds.DataSource = this.finesBindingSource;
            this.cbFineIds.DisplayMember = "SerialNumber";
            this.cbFineIds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFineIds.FormattingEnabled = true;
            this.cbFineIds.Location = new System.Drawing.Point(109, 22);
            this.cbFineIds.Name = "cbFineIds";
            this.cbFineIds.Size = new System.Drawing.Size(121, 21);
            this.cbFineIds.TabIndex = 1;
            this.cbFineIds.ValueMember = "SerialNumber";
            this.cbFineIds.SelectedIndexChanged += new System.EventHandler(this.cbFineIds_SelectedIndexChanged);
            // 
            // finesBindingSource
            // 
            this.finesBindingSource.DataMember = "Fines";
            this.finesBindingSource.DataSource = this.databaseDataSet;
            // 
            // lblFineId
            // 
            this.lblFineId.AutoSize = true;
            this.lblFineId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFineId.Location = new System.Drawing.Point(25, 23);
            this.lblFineId.Name = "lblFineId";
            this.lblFineId.Size = new System.Drawing.Size(57, 16);
            this.lblFineId.TabIndex = 0;
            this.lblFineId.Text = "Fine ID";
            // 
            // tabPageV
            // 
            this.tabPageV.Controls.Add(this.gbCarData);
            this.tabPageV.Controls.Add(this.cbRegistryNumber);
            this.tabPageV.Controls.Add(this.lblRegNumber);
            this.tabPageV.Location = new System.Drawing.Point(4, 22);
            this.tabPageV.Name = "tabPageV";
            this.tabPageV.Size = new System.Drawing.Size(847, 485);
            this.tabPageV.TabIndex = 2;
            this.tabPageV.Text = "Vehicles";
            this.tabPageV.UseVisualStyleBackColor = true;
            // 
            // gbCarData
            // 
            this.gbCarData.Controls.Add(this.btnClearVehicle);
            this.gbCarData.Controls.Add(this.btnUpdateVehicle);
            this.gbCarData.Controls.Add(this.btnDeleteVehicle);
            this.gbCarData.Controls.Add(this.btnAddVehicle);
            this.gbCarData.Controls.Add(this.txtBoxOwnerDLN);
            this.gbCarData.Controls.Add(this.txtBoxRegNumber);
            this.gbCarData.Controls.Add(this.txtBoxRegDate);
            this.gbCarData.Controls.Add(this.txtBoxColor);
            this.gbCarData.Controls.Add(this.txtBoxWeight);
            this.gbCarData.Controls.Add(this.txtBoxSeats);
            this.gbCarData.Controls.Add(this.txtBoxType);
            this.gbCarData.Controls.Add(this.txtBoxModel);
            this.gbCarData.Controls.Add(this.txtBoxBrand);
            this.gbCarData.Controls.Add(this.txtBoxEngineNumber);
            this.gbCarData.Controls.Add(this.txtBoxFrameNumber);
            this.gbCarData.Controls.Add(this.lblOwnerDLN);
            this.gbCarData.Controls.Add(this.lblRegNumberForAdd);
            this.gbCarData.Controls.Add(this.lblRegistryDate);
            this.gbCarData.Controls.Add(this.lblColor);
            this.gbCarData.Controls.Add(this.lblWeight);
            this.gbCarData.Controls.Add(this.lblSeats);
            this.gbCarData.Controls.Add(this.lblTypeVehicle);
            this.gbCarData.Controls.Add(this.lblModel);
            this.gbCarData.Controls.Add(this.lblBrand);
            this.gbCarData.Controls.Add(this.lblEngine);
            this.gbCarData.Controls.Add(this.lblFrameNumber);
            this.gbCarData.Location = new System.Drawing.Point(43, 59);
            this.gbCarData.Name = "gbCarData";
            this.gbCarData.Size = new System.Drawing.Size(775, 409);
            this.gbCarData.TabIndex = 2;
            this.gbCarData.TabStop = false;
            this.gbCarData.Text = "Vehicle\'s Data";
            // 
            // btnClearVehicle
            // 
            this.btnClearVehicle.Location = new System.Drawing.Point(191, 380);
            this.btnClearVehicle.Name = "btnClearVehicle";
            this.btnClearVehicle.Size = new System.Drawing.Size(128, 23);
            this.btnClearVehicle.TabIndex = 35;
            this.btnClearVehicle.Text = "Clear";
            this.btnClearVehicle.UseVisualStyleBackColor = true;
            this.btnClearVehicle.Click += new System.EventHandler(this.btnClearVehicle_Click);
            // 
            // btnUpdateVehicle
            // 
            this.btnUpdateVehicle.Location = new System.Drawing.Point(491, 380);
            this.btnUpdateVehicle.Name = "btnUpdateVehicle";
            this.btnUpdateVehicle.Size = new System.Drawing.Size(128, 23);
            this.btnUpdateVehicle.TabIndex = 34;
            this.btnUpdateVehicle.Text = "Update";
            this.btnUpdateVehicle.UseVisualStyleBackColor = true;
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Location = new System.Drawing.Point(341, 380);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(128, 23);
            this.btnDeleteVehicle.TabIndex = 33;
            this.btnDeleteVehicle.Text = "Delete Vehicle";
            this.btnDeleteVehicle.UseVisualStyleBackColor = true;
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(641, 380);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(128, 23);
            this.btnAddVehicle.TabIndex = 32;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            // 
            // txtBoxOwnerDLN
            // 
            this.txtBoxOwnerDLN.Location = new System.Drawing.Point(371, 231);
            this.txtBoxOwnerDLN.Name = "txtBoxOwnerDLN";
            this.txtBoxOwnerDLN.Size = new System.Drawing.Size(270, 20);
            this.txtBoxOwnerDLN.TabIndex = 31;
            // 
            // txtBoxRegNumber
            // 
            this.txtBoxRegNumber.Location = new System.Drawing.Point(556, 170);
            this.txtBoxRegNumber.Name = "txtBoxRegNumber";
            this.txtBoxRegNumber.Size = new System.Drawing.Size(161, 20);
            this.txtBoxRegNumber.TabIndex = 30;
            // 
            // txtBoxRegDate
            // 
            this.txtBoxRegDate.Location = new System.Drawing.Point(556, 140);
            this.txtBoxRegDate.Name = "txtBoxRegDate";
            this.txtBoxRegDate.ReadOnly = true;
            this.txtBoxRegDate.Size = new System.Drawing.Size(161, 20);
            this.txtBoxRegDate.TabIndex = 29;
            // 
            // txtBoxColor
            // 
            this.txtBoxColor.Location = new System.Drawing.Point(556, 110);
            this.txtBoxColor.Name = "txtBoxColor";
            this.txtBoxColor.ReadOnly = true;
            this.txtBoxColor.Size = new System.Drawing.Size(161, 20);
            this.txtBoxColor.TabIndex = 28;
            // 
            // txtBoxWeight
            // 
            this.txtBoxWeight.Location = new System.Drawing.Point(556, 80);
            this.txtBoxWeight.Name = "txtBoxWeight";
            this.txtBoxWeight.ReadOnly = true;
            this.txtBoxWeight.Size = new System.Drawing.Size(161, 20);
            this.txtBoxWeight.TabIndex = 27;
            // 
            // txtBoxSeats
            // 
            this.txtBoxSeats.Location = new System.Drawing.Point(556, 50);
            this.txtBoxSeats.Name = "txtBoxSeats";
            this.txtBoxSeats.ReadOnly = true;
            this.txtBoxSeats.Size = new System.Drawing.Size(161, 20);
            this.txtBoxSeats.TabIndex = 26;
            // 
            // txtBoxType
            // 
            this.txtBoxType.Location = new System.Drawing.Point(153, 170);
            this.txtBoxType.Name = "txtBoxType";
            this.txtBoxType.ReadOnly = true;
            this.txtBoxType.Size = new System.Drawing.Size(161, 20);
            this.txtBoxType.TabIndex = 25;
            // 
            // txtBoxModel
            // 
            this.txtBoxModel.Location = new System.Drawing.Point(153, 140);
            this.txtBoxModel.Name = "txtBoxModel";
            this.txtBoxModel.ReadOnly = true;
            this.txtBoxModel.Size = new System.Drawing.Size(161, 20);
            this.txtBoxModel.TabIndex = 24;
            // 
            // txtBoxBrand
            // 
            this.txtBoxBrand.Location = new System.Drawing.Point(153, 110);
            this.txtBoxBrand.Name = "txtBoxBrand";
            this.txtBoxBrand.ReadOnly = true;
            this.txtBoxBrand.Size = new System.Drawing.Size(161, 20);
            this.txtBoxBrand.TabIndex = 23;
            // 
            // txtBoxEngineNumber
            // 
            this.txtBoxEngineNumber.Location = new System.Drawing.Point(153, 80);
            this.txtBoxEngineNumber.Name = "txtBoxEngineNumber";
            this.txtBoxEngineNumber.ReadOnly = true;
            this.txtBoxEngineNumber.Size = new System.Drawing.Size(161, 20);
            this.txtBoxEngineNumber.TabIndex = 22;
            // 
            // txtBoxFrameNumber
            // 
            this.txtBoxFrameNumber.Location = new System.Drawing.Point(153, 50);
            this.txtBoxFrameNumber.Name = "txtBoxFrameNumber";
            this.txtBoxFrameNumber.ReadOnly = true;
            this.txtBoxFrameNumber.Size = new System.Drawing.Size(161, 20);
            this.txtBoxFrameNumber.TabIndex = 21;
            // 
            // lblOwnerDLN
            // 
            this.lblOwnerDLN.AutoSize = true;
            this.lblOwnerDLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblOwnerDLN.Location = new System.Drawing.Point(108, 232);
            this.lblOwnerDLN.Name = "lblOwnerDLN";
            this.lblOwnerDLN.Size = new System.Drawing.Size(220, 16);
            this.lblOwnerDLN.TabIndex = 20;
            this.lblOwnerDLN.Text = "Owner Driving License Number";
            // 
            // lblRegNumberForAdd
            // 
            this.lblRegNumberForAdd.AutoSize = true;
            this.lblRegNumberForAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRegNumberForAdd.Location = new System.Drawing.Point(421, 170);
            this.lblRegNumberForAdd.Name = "lblRegNumberForAdd";
            this.lblRegNumberForAdd.Size = new System.Drawing.Size(124, 16);
            this.lblRegNumberForAdd.TabIndex = 19;
            this.lblRegNumberForAdd.Text = "Registry Number";
            // 
            // lblRegistryDate
            // 
            this.lblRegistryDate.AutoSize = true;
            this.lblRegistryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRegistryDate.Location = new System.Drawing.Point(421, 140);
            this.lblRegistryDate.Name = "lblRegistryDate";
            this.lblRegistryDate.Size = new System.Drawing.Size(103, 16);
            this.lblRegistryDate.TabIndex = 18;
            this.lblRegistryDate.Text = "Registry Date";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblColor.Location = new System.Drawing.Point(421, 110);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(45, 16);
            this.lblColor.TabIndex = 16;
            this.lblColor.Text = "Color";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblWeight.Location = new System.Drawing.Point(421, 80);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(56, 16);
            this.lblWeight.TabIndex = 14;
            this.lblWeight.Text = "Weight";
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSeats.Location = new System.Drawing.Point(421, 50);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(48, 16);
            this.lblSeats.TabIndex = 12;
            this.lblSeats.Text = "Seats";
            // 
            // lblTypeVehicle
            // 
            this.lblTypeVehicle.AutoSize = true;
            this.lblTypeVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTypeVehicle.Location = new System.Drawing.Point(37, 170);
            this.lblTypeVehicle.Name = "lblTypeVehicle";
            this.lblTypeVehicle.Size = new System.Drawing.Size(44, 16);
            this.lblTypeVehicle.TabIndex = 10;
            this.lblTypeVehicle.Text = "Type";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblModel.Location = new System.Drawing.Point(37, 140);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(51, 16);
            this.lblModel.TabIndex = 8;
            this.lblModel.Text = "Model";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBrand.Location = new System.Drawing.Point(37, 110);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(49, 16);
            this.lblBrand.TabIndex = 6;
            this.lblBrand.Text = "Brand";
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEngine.Location = new System.Drawing.Point(37, 80);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(114, 16);
            this.lblEngine.TabIndex = 4;
            this.lblEngine.Text = "Engine Number";
            // 
            // lblFrameNumber
            // 
            this.lblFrameNumber.AutoSize = true;
            this.lblFrameNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFrameNumber.Location = new System.Drawing.Point(37, 50);
            this.lblFrameNumber.Name = "lblFrameNumber";
            this.lblFrameNumber.Size = new System.Drawing.Size(110, 16);
            this.lblFrameNumber.TabIndex = 2;
            this.lblFrameNumber.Text = "Frame Number";
            // 
            // cbRegistryNumber
            // 
            this.cbRegistryNumber.DataSource = this.vehicleBindingSource;
            this.cbRegistryNumber.DisplayMember = "RegistryNumber";
            this.cbRegistryNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegistryNumber.FormattingEnabled = true;
            this.cbRegistryNumber.Location = new System.Drawing.Point(179, 19);
            this.cbRegistryNumber.Name = "cbRegistryNumber";
            this.cbRegistryNumber.Size = new System.Drawing.Size(129, 21);
            this.cbRegistryNumber.TabIndex = 1;
            this.cbRegistryNumber.ValueMember = "RegistryNumber";
            this.cbRegistryNumber.SelectedIndexChanged += new System.EventHandler(this.cbRegistryNumber_SelectedIndexChanged);
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "Vehicle";
            this.vehicleBindingSource.DataSource = this.databaseDataSet;
            // 
            // lblRegNumber
            // 
            this.lblRegNumber.AutoSize = true;
            this.lblRegNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRegNumber.Location = new System.Drawing.Point(31, 20);
            this.lblRegNumber.Name = "lblRegNumber";
            this.lblRegNumber.Size = new System.Drawing.Size(124, 16);
            this.lblRegNumber.TabIndex = 0;
            this.lblRegNumber.Text = "Registry Number";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(870, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // driversTableAdapter
            // 
            this.driversTableAdapter.ClearBeforeFill = true;
            // 
            // finesTableAdapter
            // 
            this.finesTableAdapter.ClearBeforeFill = true;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 569);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageDI.ResumeLayout(false);
            this.tabPageDI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.gbImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbLicense.ResumeLayout(false);
            this.gbLicense.PerformLayout();
            this.gbPerfonalData.ResumeLayout(false);
            this.gbPerfonalData.PerformLayout();
            this.tabPageF.ResumeLayout(false);
            this.tabPageF.PerformLayout();
            this.gbFine.ResumeLayout(false);
            this.gbFine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finesBindingSource)).EndInit();
            this.tabPageV.ResumeLayout(false);
            this.tabPageV.PerformLayout();
            this.gbCarData.ResumeLayout(false);
            this.gbCarData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDI;
        private System.Windows.Forms.TabPage tabPageF;
        private System.Windows.Forms.TabPage tabPageV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbPerfonalData;
        public System.Windows.Forms.Label lblGender;
        public System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtBoxId;
        public System.Windows.Forms.Label lblIdentityNumber;
        private System.Windows.Forms.TextBox txtBoxLastName;
        public System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtBoxMiddleName;
        public System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtBoxName;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxAddress;
        public System.Windows.Forms.Label blbAddress;
        private System.Windows.Forms.TextBox txtBoxCity;
        public System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtBoxCountry;
        public System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.GroupBox gbLicense;
        private System.Windows.Forms.CheckedListBox cbCategories;
        private System.Windows.Forms.ComboBox cbPointsLeft;
        public System.Windows.Forms.Label lblLicenseId;
        private System.Windows.Forms.TextBox txtBoxLicenseId;
        public System.Windows.Forms.Label lblCatecories;
        public System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.GroupBox gbImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbFine;
        private System.Windows.Forms.Label lblFineId;
        private System.Windows.Forms.TextBox txtBoxReason;
        private System.Windows.Forms.TextBox txtBoxPoliceman;
        private System.Windows.Forms.TextBox txtBoxDate;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.ComboBox cbPaid;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblPoliceman;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtBoxFineId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxOffenderDLN;
        private System.Windows.Forms.Label lblOffenderDLN;
        private System.Windows.Forms.GroupBox gbCarData;
        private System.Windows.Forms.ComboBox cbRegistryNumber;
        private System.Windows.Forms.Label lblRegNumber;
        private System.Windows.Forms.TextBox txtBoxOwnerDLN;
        private System.Windows.Forms.TextBox txtBoxRegNumber;
        private System.Windows.Forms.TextBox txtBoxRegDate;
        private System.Windows.Forms.TextBox txtBoxColor;
        private System.Windows.Forms.TextBox txtBoxWeight;
        private System.Windows.Forms.TextBox txtBoxSeats;
        private System.Windows.Forms.TextBox txtBoxType;
        private System.Windows.Forms.TextBox txtBoxModel;
        private System.Windows.Forms.TextBox txtBoxBrand;
        private System.Windows.Forms.TextBox txtBoxEngineNumber;
        private System.Windows.Forms.TextBox txtBoxFrameNumber;
        private System.Windows.Forms.Label lblOwnerDLN;
        private System.Windows.Forms.Label lblRegNumberForAdd;
        private System.Windows.Forms.Label lblRegistryDate;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblTypeVehicle;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.Label lblFrameNumber;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.ComboBox cbFineIds;
        private System.Windows.Forms.Label lblSearchDriver;
        private System.Windows.Forms.ComboBox cbSearchDriver;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private DatabaseDataSetTableAdapters.DriversTableAdapter driversTableAdapter;
        private System.Windows.Forms.BindingSource finesBindingSource;
        private DatabaseDataSetTableAdapters.FinesTableAdapter finesTableAdapter;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private DatabaseDataSetTableAdapters.VehicleTableAdapter vehicleTableAdapter;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox txtBoxBirthDate;
        public System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDell;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearFine;
        private System.Windows.Forms.Button btnUpdateFine;
        private System.Windows.Forms.Button btnDeleteFine;
        private System.Windows.Forms.Button btnAddFine;
        private System.Windows.Forms.Button btnClearVehicle;
        private System.Windows.Forms.Button btnUpdateVehicle;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private System.Windows.Forms.Button btnAddVehicle;

    }
}

