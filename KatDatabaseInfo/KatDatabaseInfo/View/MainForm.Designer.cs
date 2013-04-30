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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDI = new System.Windows.Forms.TabPage();
            this.gbImage = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbLicense = new System.Windows.Forms.GroupBox();
            this.cbCategories = new System.Windows.Forms.CheckedListBox();
            this.cbPointsLeft = new System.Windows.Forms.ComboBox();
            this.lblLicenseId = new System.Windows.Forms.Label();
            this.txtBoxLicenseId = new System.Windows.Forms.TextBox();
            this.lblCatecories = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.gbPerfonalData = new System.Windows.Forms.GroupBox();
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
            this.txtBoxBirthDate = new System.Windows.Forms.TextBox();
            this.txtBoxMiddleName = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblIdentityNumber = new System.Windows.Forms.Label();
            this.tabPageF = new System.Windows.Forms.TabPage();
            this.gbFine = new System.Windows.Forms.GroupBox();
            this.txtBoxFineId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxOffenderDLN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddFine = new System.Windows.Forms.Button();
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
            this.bcFineIds = new System.Windows.Forms.ComboBox();
            this.lblFineId = new System.Windows.Forms.Label();
            this.tabPageV = new System.Windows.Forms.TabPage();
            this.gbCarData = new System.Windows.Forms.GroupBox();
<<<<<<< HEAD
=======
            this.button1 = new System.Windows.Forms.Button();
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
>>>>>>> support methods for login/logout
            this.cbRegistryNumber = new System.Windows.Forms.ComboBox();
            this.lblRegNumber = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
<<<<<<< HEAD
=======
            this.btnAddDriver = new System.Windows.Forms.Button();
>>>>>>> support methods for login/logout
            this.tabControl.SuspendLayout();
            this.tabPageDI.SuspendLayout();
            this.gbImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbLicense.SuspendLayout();
            this.gbPerfonalData.SuspendLayout();
            this.tabPageF.SuspendLayout();
            this.gbFine.SuspendLayout();
            this.tabPageV.SuspendLayout();
            this.gbCarData.SuspendLayout();
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
            this.gbLicense.Controls.Add(this.cbCategories);
            this.gbLicense.Controls.Add(this.cbPointsLeft);
            this.gbLicense.Controls.Add(this.lblLicenseId);
            this.gbLicense.Controls.Add(this.txtBoxLicenseId);
            this.gbLicense.Controls.Add(this.lblCatecories);
            this.gbLicense.Controls.Add(this.lblPoints);
            this.gbLicense.Location = new System.Drawing.Point(6, 332);
            this.gbLicense.Name = "gbLicense";
            this.gbLicense.Size = new System.Drawing.Size(814, 121);
            this.gbLicense.TabIndex = 13;
            this.gbLicense.TabStop = false;
            this.gbLicense.Text = "License Data";
            // 
            // cbCategories
            // 
            this.cbCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.cbCategories.Location = new System.Drawing.Point(516, 19);
            this.cbCategories.MaximumSize = new System.Drawing.Size(400, 100);
            this.cbCategories.MultiColumn = true;
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbCategories.Size = new System.Drawing.Size(298, 90);
            this.cbCategories.TabIndex = 12;
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
            this.cbPointsLeft.Location = new System.Drawing.Point(131, 75);
            this.cbPointsLeft.Name = "cbPointsLeft";
            this.cbPointsLeft.Size = new System.Drawing.Size(82, 21);
            this.cbPointsLeft.TabIndex = 11;
            // 
            // lblLicenseId
            // 
            this.lblLicenseId.AutoSize = true;
            this.lblLicenseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseId.Location = new System.Drawing.Point(26, 47);
            this.lblLicenseId.Name = "lblLicenseId";
            this.lblLicenseId.Size = new System.Drawing.Size(81, 16);
            this.lblLicenseId.TabIndex = 6;
            this.lblLicenseId.Text = "License ID";
            // 
            // txtBoxLicenseId
            // 
            this.txtBoxLicenseId.Location = new System.Drawing.Point(131, 47);
            this.txtBoxLicenseId.Name = "txtBoxLicenseId";
            this.txtBoxLicenseId.ReadOnly = true;
            this.txtBoxLicenseId.Size = new System.Drawing.Size(167, 20);
            this.txtBoxLicenseId.TabIndex = 7;
            // 
            // lblCatecories
            // 
            this.lblCatecories.AutoSize = true;
            this.lblCatecories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatecories.Location = new System.Drawing.Point(360, 19);
            this.lblCatecories.Name = "lblCatecories";
            this.lblCatecories.Size = new System.Drawing.Size(84, 16);
            this.lblCatecories.TabIndex = 8;
            this.lblCatecories.Text = "Categories";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(27, 75);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(80, 16);
            this.lblPoints.TabIndex = 10;
            this.lblPoints.Text = "Poinst Left";
            // 
            // gbPerfonalData
            // 
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
            this.gbPerfonalData.Controls.Add(this.txtBoxBirthDate);
            this.gbPerfonalData.Controls.Add(this.txtBoxMiddleName);
            this.gbPerfonalData.Controls.Add(this.lblBirthDate);
            this.gbPerfonalData.Controls.Add(this.lblLastName);
            this.gbPerfonalData.Controls.Add(this.txtBoxId);
            this.gbPerfonalData.Controls.Add(this.txtBoxLastName);
            this.gbPerfonalData.Controls.Add(this.lblIdentityNumber);
            this.gbPerfonalData.Location = new System.Drawing.Point(344, 17);
            this.gbPerfonalData.Name = "gbPerfonalData";
            this.gbPerfonalData.Size = new System.Drawing.Size(476, 306);
            this.gbPerfonalData.TabIndex = 12;
            this.gbPerfonalData.TabStop = false;
            this.gbPerfonalData.Text = "Personal Data";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(127, 160);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(91, 21);
            this.cbGender.TabIndex = 18;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(127, 257);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.ReadOnly = true;
            this.txtBoxAddress.Size = new System.Drawing.Size(329, 20);
            this.txtBoxAddress.TabIndex = 17;
            // 
            // blbAddress
            // 
            this.blbAddress.AutoSize = true;
            this.blbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbAddress.Location = new System.Drawing.Point(22, 257);
            this.blbAddress.Name = "blbAddress";
            this.blbAddress.Size = new System.Drawing.Size(66, 16);
            this.blbAddress.TabIndex = 16;
            this.blbAddress.Text = "Address";
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(127, 231);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.ReadOnly = true;
            this.txtBoxCity.Size = new System.Drawing.Size(329, 20);
            this.txtBoxCity.TabIndex = 15;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(22, 231);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 16);
            this.lblCity.TabIndex = 14;
            this.lblCity.Text = "City";
            // 
            // txtBoxCountry
            // 
            this.txtBoxCountry.Location = new System.Drawing.Point(127, 206);
            this.txtBoxCountry.Name = "txtBoxCountry";
            this.txtBoxCountry.ReadOnly = true;
            this.txtBoxCountry.Size = new System.Drawing.Size(329, 20);
            this.txtBoxCountry.TabIndex = 13;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry.Location = new System.Drawing.Point(22, 206);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 16);
            this.lbCountry.TabIndex = 12;
            this.lbCountry.Text = "Country";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(22, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "First Name";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(127, 35);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.ReadOnly = true;
            this.txtBoxName.Size = new System.Drawing.Size(206, 20);
            this.txtBoxName.TabIndex = 1;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(22, 160);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(59, 16);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(22, 60);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(100, 16);
            this.lblMiddleName.TabIndex = 2;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // txtBoxBirthDate
            // 
            this.txtBoxBirthDate.Location = new System.Drawing.Point(127, 135);
            this.txtBoxBirthDate.Name = "txtBoxBirthDate";
            this.txtBoxBirthDate.ReadOnly = true;
            this.txtBoxBirthDate.Size = new System.Drawing.Size(206, 20);
            this.txtBoxBirthDate.TabIndex = 9;
            // 
            // txtBoxMiddleName
            // 
            this.txtBoxMiddleName.Location = new System.Drawing.Point(127, 60);
            this.txtBoxMiddleName.Name = "txtBoxMiddleName";
            this.txtBoxMiddleName.ReadOnly = true;
            this.txtBoxMiddleName.Size = new System.Drawing.Size(206, 20);
            this.txtBoxMiddleName.TabIndex = 3;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(22, 135);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(76, 16);
            this.lblBirthDate.TabIndex = 8;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(22, 85);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 16);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(127, 110);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.Size = new System.Drawing.Size(206, 20);
            this.txtBoxId.TabIndex = 7;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(127, 85);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.ReadOnly = true;
            this.txtBoxLastName.Size = new System.Drawing.Size(206, 20);
            this.txtBoxLastName.TabIndex = 5;
            // 
            // lblIdentityNumber
            // 
            this.lblIdentityNumber.AutoSize = true;
            this.lblIdentityNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentityNumber.Location = new System.Drawing.Point(22, 110);
            this.lblIdentityNumber.Name = "lblIdentityNumber";
            this.lblIdentityNumber.Size = new System.Drawing.Size(23, 16);
            this.lblIdentityNumber.TabIndex = 6;
            this.lblIdentityNumber.Text = "ID";
            // 
            // tabPageF
            // 
            this.tabPageF.Controls.Add(this.gbFine);
            this.tabPageF.Controls.Add(this.bcFineIds);
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
            this.gbFine.Controls.Add(this.txtBoxFineId);
            this.gbFine.Controls.Add(this.label2);
            this.gbFine.Controls.Add(this.txtBoxOffenderDLN);
            this.gbFine.Controls.Add(this.label1);
            this.gbFine.Controls.Add(this.btnAddFine);
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
            this.gbFine.Text = "Fine Data";
            // 
            // txtBoxFineId
            // 
            this.txtBoxFineId.Location = new System.Drawing.Point(148, 154);
            this.txtBoxFineId.Name = "txtBoxFineId";
<<<<<<< HEAD
=======
            this.txtBoxFineId.ReadOnly = true;
>>>>>>> support methods for login/logout
            this.txtBoxFineId.Size = new System.Drawing.Size(237, 20);
            this.txtBoxFineId.TabIndex = 19;
            this.txtBoxFineId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(32, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fine ID";
            this.label2.Visible = false;
            // 
            // txtBoxOffenderDLN
            // 
            this.txtBoxOffenderDLN.Location = new System.Drawing.Point(148, 129);
            this.txtBoxOffenderDLN.Name = "txtBoxOffenderDLN";
<<<<<<< HEAD
=======
            this.txtBoxOffenderDLN.ReadOnly = true;
>>>>>>> support methods for login/logout
            this.txtBoxOffenderDLN.Size = new System.Drawing.Size(237, 20);
            this.txtBoxOffenderDLN.TabIndex = 17;
            this.txtBoxOffenderDLN.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Offender DLN";
            this.label1.Visible = false;
            // 
            // btnAddFine
            // 
            this.btnAddFine.Location = new System.Drawing.Point(609, 369);
            this.btnAddFine.Name = "btnAddFine";
            this.btnAddFine.Size = new System.Drawing.Size(184, 31);
            this.btnAddFine.TabIndex = 15;
            this.btnAddFine.Text = "Add Fine";
            this.btnAddFine.UseVisualStyleBackColor = true;
            // 
            // txtBoxReason
            // 
            this.txtBoxReason.Location = new System.Drawing.Point(148, 202);
            this.txtBoxReason.Multiline = true;
            this.txtBoxReason.Name = "txtBoxReason";
<<<<<<< HEAD
=======
            this.txtBoxReason.ReadOnly = true;
>>>>>>> support methods for login/logout
            this.txtBoxReason.Size = new System.Drawing.Size(579, 161);
            this.txtBoxReason.TabIndex = 14;
            // 
            // txtBoxPoliceman
            // 
            this.txtBoxPoliceman.Location = new System.Drawing.Point(148, 79);
            this.txtBoxPoliceman.Name = "txtBoxPoliceman";
<<<<<<< HEAD
=======
            this.txtBoxPoliceman.ReadOnly = true;
>>>>>>> support methods for login/logout
            this.txtBoxPoliceman.Size = new System.Drawing.Size(237, 20);
            this.txtBoxPoliceman.TabIndex = 13;
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Location = new System.Drawing.Point(148, 54);
            this.txtBoxDate.Name = "txtBoxDate";
<<<<<<< HEAD
=======
            this.txtBoxDate.ReadOnly = true;
>>>>>>> support methods for login/logout
            this.txtBoxDate.Size = new System.Drawing.Size(122, 20);
            this.txtBoxDate.TabIndex = 12;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblReason.Location = new System.Drawing.Point(32, 203);
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
<<<<<<< HEAD
=======
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
>>>>>>> support methods for login/logout
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
            // bcFineIds
            // 
<<<<<<< HEAD
=======
            this.bcFineIds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
>>>>>>> support methods for login/logout
            this.bcFineIds.FormattingEnabled = true;
            this.bcFineIds.Location = new System.Drawing.Point(109, 22);
            this.bcFineIds.Name = "bcFineIds";
            this.bcFineIds.Size = new System.Drawing.Size(121, 21);
            this.bcFineIds.TabIndex = 1;
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
<<<<<<< HEAD
            this.gbCarData.Location = new System.Drawing.Point(43, 59);
            this.gbCarData.Name = "gbCarData";
            this.gbCarData.Size = new System.Drawing.Size(747, 385);
            this.gbCarData.TabIndex = 2;
            this.gbCarData.TabStop = false;
            this.gbCarData.Text = "groupBox1";
            // 
            // cbRegistryNumber
            // 
=======
            this.gbCarData.Controls.Add(this.button1);
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
            this.gbCarData.Text = "Vehicle Data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 31);
            this.button1.TabIndex = 32;
            this.button1.Text = "Add Vehicle";
            this.button1.UseVisualStyleBackColor = true;
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
            this.cbRegistryNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
>>>>>>> support methods for login/logout
            this.cbRegistryNumber.FormattingEnabled = true;
            this.cbRegistryNumber.Location = new System.Drawing.Point(179, 19);
            this.cbRegistryNumber.Name = "cbRegistryNumber";
            this.cbRegistryNumber.Size = new System.Drawing.Size(129, 21);
            this.cbRegistryNumber.TabIndex = 1;
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
<<<<<<< HEAD
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
=======
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(701, 459);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(128, 23);
            this.btnAddDriver.TabIndex = 15;
            this.btnAddDriver.Text = "AddDriver";
            this.btnAddDriver.UseVisualStyleBackColor = true;
>>>>>>> support methods for login/logout
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
            this.tabControl.ResumeLayout(false);
            this.tabPageDI.ResumeLayout(false);
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
            this.tabPageV.ResumeLayout(false);
            this.tabPageV.PerformLayout();
            this.gbCarData.ResumeLayout(false);
            this.gbCarData.PerformLayout();
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
        private System.Windows.Forms.TextBox txtBoxBirthDate;
        public System.Windows.Forms.Label lblBirthDate;
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
        private System.Windows.Forms.ComboBox bcFineIds;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddFine;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnAddDriver;
    }
}

