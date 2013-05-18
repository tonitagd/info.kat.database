using KatDatabaseInfo;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDI = new System.Windows.Forms.TabPage();
            this.btnPrintDriver = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDell = new System.Windows.Forms.Button();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.gbImage = new System.Windows.Forms.GroupBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbLicense = new System.Windows.Forms.GroupBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.cbPointsLeft = new System.Windows.Forms.ComboBox();
            this.lblLicenseId = new System.Windows.Forms.Label();
            this.txtBoxLicenseId = new System.Windows.Forms.TextBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.CheckedListBox();
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
            this.btnPrintFine = new System.Windows.Forms.Button();
            this.btnClearFine = new System.Windows.Forms.Button();
            this.btnShowAllFines = new System.Windows.Forms.Button();
            this.btnUpdateFine = new System.Windows.Forms.Button();
            this.gbFine = new System.Windows.Forms.GroupBox();
            this.txtBoxPlace = new System.Windows.Forms.TextBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.txtBoxTime = new System.Windows.Forms.TextBox();
            this.lblHour = new System.Windows.Forms.Label();
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
            this.btnDeleteFine = new System.Windows.Forms.Button();
            this.btnAddFine = new System.Windows.Forms.Button();
            this.cbFineIds = new System.Windows.Forms.ComboBox();
            this.finesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new DatabaseDataSet();
            this.lblFineId = new System.Windows.Forms.Label();
            this.tabPageV = new System.Windows.Forms.TabPage();
            this.btnPrintVehicle = new System.Windows.Forms.Button();
            this.btnClearVehicle = new System.Windows.Forms.Button();
            this.btnShowAllVehicles = new System.Windows.Forms.Button();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.btnUpdateVehicle = new System.Windows.Forms.Button();
            this.gbCarData = new System.Windows.Forms.GroupBox();
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
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.lblRegNumber = new System.Windows.Forms.Label();
            this.cbSearchDriver = new System.Windows.Forms.ComboBox();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSearchDriver = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversTableAdapter = new DatabaseDataSetTableAdapters.DriversTableAdapter();
            this.finesTableAdapter = new DatabaseDataSetTableAdapters.FinesTableAdapter();
            this.vehicleTableAdapter = new DatabaseDataSetTableAdapters.VehicleTableAdapter();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ttClearFine = new System.Windows.Forms.ToolTip(this.components);
            this.ttClearDriver = new System.Windows.Forms.ToolTip(this.components);
            this.ttAddDriver = new System.Windows.Forms.ToolTip(this.components);
            this.ttDeleteDriver = new System.Windows.Forms.ToolTip(this.components);
            this.ttSaveDriver = new System.Windows.Forms.ToolTip(this.components);
            this.ttAddFine = new System.Windows.Forms.ToolTip(this.components);
            this.ttDeleteFine = new System.Windows.Forms.ToolTip(this.components);
            this.ttSaveFine = new System.Windows.Forms.ToolTip(this.components);
            this.ttClearVehicle = new System.Windows.Forms.ToolTip(this.components);
            this.ttAddVehicle = new System.Windows.Forms.ToolTip(this.components);
            this.ttDeleteVehicle = new System.Windows.Forms.ToolTip(this.components);
            this.ttSaveVehicle = new System.Windows.Forms.ToolTip(this.components);
            this.ttOffenderDLN = new System.Windows.Forms.ToolTip(this.components);
            this.ttOwnerDLN = new System.Windows.Forms.ToolTip(this.components);
            this.ttPrintDriver = new System.Windows.Forms.ToolTip(this.components);
            this.ttPrintFine = new System.Windows.Forms.ToolTip(this.components);
            this.ttPrintVehicle = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl.SuspendLayout();
            this.tabPageDI.SuspendLayout();
            this.gbImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbLicense.SuspendLayout();
            this.gbPerfonalData.SuspendLayout();
            this.tabPageF.SuspendLayout();
            this.gbFine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.tabPageV.SuspendLayout();
            this.gbCarData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.tabPageDI);
            this.tabControl.Controls.Add(this.tabPageF);
            this.tabControl.Controls.Add(this.tabPageV);
            this.tabControl.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(13, 126);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(855, 415);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageDI
            // 
            this.tabPageDI.Controls.Add(this.btnPrintDriver);
            this.tabPageDI.Controls.Add(this.btnClear);
            this.tabPageDI.Controls.Add(this.btnUpdate);
            this.tabPageDI.Controls.Add(this.btnDell);
            this.tabPageDI.Controls.Add(this.btnAddDriver);
            this.tabPageDI.Controls.Add(this.gbImage);
            this.tabPageDI.Controls.Add(this.gbLicense);
            this.tabPageDI.Controls.Add(this.gbPerfonalData);
            this.tabPageDI.Location = new System.Drawing.Point(29, 4);
            this.tabPageDI.Name = "tabPageDI";
            this.tabPageDI.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDI.Size = new System.Drawing.Size(822, 407);
            this.tabPageDI.TabIndex = 0;
            this.tabPageDI.Text = "Лични данни";
            this.tabPageDI.UseVisualStyleBackColor = true;
            // 
            // btnPrintDriver
            // 
            this.btnPrintDriver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrintDriver.BackgroundImage")));
            this.btnPrintDriver.Location = new System.Drawing.Point(738, 334);
            this.btnPrintDriver.Name = "btnPrintDriver";
            this.btnPrintDriver.Size = new System.Drawing.Size(70, 70);
            this.btnPrintDriver.TabIndex = 21;
            this.btnPrintDriver.UseVisualStyleBackColor = true;
            this.btnPrintDriver.Click += new System.EventHandler(this.btnPrintDriver_Click);
            this.btnPrintDriver.MouseHover += new System.EventHandler(this.btnPrintDriver_MouseHover);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.Location = new System.Drawing.Point(738, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 70);
            this.btnClear.TabIndex = 20;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseHover += new System.EventHandler(this.btnClear_MouseHover);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.Location = new System.Drawing.Point(738, 254);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 70);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseHover += new System.EventHandler(this.btnUpdate_MouseHover);
            // 
            // btnDell
            // 
            this.btnDell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDell.BackgroundImage")));
            this.btnDell.Location = new System.Drawing.Point(738, 174);
            this.btnDell.Name = "btnDell";
            this.btnDell.Size = new System.Drawing.Size(70, 70);
            this.btnDell.TabIndex = 18;
            this.btnDell.UseVisualStyleBackColor = true;
            this.btnDell.Click += new System.EventHandler(this.btnDell_Click);
            this.btnDell.MouseHover += new System.EventHandler(this.btnDell_MouseHover);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddDriver.BackgroundImage")));
            this.btnAddDriver.Location = new System.Drawing.Point(738, 94);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(70, 70);
            this.btnAddDriver.TabIndex = 15;
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            this.btnAddDriver.MouseHover += new System.EventHandler(this.btnAddDriver_MouseHover);
            // 
            // gbImage
            // 
            this.gbImage.Controls.Add(this.btnUpload);
            this.gbImage.Controls.Add(this.pictureBox1);
            this.gbImage.Location = new System.Drawing.Point(20, 9);
            this.gbImage.Name = "gbImage";
            this.gbImage.Size = new System.Drawing.Size(202, 264);
            this.gbImage.TabIndex = 14;
            this.gbImage.TabStop = false;
            this.gbImage.Text = "Снимка";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(47, 230);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(106, 27);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Качи снимка";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.gbLicense.Controls.Add(this.cbCategories);
            this.gbLicense.Controls.Add(this.lblCatecories);
            this.gbLicense.Location = new System.Drawing.Point(20, 273);
            this.gbLicense.Name = "gbLicense";
            this.gbLicense.Size = new System.Drawing.Size(706, 130);
            this.gbLicense.TabIndex = 13;
            this.gbLicense.TabStop = false;
            this.gbLicense.Text = "Шофьорски данни";
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Цивилен",
            "Админ"});
            this.cbRole.Location = new System.Drawing.Point(121, 91);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(90, 24);
            this.cbRole.TabIndex = 12;
            // 
            // cbPointsLeft
            // 
            this.cbPointsLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPointsLeft.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbPointsLeft.Location = new System.Drawing.Point(121, 61);
            this.cbPointsLeft.Name = "cbPointsLeft";
            this.cbPointsLeft.Size = new System.Drawing.Size(90, 24);
            this.cbPointsLeft.TabIndex = 11;
            // 
            // lblLicenseId
            // 
            this.lblLicenseId.AutoSize = true;
            this.lblLicenseId.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseId.Location = new System.Drawing.Point(7, 31);
            this.lblLicenseId.Name = "lblLicenseId";
            this.lblLicenseId.Size = new System.Drawing.Size(111, 16);
            this.lblLicenseId.TabIndex = 6;
            this.lblLicenseId.Text = "Документ №:";
            // 
            // txtBoxLicenseId
            // 
            this.txtBoxLicenseId.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLicenseId.Location = new System.Drawing.Point(121, 28);
            this.txtBoxLicenseId.Name = "txtBoxLicenseId";
            this.txtBoxLicenseId.ReadOnly = true;
            this.txtBoxLicenseId.Size = new System.Drawing.Size(90, 23);
            this.txtBoxLicenseId.TabIndex = 7;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(57, 65);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(61, 16);
            this.lblPoints.TabIndex = 10;
            this.lblPoints.Text = "Точки:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(70, 94);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(51, 16);
            this.lblRole.TabIndex = 8;
            this.lblRole.Text = "Роля:";
            // 
            // cbCategories
            // 
            this.cbCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbCategories.CheckOnClick = true;
            this.cbCategories.ColumnWidth = 80;
            this.cbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbCategories.Location = new System.Drawing.Point(396, 35);
            this.cbCategories.MaximumSize = new System.Drawing.Size(400, 100);
            this.cbCategories.MultiColumn = true;
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbCategories.Size = new System.Drawing.Size(244, 68);
            this.cbCategories.TabIndex = 12;
            // 
            // lblCatecories
            // 
            this.lblCatecories.AutoSize = true;
            this.lblCatecories.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatecories.Location = new System.Drawing.Point(393, 11);
            this.lblCatecories.Name = "lblCatecories";
            this.lblCatecories.Size = new System.Drawing.Size(86, 16);
            this.lblCatecories.TabIndex = 8;
            this.lblCatecories.Text = "Категории";
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
            this.gbPerfonalData.Location = new System.Drawing.Point(263, 9);
            this.gbPerfonalData.Name = "gbPerfonalData";
            this.gbPerfonalData.Size = new System.Drawing.Size(463, 264);
            this.gbPerfonalData.TabIndex = 12;
            this.gbPerfonalData.TabStop = false;
            this.gbPerfonalData.Text = "Лични данни";
            // 
            // txtBoxBirthDate
            // 
            this.txtBoxBirthDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBirthDate.Location = new System.Drawing.Point(153, 136);
            this.txtBoxBirthDate.Name = "txtBoxBirthDate";
            this.txtBoxBirthDate.ReadOnly = true;
            this.txtBoxBirthDate.Size = new System.Drawing.Size(91, 23);
            this.txtBoxBirthDate.TabIndex = 20;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(3, 138);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(148, 16);
            this.lblBirthDate.TabIndex = 19;
            this.lblBirthDate.Text = "Дата на раждане:";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(342, 136);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(91, 24);
            this.cbGender.TabIndex = 18;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddress.Location = new System.Drawing.Point(153, 222);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.ReadOnly = true;
            this.txtBoxAddress.Size = new System.Drawing.Size(280, 23);
            this.txtBoxAddress.TabIndex = 17;
            // 
            // blbAddress
            // 
            this.blbAddress.AutoSize = true;
            this.blbAddress.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbAddress.Location = new System.Drawing.Point(87, 222);
            this.blbAddress.Name = "blbAddress";
            this.blbAddress.Size = new System.Drawing.Size(61, 16);
            this.blbAddress.TabIndex = 16;
            this.blbAddress.Text = "Адрес:";
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCity.Location = new System.Drawing.Point(153, 194);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.ReadOnly = true;
            this.txtBoxCity.Size = new System.Drawing.Size(280, 23);
            this.txtBoxCity.TabIndex = 15;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(98, 194);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(50, 16);
            this.lblCity.TabIndex = 14;
            this.lblCity.Text = "Град:";
            // 
            // txtBoxCountry
            // 
            this.txtBoxCountry.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCountry.Location = new System.Drawing.Point(153, 167);
            this.txtBoxCountry.Name = "txtBoxCountry";
            this.txtBoxCountry.ReadOnly = true;
            this.txtBoxCountry.Size = new System.Drawing.Size(280, 23);
            this.txtBoxCountry.TabIndex = 13;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry.Location = new System.Drawing.Point(67, 168);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(83, 16);
            this.lbCountry.TabIndex = 12;
            this.lbCountry.Text = "Държава:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(109, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Име:";
            this.lblName.UseWaitCursor = true;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.Location = new System.Drawing.Point(153, 36);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.ReadOnly = true;
            this.txtBoxName.Size = new System.Drawing.Size(197, 23);
            this.txtBoxName.TabIndex = 1;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(293, 141);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(43, 16);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Пол:";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(74, 61);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(79, 16);
            this.lblMiddleName.TabIndex = 2;
            this.lblMiddleName.Text = "Презиме:";
            // 
            // txtBoxMiddleName
            // 
            this.txtBoxMiddleName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMiddleName.Location = new System.Drawing.Point(153, 61);
            this.txtBoxMiddleName.Name = "txtBoxMiddleName";
            this.txtBoxMiddleName.ReadOnly = true;
            this.txtBoxMiddleName.Size = new System.Drawing.Size(197, 23);
            this.txtBoxMiddleName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(70, 86);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 16);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Фамилия:";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxId.Location = new System.Drawing.Point(153, 111);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.Size = new System.Drawing.Size(197, 23);
            this.txtBoxId.TabIndex = 7;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastName.Location = new System.Drawing.Point(153, 86);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.ReadOnly = true;
            this.txtBoxLastName.Size = new System.Drawing.Size(197, 23);
            this.txtBoxLastName.TabIndex = 5;
            // 
            // lblIdentityNumber
            // 
            this.lblIdentityNumber.AutoSize = true;
            this.lblIdentityNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentityNumber.Location = new System.Drawing.Point(109, 111);
            this.lblIdentityNumber.Name = "lblIdentityNumber";
            this.lblIdentityNumber.Size = new System.Drawing.Size(42, 16);
            this.lblIdentityNumber.TabIndex = 6;
            this.lblIdentityNumber.Text = "ЕГН:";
            // 
            // tabPageF
            // 
            this.tabPageF.Controls.Add(this.btnPrintFine);
            this.tabPageF.Controls.Add(this.btnClearFine);
            this.tabPageF.Controls.Add(this.btnShowAllFines);
            this.tabPageF.Controls.Add(this.btnUpdateFine);
            this.tabPageF.Controls.Add(this.gbFine);
            this.tabPageF.Controls.Add(this.btnDeleteFine);
            this.tabPageF.Controls.Add(this.btnAddFine);
            this.tabPageF.Controls.Add(this.cbFineIds);
            this.tabPageF.Controls.Add(this.lblFineId);
            this.tabPageF.Location = new System.Drawing.Point(29, 4);
            this.tabPageF.Name = "tabPageF";
            this.tabPageF.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageF.Size = new System.Drawing.Size(822, 407);
            this.tabPageF.TabIndex = 1;
            this.tabPageF.Text = "Глоби";
            this.tabPageF.UseVisualStyleBackColor = true;
            // 
            // btnPrintFine
            // 
            this.btnPrintFine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrintFine.BackgroundImage")));
            this.btnPrintFine.Location = new System.Drawing.Point(738, 334);
            this.btnPrintFine.Name = "btnPrintFine";
            this.btnPrintFine.Size = new System.Drawing.Size(70, 70);
            this.btnPrintFine.TabIndex = 26;
            this.btnPrintFine.UseVisualStyleBackColor = true;
            this.btnPrintFine.Click += new System.EventHandler(this.btnPrintFine_Click);
            this.btnPrintFine.MouseHover += new System.EventHandler(this.btnPrintFine_MouseHover);
            // 
            // btnClearFine
            // 
            this.btnClearFine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearFine.BackgroundImage")));
            this.btnClearFine.Location = new System.Drawing.Point(738, 14);
            this.btnClearFine.Name = "btnClearFine";
            this.btnClearFine.Size = new System.Drawing.Size(70, 70);
            this.btnClearFine.TabIndex = 25;
            this.btnClearFine.UseVisualStyleBackColor = true;
            this.btnClearFine.Click += new System.EventHandler(this.btnClearFine_Click);
            this.btnClearFine.MouseHover += new System.EventHandler(this.btnClearFine_MouseHover);
            // 
            // btnShowAllFines
            // 
            this.btnShowAllFines.Location = new System.Drawing.Point(269, 20);
            this.btnShowAllFines.Name = "btnShowAllFines";
            this.btnShowAllFines.Size = new System.Drawing.Size(117, 24);
            this.btnShowAllFines.TabIndex = 4;
            this.btnShowAllFines.Text = "Покажи всички";
            this.btnShowAllFines.UseVisualStyleBackColor = true;
            this.btnShowAllFines.Click += new System.EventHandler(this.btnShowAllFines_Click);
            // 
            // btnUpdateFine
            // 
            this.btnUpdateFine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateFine.BackgroundImage")));
            this.btnUpdateFine.Location = new System.Drawing.Point(738, 254);
            this.btnUpdateFine.Name = "btnUpdateFine";
            this.btnUpdateFine.Size = new System.Drawing.Size(70, 70);
            this.btnUpdateFine.TabIndex = 24;
            this.btnUpdateFine.UseVisualStyleBackColor = true;
            this.btnUpdateFine.Click += new System.EventHandler(this.btnUpdateFine_Click);
            this.btnUpdateFine.MouseHover += new System.EventHandler(this.btnUpdateFine_MouseHover);
            // 
            // gbFine
            // 
            this.gbFine.Controls.Add(this.txtBoxPlace);
            this.gbFine.Controls.Add(this.lblPlace);
            this.gbFine.Controls.Add(this.txtBoxTime);
            this.gbFine.Controls.Add(this.lblHour);
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
            this.gbFine.Location = new System.Drawing.Point(28, 50);
            this.gbFine.Name = "gbFine";
            this.gbFine.Size = new System.Drawing.Size(688, 342);
            this.gbFine.TabIndex = 2;
            this.gbFine.TabStop = false;
            this.gbFine.Text = "Информация за нарушение";
            // 
            // txtBoxPlace
            // 
            this.txtBoxPlace.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.txtBoxPlace.Location = new System.Drawing.Point(441, 90);
            this.txtBoxPlace.Name = "txtBoxPlace";
            this.txtBoxPlace.ReadOnly = true;
            this.txtBoxPlace.Size = new System.Drawing.Size(237, 23);
            this.txtBoxPlace.TabIndex = 25;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPlace.Location = new System.Drawing.Point(377, 90);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(62, 16);
            this.lblPlace.TabIndex = 24;
            this.lblPlace.Text = "Място:";
            // 
            // txtBoxTime
            // 
            this.txtBoxTime.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.txtBoxTime.Location = new System.Drawing.Point(441, 60);
            this.txtBoxTime.Name = "txtBoxTime";
            this.txtBoxTime.ReadOnly = true;
            this.txtBoxTime.Size = new System.Drawing.Size(122, 23);
            this.txtBoxTime.TabIndex = 23;
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHour.Location = new System.Drawing.Point(396, 60);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(43, 16);
            this.lblHour.TabIndex = 22;
            this.lblHour.Text = "Час:";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.txtBoxPrice.Location = new System.Drawing.Point(135, 90);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.ReadOnly = true;
            this.txtBoxPrice.Size = new System.Drawing.Size(151, 23);
            this.txtBoxPrice.TabIndex = 21;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(7, 90);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(127, 16);
            this.lblPrice.TabIndex = 20;
            this.lblPrice.Text = "Дължима сума:";
            // 
            // txtBoxFineId
            // 
            this.txtBoxFineId.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.txtBoxFineId.Location = new System.Drawing.Point(135, 120);
            this.txtBoxFineId.Name = "txtBoxFineId";
            this.txtBoxFineId.ReadOnly = true;
            this.txtBoxFineId.Size = new System.Drawing.Size(151, 23);
            this.txtBoxFineId.TabIndex = 19;
            this.txtBoxFineId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(52, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Глоба №:";
            this.label2.Visible = false;
            // 
            // txtBoxOffenderDLN
            // 
            this.txtBoxOffenderDLN.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.txtBoxOffenderDLN.Location = new System.Drawing.Point(135, 150);
            this.txtBoxOffenderDLN.Name = "txtBoxOffenderDLN";
            this.txtBoxOffenderDLN.ReadOnly = true;
            this.txtBoxOffenderDLN.Size = new System.Drawing.Size(151, 23);
            this.txtBoxOffenderDLN.TabIndex = 17;
            // 
            // lblOffenderDLN
            // 
            this.lblOffenderDLN.AutoSize = true;
            this.lblOffenderDLN.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblOffenderDLN.Location = new System.Drawing.Point(34, 150);
            this.lblOffenderDLN.Name = "lblOffenderDLN";
            this.lblOffenderDLN.Size = new System.Drawing.Size(99, 16);
            this.lblOffenderDLN.TabIndex = 16;
            this.lblOffenderDLN.Text = "Нарушител:";
            this.lblOffenderDLN.MouseHover += new System.EventHandler(this.lblOffenderDLN_MouseHover);
            // 
            // txtBoxReason
            // 
            this.txtBoxReason.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.txtBoxReason.Location = new System.Drawing.Point(135, 180);
            this.txtBoxReason.Multiline = true;
            this.txtBoxReason.Name = "txtBoxReason";
            this.txtBoxReason.ReadOnly = true;
            this.txtBoxReason.Size = new System.Drawing.Size(489, 142);
            this.txtBoxReason.TabIndex = 14;
            // 
            // txtBoxPoliceman
            // 
            this.txtBoxPoliceman.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.txtBoxPoliceman.Location = new System.Drawing.Point(441, 120);
            this.txtBoxPoliceman.Name = "txtBoxPoliceman";
            this.txtBoxPoliceman.ReadOnly = true;
            this.txtBoxPoliceman.Size = new System.Drawing.Size(237, 23);
            this.txtBoxPoliceman.TabIndex = 13;
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.txtBoxDate.Location = new System.Drawing.Point(441, 30);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.ReadOnly = true;
            this.txtBoxDate.Size = new System.Drawing.Size(122, 23);
            this.txtBoxDate.TabIndex = 12;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblReason.Location = new System.Drawing.Point(53, 180);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(79, 16);
            this.lblReason.TabIndex = 10;
            this.lblReason.Text = "Причина:";
            // 
            // cbPaid
            // 
            this.cbPaid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaid.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.cbPaid.FormattingEnabled = true;
            this.cbPaid.Items.AddRange(new object[] {
            "Не",
            "Да"});
            this.cbPaid.Location = new System.Drawing.Point(135, 60);
            this.cbPaid.Name = "cbPaid";
            this.cbPaid.Size = new System.Drawing.Size(65, 24);
            this.cbPaid.TabIndex = 9;
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPaid.Location = new System.Drawing.Point(64, 60);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(69, 16);
            this.lblPaid.TabIndex = 8;
            this.lblPaid.Text = "Платен:";
            // 
            // lblPoliceman
            // 
            this.lblPoliceman.AutoSize = true;
            this.lblPoliceman.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPoliceman.Location = new System.Drawing.Point(336, 120);
            this.lblPoliceman.Name = "lblPoliceman";
            this.lblPoliceman.Size = new System.Drawing.Size(104, 16);
            this.lblPoliceman.TabIndex = 6;
            this.lblPoliceman.Text = "Съставител:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(388, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 16);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Дата:";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Фиш\t",
            "Акт"});
            this.cbType.Location = new System.Drawing.Point(135, 30);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(65, 24);
            this.cbType.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblType.Location = new System.Drawing.Point(90, 30);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 16);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Тип:";
            // 
            // btnDeleteFine
            // 
            this.btnDeleteFine.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteFine.Image")));
            this.btnDeleteFine.Location = new System.Drawing.Point(738, 174);
            this.btnDeleteFine.Name = "btnDeleteFine";
            this.btnDeleteFine.Size = new System.Drawing.Size(70, 70);
            this.btnDeleteFine.TabIndex = 23;
            this.btnDeleteFine.UseVisualStyleBackColor = true;
            this.btnDeleteFine.Click += new System.EventHandler(this.btnDeleteFine_Click);
            this.btnDeleteFine.MouseHover += new System.EventHandler(this.btnDeleteFine_MouseHover);
            // 
            // btnAddFine
            // 
            this.btnAddFine.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFine.Image")));
            this.btnAddFine.Location = new System.Drawing.Point(738, 94);
            this.btnAddFine.Name = "btnAddFine";
            this.btnAddFine.Size = new System.Drawing.Size(70, 70);
            this.btnAddFine.TabIndex = 22;
            this.btnAddFine.UseVisualStyleBackColor = true;
            this.btnAddFine.Click += new System.EventHandler(this.btnAddFine_Click);
            this.btnAddFine.MouseHover += new System.EventHandler(this.btnAddFine_MouseHover);
            // 
            // cbFineIds
            // 
            this.cbFineIds.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbFineIds.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFineIds.DataSource = this.finesBindingSource;
            this.cbFineIds.DisplayMember = "SerialNumber";
            this.cbFineIds.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.cbFineIds.FormattingEnabled = true;
            this.cbFineIds.Location = new System.Drawing.Point(120, 20);
            this.cbFineIds.Name = "cbFineIds";
            this.cbFineIds.Size = new System.Drawing.Size(121, 24);
            this.cbFineIds.TabIndex = 1;
            this.cbFineIds.ValueMember = "SerialNumber";
            this.cbFineIds.SelectedIndexChanged += new System.EventHandler(this.cbFineIds_SelectedIndexChanged);
            // 
            // finesBindingSource
            // 
            this.finesBindingSource.DataMember = "Fines";
            this.finesBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblFineId
            // 
            this.lblFineId.AutoSize = true;
            this.lblFineId.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFineId.Location = new System.Drawing.Point(36, 21);
            this.lblFineId.Name = "lblFineId";
            this.lblFineId.Size = new System.Drawing.Size(81, 16);
            this.lblFineId.TabIndex = 0;
            this.lblFineId.Text = "Глоба №:";
            // 
            // tabPageV
            // 
            this.tabPageV.Controls.Add(this.btnPrintVehicle);
            this.tabPageV.Controls.Add(this.btnClearVehicle);
            this.tabPageV.Controls.Add(this.btnShowAllVehicles);
            this.tabPageV.Controls.Add(this.btnDeleteVehicle);
            this.tabPageV.Controls.Add(this.btnUpdateVehicle);
            this.tabPageV.Controls.Add(this.gbCarData);
            this.tabPageV.Controls.Add(this.cbRegistryNumber);
            this.tabPageV.Controls.Add(this.btnAddVehicle);
            this.tabPageV.Controls.Add(this.lblRegNumber);
            this.tabPageV.Location = new System.Drawing.Point(29, 4);
            this.tabPageV.Name = "tabPageV";
            this.tabPageV.Size = new System.Drawing.Size(822, 407);
            this.tabPageV.TabIndex = 2;
            this.tabPageV.Text = "МПС";
            this.tabPageV.UseVisualStyleBackColor = true;
            // 
            // btnPrintVehicle
            // 
            this.btnPrintVehicle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrintVehicle.BackgroundImage")));
            this.btnPrintVehicle.Location = new System.Drawing.Point(738, 334);
            this.btnPrintVehicle.Name = "btnPrintVehicle";
            this.btnPrintVehicle.Size = new System.Drawing.Size(70, 70);
            this.btnPrintVehicle.TabIndex = 36;
            this.btnPrintVehicle.UseVisualStyleBackColor = true;
            this.btnPrintVehicle.Click += new System.EventHandler(this.btnPrintVehicle_Click);
            this.btnPrintVehicle.MouseHover += new System.EventHandler(this.btnPrintVehicle_MouseHover);
            // 
            // btnClearVehicle
            // 
            this.btnClearVehicle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearVehicle.BackgroundImage")));
            this.btnClearVehicle.Location = new System.Drawing.Point(738, 14);
            this.btnClearVehicle.Name = "btnClearVehicle";
            this.btnClearVehicle.Size = new System.Drawing.Size(70, 70);
            this.btnClearVehicle.TabIndex = 35;
            this.btnClearVehicle.UseVisualStyleBackColor = true;
            this.btnClearVehicle.Click += new System.EventHandler(this.btnClearVehicle_Click);
            this.btnClearVehicle.MouseHover += new System.EventHandler(this.btnClearVehicle_MouseHover);
            // 
            // btnShowAllVehicles
            // 
            this.btnShowAllVehicles.Location = new System.Drawing.Point(345, 16);
            this.btnShowAllVehicles.Name = "btnShowAllVehicles";
            this.btnShowAllVehicles.Size = new System.Drawing.Size(120, 24);
            this.btnShowAllVehicles.TabIndex = 3;
            this.btnShowAllVehicles.Text = "Покажи всички";
            this.btnShowAllVehicles.UseVisualStyleBackColor = true;
            this.btnShowAllVehicles.Click += new System.EventHandler(this.btnShowAllVehicles_Click);
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteVehicle.BackgroundImage")));
            this.btnDeleteVehicle.Location = new System.Drawing.Point(738, 174);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(70, 70);
            this.btnDeleteVehicle.TabIndex = 33;
            this.btnDeleteVehicle.UseVisualStyleBackColor = true;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            this.btnDeleteVehicle.MouseHover += new System.EventHandler(this.btnDeleteVehicle_MouseHover);
            // 
            // btnUpdateVehicle
            // 
            this.btnUpdateVehicle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateVehicle.BackgroundImage")));
            this.btnUpdateVehicle.Location = new System.Drawing.Point(738, 254);
            this.btnUpdateVehicle.Name = "btnUpdateVehicle";
            this.btnUpdateVehicle.Size = new System.Drawing.Size(70, 70);
            this.btnUpdateVehicle.TabIndex = 34;
            this.btnUpdateVehicle.UseVisualStyleBackColor = true;
            this.btnUpdateVehicle.Click += new System.EventHandler(this.btnUpdateVehicle_Click);
            this.btnUpdateVehicle.MouseHover += new System.EventHandler(this.btnUpdateVehicle_MouseHover);
            // 
            // gbCarData
            // 
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
            this.gbCarData.Location = new System.Drawing.Point(28, 50);
            this.gbCarData.Name = "gbCarData";
            this.gbCarData.Size = new System.Drawing.Size(688, 342);
            this.gbCarData.TabIndex = 2;
            this.gbCarData.TabStop = false;
            this.gbCarData.Text = "Информация за МПС";
            // 
            // txtBoxOwnerDLN
            // 
            this.txtBoxOwnerDLN.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.txtBoxOwnerDLN.Location = new System.Drawing.Point(135, 233);
            this.txtBoxOwnerDLN.Name = "txtBoxOwnerDLN";
            this.txtBoxOwnerDLN.Size = new System.Drawing.Size(161, 23);
            this.txtBoxOwnerDLN.TabIndex = 31;
            // 
            // txtBoxRegNumber
            // 
            this.txtBoxRegNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.txtBoxRegNumber.Location = new System.Drawing.Point(506, 170);
            this.txtBoxRegNumber.Name = "txtBoxRegNumber";
            this.txtBoxRegNumber.Size = new System.Drawing.Size(161, 23);
            this.txtBoxRegNumber.TabIndex = 30;
            // 
            // txtBoxRegDate
            // 
            this.txtBoxRegDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.txtBoxRegDate.Location = new System.Drawing.Point(506, 140);
            this.txtBoxRegDate.Name = "txtBoxRegDate";
            this.txtBoxRegDate.ReadOnly = true;
            this.txtBoxRegDate.Size = new System.Drawing.Size(161, 23);
            this.txtBoxRegDate.TabIndex = 29;
            // 
            // txtBoxColor
            // 
            this.txtBoxColor.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.txtBoxColor.Location = new System.Drawing.Point(506, 110);
            this.txtBoxColor.Name = "txtBoxColor";
            this.txtBoxColor.ReadOnly = true;
            this.txtBoxColor.Size = new System.Drawing.Size(161, 23);
            this.txtBoxColor.TabIndex = 28;
            // 
            // txtBoxWeight
            // 
            this.txtBoxWeight.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.txtBoxWeight.Location = new System.Drawing.Point(506, 80);
            this.txtBoxWeight.Name = "txtBoxWeight";
            this.txtBoxWeight.ReadOnly = true;
            this.txtBoxWeight.Size = new System.Drawing.Size(161, 23);
            this.txtBoxWeight.TabIndex = 27;
            // 
            // txtBoxSeats
            // 
            this.txtBoxSeats.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.txtBoxSeats.Location = new System.Drawing.Point(506, 50);
            this.txtBoxSeats.Name = "txtBoxSeats";
            this.txtBoxSeats.ReadOnly = true;
            this.txtBoxSeats.Size = new System.Drawing.Size(161, 23);
            this.txtBoxSeats.TabIndex = 26;
            // 
            // txtBoxType
            // 
            this.txtBoxType.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.txtBoxType.Location = new System.Drawing.Point(135, 170);
            this.txtBoxType.Name = "txtBoxType";
            this.txtBoxType.ReadOnly = true;
            this.txtBoxType.Size = new System.Drawing.Size(161, 23);
            this.txtBoxType.TabIndex = 25;
            // 
            // txtBoxModel
            // 
            this.txtBoxModel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.txtBoxModel.Location = new System.Drawing.Point(135, 140);
            this.txtBoxModel.Name = "txtBoxModel";
            this.txtBoxModel.ReadOnly = true;
            this.txtBoxModel.Size = new System.Drawing.Size(161, 23);
            this.txtBoxModel.TabIndex = 24;
            // 
            // txtBoxBrand
            // 
            this.txtBoxBrand.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.txtBoxBrand.Location = new System.Drawing.Point(135, 110);
            this.txtBoxBrand.Name = "txtBoxBrand";
            this.txtBoxBrand.ReadOnly = true;
            this.txtBoxBrand.Size = new System.Drawing.Size(161, 23);
            this.txtBoxBrand.TabIndex = 23;
            // 
            // txtBoxEngineNumber
            // 
            this.txtBoxEngineNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.txtBoxEngineNumber.Location = new System.Drawing.Point(135, 80);
            this.txtBoxEngineNumber.Name = "txtBoxEngineNumber";
            this.txtBoxEngineNumber.ReadOnly = true;
            this.txtBoxEngineNumber.Size = new System.Drawing.Size(161, 23);
            this.txtBoxEngineNumber.TabIndex = 22;
            // 
            // txtBoxFrameNumber
            // 
            this.txtBoxFrameNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.txtBoxFrameNumber.Location = new System.Drawing.Point(135, 50);
            this.txtBoxFrameNumber.Name = "txtBoxFrameNumber";
            this.txtBoxFrameNumber.ReadOnly = true;
            this.txtBoxFrameNumber.Size = new System.Drawing.Size(161, 23);
            this.txtBoxFrameNumber.TabIndex = 21;
            // 
            // lblOwnerDLN
            // 
            this.lblOwnerDLN.AutoSize = true;
            this.lblOwnerDLN.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblOwnerDLN.Location = new System.Drawing.Point(27, 234);
            this.lblOwnerDLN.Name = "lblOwnerDLN";
            this.lblOwnerDLN.Size = new System.Drawing.Size(105, 16);
            this.lblOwnerDLN.TabIndex = 20;
            this.lblOwnerDLN.Text = "Собственик:";
            this.lblOwnerDLN.MouseHover += new System.EventHandler(this.lblOwnerDLN_MouseHover);
            // 
            // lblRegNumberForAdd
            // 
            this.lblRegNumberForAdd.AutoSize = true;
            this.lblRegNumberForAdd.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRegNumberForAdd.Location = new System.Drawing.Point(343, 170);
            this.lblRegNumberForAdd.Name = "lblRegNumberForAdd";
            this.lblRegNumberForAdd.Size = new System.Drawing.Size(161, 16);
            this.lblRegNumberForAdd.TabIndex = 19;
            this.lblRegNumberForAdd.Text = "Регистрационен №:";
            // 
            // lblRegistryDate
            // 
            this.lblRegistryDate.AutoSize = true;
            this.lblRegistryDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRegistryDate.Location = new System.Drawing.Point(325, 140);
            this.lblRegistryDate.Name = "lblRegistryDate";
            this.lblRegistryDate.Size = new System.Drawing.Size(179, 16);
            this.lblRegistryDate.TabIndex = 18;
            this.lblRegistryDate.Text = "Дата на регистрация:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblColor.Location = new System.Drawing.Point(452, 110);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(52, 16);
            this.lblColor.TabIndex = 16;
            this.lblColor.Text = "Цвят:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblWeight.Location = new System.Drawing.Point(398, 80);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(105, 16);
            this.lblWeight.TabIndex = 14;
            this.lblWeight.Text = "Общо тегло:";
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSeats.Location = new System.Drawing.Point(402, 50);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(102, 16);
            this.lblSeats.TabIndex = 12;
            this.lblSeats.Text = "Брой места:";
            // 
            // lblTypeVehicle
            // 
            this.lblTypeVehicle.AutoSize = true;
            this.lblTypeVehicle.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTypeVehicle.Location = new System.Drawing.Point(90, 170);
            this.lblTypeVehicle.Name = "lblTypeVehicle";
            this.lblTypeVehicle.Size = new System.Drawing.Size(42, 16);
            this.lblTypeVehicle.TabIndex = 10;
            this.lblTypeVehicle.Text = "Вид:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblModel.Location = new System.Drawing.Point(69, 140);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(63, 16);
            this.lblModel.TabIndex = 8;
            this.lblModel.Text = "Модел:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBrand.Location = new System.Drawing.Point(69, 110);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(63, 16);
            this.lblBrand.TabIndex = 6;
            this.lblBrand.Text = "Марка:";
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEngine.Location = new System.Drawing.Point(24, 80);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(108, 16);
            this.lblEngine.TabIndex = 4;
            this.lblEngine.Text = "Двигател №:";
            // 
            // lblFrameNumber
            // 
            this.lblFrameNumber.AutoSize = true;
            this.lblFrameNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFrameNumber.Location = new System.Drawing.Point(58, 50);
            this.lblFrameNumber.Name = "lblFrameNumber";
            this.lblFrameNumber.Size = new System.Drawing.Size(74, 16);
            this.lblFrameNumber.TabIndex = 2;
            this.lblFrameNumber.Text = "Рама №:";
            // 
            // cbRegistryNumber
            // 
            this.cbRegistryNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbRegistryNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRegistryNumber.DataSource = this.vehicleBindingSource;
            this.cbRegistryNumber.DisplayMember = "RegistryNumber";
            this.cbRegistryNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.cbRegistryNumber.FormattingEnabled = true;
            this.cbRegistryNumber.Location = new System.Drawing.Point(195, 16);
            this.cbRegistryNumber.Name = "cbRegistryNumber";
            this.cbRegistryNumber.Size = new System.Drawing.Size(129, 24);
            this.cbRegistryNumber.TabIndex = 1;
            this.cbRegistryNumber.ValueMember = "RegistryNumber";
            this.cbRegistryNumber.SelectedIndexChanged += new System.EventHandler(this.cbRegistryNumber_SelectedIndexChanged);
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "Vehicle";
            this.vehicleBindingSource.DataSource = this.databaseDataSet;
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddVehicle.BackgroundImage")));
            this.btnAddVehicle.Location = new System.Drawing.Point(738, 94);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(70, 70);
            this.btnAddVehicle.TabIndex = 32;
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            this.btnAddVehicle.MouseHover += new System.EventHandler(this.btnAddVehicle_MouseHover);
            // 
            // lblRegNumber
            // 
            this.lblRegNumber.AutoSize = true;
            this.lblRegNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRegNumber.Location = new System.Drawing.Point(31, 20);
            this.lblRegNumber.Name = "lblRegNumber";
            this.lblRegNumber.Size = new System.Drawing.Size(161, 16);
            this.lblRegNumber.TabIndex = 0;
            this.lblRegNumber.Text = "Регистрационен №:";
            // 
            // cbSearchDriver
            // 
            this.cbSearchDriver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbSearchDriver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSearchDriver.BackColor = System.Drawing.SystemColors.Info;
            this.cbSearchDriver.DataSource = this.driversBindingSource;
            this.cbSearchDriver.DisplayMember = "DrivingLicenseNumber";
            this.cbSearchDriver.FormattingEnabled = true;
            this.cbSearchDriver.Location = new System.Drawing.Point(728, 40);
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
            // lblSearchDriver
            // 
            this.lblSearchDriver.AutoSize = true;
            this.lblSearchDriver.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSearchDriver.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearchDriver.Location = new System.Drawing.Point(606, 41);
            this.lblSearchDriver.Name = "lblSearchDriver";
            this.lblSearchDriver.Size = new System.Drawing.Size(119, 16);
            this.lblSearchDriver.TabIndex = 16;
            this.lblSearchDriver.Text = "Търси шофьор:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(786, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(0, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(98, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.AutoSize = false;
            this.loginToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.loginToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.loginToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.loginToolStripMenuItem.Text = "Излез";
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
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTitle.Location = new System.Drawing.Point(47, 78);
            this.lblTitle.MaximumSize = new System.Drawing.Size(0, 35);
            this.lblTitle.MinimumSize = new System.Drawing.Size(822, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(822, 35);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Лични данни";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.UseCompatibleTextRendering = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblSearchDriver);
            this.Controls.Add(this.cbSearchDriver);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.finesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.tabPageV.ResumeLayout(false);
            this.tabPageV.PerformLayout();
            this.gbCarData.ResumeLayout(false);
            this.gbCarData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnShowAllVehicles;
        private System.Windows.Forms.Button btnShowAllFines;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolTip ttClearFine;
        private System.Windows.Forms.ToolTip ttClearDriver;
        private System.Windows.Forms.ToolTip ttAddDriver;
        private System.Windows.Forms.ToolTip ttDeleteDriver;
        private System.Windows.Forms.ToolTip ttSaveDriver;
        private System.Windows.Forms.ToolTip ttAddFine;
        private System.Windows.Forms.ToolTip ttDeleteFine;
        private System.Windows.Forms.ToolTip ttSaveFine;
        private System.Windows.Forms.ToolTip ttClearVehicle;
        private System.Windows.Forms.ToolTip ttAddVehicle;
        private System.Windows.Forms.ToolTip ttDeleteVehicle;
        private System.Windows.Forms.ToolTip ttSaveVehicle;
        private System.Windows.Forms.TextBox txtBoxPlace;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.TextBox txtBoxTime;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.ToolTip ttOffenderDLN;
        private System.Windows.Forms.ToolTip ttOwnerDLN;
        private System.Windows.Forms.Button btnPrintDriver;
        private System.Windows.Forms.Button btnPrintFine;
        private System.Windows.Forms.Button btnPrintVehicle;
        private System.Windows.Forms.ToolTip ttPrintDriver;
        private System.Windows.Forms.ToolTip ttPrintFine;
        private System.Windows.Forms.ToolTip ttPrintVehicle;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;

    }
}

