using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KatDatabaseInfo.View;
using KatDatabaseInfo.Data;
using KatDatabaseInfo.Logic;
using System.IO;


namespace KatDatabaseInfo
{
    //TODO Kategoriite ne se zachistvat pri clear page
    public partial class MainForm : Form
    {
        private string pictureLocation = "";
        private static string clearPage = "Изчисти страницата";
        private static string saveChanges = "Запази промените";

        public UserStatus userStatus { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            SetUserStatus(null);
            SetStatusToAllControls(false);
            SetVisibilityToAdminButtons(false);
            SetEditable(false);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReloadMainForm();
            ClearAllControls();
        }

        private void ReloadMainForm()
        {
            this.vehicleTableAdapter.Fill(this.databaseDataSet.Vehicle);
            this.finesTableAdapter.Fill(this.databaseDataSet.Fines);
            this.driversTableAdapter.Fill(this.databaseDataSet.Drivers);
        }

        private void SetUserStatus(short? role)
        {
            switch (role)
            {
                case null:
                    userStatus = UserStatus.ANONYMOUS;
                    break;
                case 1:
                    userStatus = UserStatus.CITIZEN;
                    break;
                case 2:
                    userStatus = UserStatus.ADMIN;
                    break;
            }
        }

        private void SetStatusToAllControls(bool status)
        {
            gbCarData.Enabled = status;
            gbFine.Enabled = status;
            gbPerfonalData.Enabled = status;
            gbLicense.Enabled = status;
            lblFineId.Enabled = status;
            cbFineIds.Enabled = status;
            lblRegNumber.Enabled = status;
            cbRegistryNumber.Enabled = status;
            gbImage.Enabled = status;
            btnPrintDriver.Visible = status;
            btnPrintFine.Visible = status;
            btnPrintVehicle.Visible = status;
        }

        private void SetVisibilityToAdminButtons(bool visible)
        {
            lblSearchDriver.Visible = visible;
            cbSearchDriver.Visible = visible;
            lblOwnerDLN.Visible = visible;
            txtBoxOwnerDLN.Visible = visible;
            lblRole.Visible = visible;
            cbRole.Visible = visible;
            btnDell.Visible = visible;
            btnUpdate.Visible = visible;
            lblRole.Visible = visible;
            cbRole.Visible = visible;
            btnClear.Visible = visible;
            label2.Visible = visible;
            txtBoxFineId.Visible = visible;
            lblOffenderDLN.Visible = visible;
            txtBoxOffenderDLN.Visible = visible;

            btnAddFine.Visible = visible;
            btnAddVehicle.Visible = visible;
            btnAddDriver.Visible = visible;

            btnUpdate.Visible = visible;
            btnUpdateFine.Visible = visible;
            btnUpdateVehicle.Visible = visible; ;

            btnClear.Visible = visible;
            btnClearFine.Visible = visible;
            btnClearVehicle.Visible = visible;

            btnDell.Visible = visible;
            btnDeleteFine.Visible = visible;
            btnDeleteVehicle.Visible = visible;

            btnShowAllFines.Visible = visible;
            btnShowAllVehicles.Visible = visible;
            btnUpload.Visible = visible;
        }

        private void SetEditable(bool editable)
        {

            //Info page
            txtBoxName.ReadOnly = !editable;
            txtBoxMiddleName.ReadOnly = !editable;
            txtBoxLastName.ReadOnly = !editable;
            txtBoxId.ReadOnly = !editable;
            txtBoxBirthDate.ReadOnly = !editable;
            cbGender.Enabled = editable;
            txtBoxCountry.ReadOnly = !editable;
            txtBoxCity.ReadOnly = !editable;
            txtBoxAddress.ReadOnly = !editable;
            txtBoxLicenseId.ReadOnly = !editable;
            cbPointsLeft.Enabled = editable;
            cbCategories.Enabled = editable;

            //Fines page

            cbType.Enabled = editable;
            txtBoxDate.ReadOnly = !editable;
            txtBoxPoliceman.ReadOnly = !editable;
            cbPaid.Enabled = editable;
            txtBoxPrice.ReadOnly = !editable;
            txtBoxOffenderDLN.ReadOnly = !editable;
            txtBoxFineId.ReadOnly = !editable;
            txtBoxReason.ReadOnly = !editable;
            txtBoxTime.ReadOnly = !editable;
            txtBoxPlace.ReadOnly = !editable;

            //Cars page

            txtBoxFrameNumber.ReadOnly = !editable;
            txtBoxEngineNumber.ReadOnly = !editable;
            txtBoxBrand.ReadOnly = !editable;
            txtBoxModel.ReadOnly = !editable;
            txtBoxType.ReadOnly = !editable;
            txtBoxSeats.ReadOnly = !editable;
            txtBoxWeight.ReadOnly = !editable;
            txtBoxColor.ReadOnly = !editable;
            txtBoxRegDate.ReadOnly = !editable;
            txtBoxRegNumber.ReadOnly = !editable;
            txtBoxPrice.ReadOnly = !editable;
            txtBoxOwnerDLN.ReadOnly = !editable;
        }

        private void Login()
        {
            LoginForm logForm = new LoginForm();
            logForm.ShowDialog();
            if (logForm.DialogResult == DialogResult.OK)
            {
                SetUserStatus(logForm.user.Role_);
                SetStatusToAllControls(true);
                ShowUserInfo(UserData.GetDriverByLicenseID(logForm.user.DrivingLicenseNumber));

                loginToolStripMenuItem.Text = "Излез";
            }
        }

        private void ShowUserInfo(Driver driver)
        {
            if (UserStatus.CITIZEN.Equals(userStatus))
            {
                showDriverInfo(driver);
                ClearFinePage();
                ClearVehiclePage();
                SetEditable(false);
                SetVisibilityToAdminButtons(false);
            }
            else if (UserStatus.ADMIN.Equals(userStatus))
            {
                showAdminInfo(driver);
                SetVisibilityToAdminButtons(true);
            }
            
        }

        private void showDriverInfo(Driver driver)
        {
            if (driver == null)
            {
                return;
            }

            ClearCategories();

            txtBoxName.Text = driver.FirstName;
            txtBoxMiddleName.Text = driver.MiddleName; ;
            txtBoxLastName.Text = driver.LastName;

            txtBoxId.Text = driver.IdNumber;
            txtBoxBirthDate.Text = driver.BirthDate;
            cbGender.SelectedIndex = driver.Gender;

            txtBoxCountry.Text = driver.Country;
            txtBoxCity.Text = driver.City;
            txtBoxAddress.Text = driver.Address;

            txtBoxLicenseId.Text = driver.DrivingLicenseNumber;
            cbPointsLeft.SelectedIndex = (int)driver.DrivingPointsLeft;
            GetDriversCategories(driver.DrivingCategories);

            List<Fine> fineList = UserData.GetFineById(driver.DrivingLicenseNumber);
            cbFineIds.DataSource = fineList;
            cbFineIds.SelectedIndex = -1;

            List<Vehicle> carsList = UserData.GetVehicleById(driver.DrivingLicenseNumber);
            cbRegistryNumber.DataSource = carsList;
            cbRegistryNumber.SelectedIndex = -1;

            LoadPicture(driver.PictureLocation);
        }

        private void ClearCategories()
        {
            for (int i = 0; i < 11; i++)
            {
                cbCategories.SetItemChecked(i, false);
            }
        }

        private void GetDriversCategories(string categories)
        {
            string[] categoriesList = categories.Split(',');

            for (int i = 0; i < categoriesList.Length; i++)
            {
                string category = categoriesList[i].Trim();
                if ("".Equals(category))
                {
                    continue;
                }
                cbCategories.SetItemChecked(cbCategories.Items.IndexOf(category), true);
            }
        }

        private void showAdminInfo(Driver driver)
        {
            ShowAllFines();
            ShowAllVehicles();
            ClearAllControls();
            SetEditable(true);
        }

        private void ShowAllFines()
        {
            List<Fine> fineList = UserData.GetAllFines();
            cbFineIds.DataSource = fineList;
            ClearAllControls();
        }

        private void ShowAllVehicles()
        {
            List<Vehicle> carsList = UserData.GetAllVehicles();
            cbRegistryNumber.DataSource = carsList;
            ClearAllControls();
        }

        private void ClearAllControls()
        {
            ClearDriverInfoPage();
            ClearFinePage();
            ClearVehiclePage();
            ClearCategories();
        }

        private void ClearDriverInfoPage()
        {
            cbSearchDriver.SelectedIndex = -1;
            txtBoxName.Text = "";
            txtBoxMiddleName.Text = ""; ;
            txtBoxLastName.Text = "";

            txtBoxId.Text = "";
            txtBoxBirthDate.Text = "";
            cbGender.SelectedIndex = -1;

            txtBoxCountry.Text = "";
            txtBoxCity.Text = "";
            txtBoxAddress.Text = "";

            txtBoxLicenseId.Text = "";
            cbPointsLeft.SelectedIndex = -1;
            cbRole.SelectedIndex = -1;
            pictureBox1.Image = null;
        }

        private void ClearFinePage()
        {
            cbFineIds.SelectedIndex = -1;
            cbType.SelectedIndex = -1;
            txtBoxDate.Text = "";
            txtBoxPoliceman.Text = "";
            cbPaid.SelectedIndex = -1;
            txtBoxOffenderDLN.Text = "";
            txtBoxFineId.Text = "";
            txtBoxReason.Text = "";
            txtBoxPrice.Text = "";
            txtBoxTime.Text = "";
            txtBoxPlace.Text = "";
        }

        private void ClearVehiclePage()
        {
            cbRegistryNumber.SelectedIndex = -1;
            txtBoxFrameNumber.Text = "";
            txtBoxEngineNumber.Text = "";
            txtBoxBrand.Text = "";
            txtBoxModel.Text = "";
            txtBoxType.Text = "";
            txtBoxWeight.Text = "";
            txtBoxColor.Text = "";
            txtBoxRegDate.Text = "";
            txtBoxRegNumber.Text = "";
            txtBoxSeats.Text = "";
            txtBoxOwnerDLN.Text = "";
        }

        private void Logout()
        {
            SetUserStatus(null);
            SetStatusToAllControls(false);
            SetVisibilityToAdminButtons(false);
            ClearAllControls();
            SetEditable(false);
            loginToolStripMenuItem.Text = "Влез";
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (userStatus)
            {
                case UserStatus.ANONYMOUS:
                    Login();
                    break;
                case UserStatus.CITIZEN:
                    Logout();
                    break;
                case UserStatus.ADMIN:
                    Logout();
                    break;
                default:
                    break;
            }

        }

        // Diver Data Window Buttons

        private void cbSearchDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            object value = cbSearchDriver.SelectedValue;
            if (value == null)
            {
                return;
            }
            string id = cbSearchDriver.SelectedValue.ToString();
            Driver driver = UserData.GetDriverByLicenseID(id);
            showDriverInfo(driver);
            short? role = UserData.GetUserRoleByLicenseID(id);
            if (role == null)
            {
                cbRole.SelectedIndex = 2;
                return;
            }
            cbRole.SelectedIndex = (int)role - 1;
            ChangeDriverToUpdateble();
            ClearFinePage();
            ClearVehiclePage();
        }

        private void ChangeDriverToUpdateble()
        {
            SetEditable(false);
            cbPointsLeft.Enabled = true;
            cbRole.Enabled = true;
            cbCategories.Enabled = true;
            txtBoxAddress.ReadOnly = false;
            txtBoxCity.ReadOnly = false;
            txtBoxCountry.ReadOnly = false;
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            try
            {
                Driver driver = createDriver();
                UserData.addDriver(driver);
                UserData.CreateUsernameAndPassword(CreateUser());
                ReloadMainForm();
                MessageBox.Show("Добавен шофьор: " + driver.FirstName + " " + driver.LastName + ".");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Грешка при добавяне на шофьор." + exc.Message);
            }
        }

        private Driver createDriver()
        {
            Driver driver = new Driver();
            //Info page
            driver.FirstName = txtBoxName.Text;
            driver.MiddleName = txtBoxMiddleName.Text;
            driver.LastName = txtBoxLastName.Text;

            driver.IdNumber = txtBoxId.Text;
            driver.BirthDate = txtBoxBirthDate.Text;
            driver.Gender = Convert.ToInt16(cbGender.SelectedIndex);

            //Address
            driver.Country = txtBoxCountry.Text;
            driver.City = txtBoxCity.Text;
            driver.Address = txtBoxAddress.Text;

            //Driving license
            driver.DrivingLicenseNumber = txtBoxLicenseId.Text;
            driver.DrivingPointsLeft = Convert.ToInt16(cbPointsLeft.SelectedIndex);
            driver.DrivingCategories = GetCategories();
            driver.PictureLocation = pictureLocation;

            return driver;
        }

        private string GetCategories()
        {
            string categories = "";

            for (int i = 0; i < 11; i++)
            {
                if (cbCategories.GetItemChecked(i))
                {
                    categories += GetCategorieByNumber(i) + ", ";
                }
            }
            return categories;
        }

        private string GetCategorieByNumber(int i)
        {
            switch (i)
            {
                case 0:
                    return "A";
                case 1:
                    return "B";
                case 2:
                    return "C";
                case 3:
                    return "D";
                case 4:
                    return "BE";
                case 5:
                    return "CE";
                case 6:
                    return "DE";
                case 7:
                    return "Ttb";
                case 8:
                    return "Ttm";
                case 9:
                    return "Tkt";
                case 10:
                    return "M";
                default:
                    return "";
            }
        }

        private User CreateUser()
        {
            User user = new User();
            user.Username = txtBoxId.Text;
            user.Password = txtBoxLicenseId.Text;
            user.DrivingLicenseNumber = txtBoxLicenseId.Text;
            user.Role_ = Convert.ToInt16(cbRole.SelectedIndex + 1);
            return user;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Driver driver = createDriver();
                User user = CreateUser();
                UserData.UpdateDriver(driver.DrivingLicenseNumber, driver.Country, driver.City, driver.Address, driver.DrivingPointsLeft, driver.DrivingCategories, user.Role_);
                MessageBox.Show("Актуализацията е успешна.");
                ReloadMainForm();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Грешка при актуализация. " + exc.Message);
            }
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            try
            {
                UserData.DeleteDriver(txtBoxLicenseId.Text);
                MessageBox.Show("Шофьор с документ №:'" + txtBoxLicenseId.Text + "' е изтрит успешно.");
                ClearAllControls();
                ReloadMainForm();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Грешка при изтриването на шофьор." + exc.Message);
            }
        }

        //------------END OF DRIVERS WINDOWS--------------

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDriverInfoPage();
            SetEditable(true);
        }


        // --------Fine Data Window--------------

        private void cbFineIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            object value = cbFineIds.SelectedValue;
            if (value == null)
            {
                return;
            }
            string id = value.ToString();
            Fine fine = UserData.GetFineBySerialNumber(id);
            showFineInfo(fine);
            ChangeFineToUpdateble();
        }

        private void showFineInfo(Fine fine)
        {
            cbType.SelectedIndex = GetFineType(fine.Type);
            txtBoxDate.Text = fine.Date;
            txtBoxPoliceman.Text = fine.Policeman;

            cbPaid.SelectedIndex = fine.Paid;
            txtBoxOffenderDLN.Text = fine.DrivingLicenseNumber;
            txtBoxPrice.Text = fine.Amount.ToString();
            txtBoxFineId.Text = fine.SerialNumber.ToString();
            txtBoxReason.Text = fine.Reason;
            txtBoxPlace.Text = fine.Location;
            txtBoxTime.Text = fine.Hour;
        }

        private int GetFineType(string fineType)
        {
            switch (fineType)
            {
                case "Ticket":
                    return 0;
                case "Act":
                    return 1;
                default:
                    return -1;
            }
        }

        private void ChangeFineToUpdateble()
        {
            if (UserStatus.ADMIN.Equals(userStatus))
            {
                SetEditable(false);
                cbPaid.Enabled = true;
                txtBoxPrice.ReadOnly = false;
            }
        }

        private void btnShowAllFines_Click(object sender, EventArgs e)
        {
            ShowAllFines();
        }

        private void btnAddFine_Click(object sender, EventArgs e)
        {
            try
            {
                Fine fine = CreateFine();
                UserData.AddNewFine(fine);
                ReloadMainForm();
                MessageBox.Show("Добавено нарушение №: '" + fine.SerialNumber + "'.");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Грешка при добавяне на нарушение." + exc.Message);
            }
        }

        private Fine CreateFine()
        {
            Fine fine = new Fine();
            fine.SerialNumber = txtBoxFineId.Text;
            string type = GetFineTypeName(cbType.SelectedIndex);
            fine.Type = type;
            fine.Date = txtBoxDate.Text;
            fine.Policeman = txtBoxPoliceman.Text;
            fine.Paid = (byte)cbPaid.SelectedIndex;
            fine.DrivingLicenseNumber = txtBoxOffenderDLN.Text;
            fine.Reason = txtBoxReason.Text;
            fine.Amount = Convert.ToDecimal(txtBoxPrice.Text);
            fine.Hour = txtBoxTime.Text;
            fine.Location = txtBoxPlace.Text;
            return fine;
        }

        private string GetFineTypeName(int type)
        {
            switch (type)
            {
                case 0:
                    return "Ticket";
                default:
                    return "Act";
            }
        }

        private void btnUpdateFine_Click(object sender, EventArgs e)
        {
            try
            {
                Fine fine = CreateFine();
                UserData.UpdateFine(fine.SerialNumber, fine.Paid, fine.Amount);
                MessageBox.Show("Актуализацията е успешна.");
                ReloadMainForm();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Грешка при актуализация. " + exc.Message);
            }
        }

        private void btnDeleteFine_Click(object sender, EventArgs e)
        {
            try
            {
                UserData.DeleteFine(txtBoxFineId.Text);
                MessageBox.Show("Глоба №:'" + txtBoxFineId.Text + "' е  изтрита успешно.");
                ClearAllControls();
                ReloadMainForm();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Грешка при изтриване на глоба." + exc.Message);
            }
        }

        private void btnClearFine_Click(object sender, EventArgs e)
        {
            ClearFinePage();
            SetEditable(true);
        }

        // Vehicles Data Window

        private void cbRegistryNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            object value = cbRegistryNumber.SelectedValue;
            if (value == null)
            {
                return;
            }
            string id = value.ToString();
            Vehicle vehicle = UserData.GetVehicleByRegNumber(id);
            showVehicleInfo(vehicle);
            ChangeVehicleToUpdatable();
        }

        private void showVehicleInfo(Vehicle vehicle)
        {
            txtBoxFrameNumber.Text = vehicle.FrameNumber;
            txtBoxEngineNumber.Text = vehicle.EngineNumber;
            txtBoxBrand.Text = vehicle.Brand;
            txtBoxModel.Text = vehicle.Model;
            txtBoxType.Text = GetVehicleType(vehicle.Type);

            txtBoxWeight.Text = vehicle.Weight.ToString();
            txtBoxSeats.Text = vehicle.Seats.ToString();
            txtBoxColor.Text = vehicle.Color;
            txtBoxRegDate.Text = vehicle.RegistryDate;
            txtBoxRegNumber.Text = vehicle.RegistryNumber;

            txtBoxOwnerDLN.Text = vehicle.DrivingLicenseNumber;
        }

        private string GetVehicleType(string type)
        {
            switch (type)
            {
                case "0":
                    return "лек";
                case "1":
                    return "леко-товарен";

                default:
                    return "товарен";

            }
        }

        private void ChangeVehicleToUpdatable()
        {
            if (UserStatus.ADMIN.Equals(userStatus))
            {
                SetEditable(false);
                txtBoxColor.ReadOnly = false;
                txtBoxRegNumber.ReadOnly = false;
                txtBoxOwnerDLN.ReadOnly = false;
            }
        }

        private void btnShowAllVehicles_Click(object sender, EventArgs e)
        {
            ShowAllVehicles();
        }

        private void btnClearVehicle_Click(object sender, EventArgs e)
        {
            ClearVehiclePage();
            SetEditable(true);
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                Vehicle vehicle = CreateVehicle();
                UserData.AddNewVehicle(vehicle);
                ReloadMainForm();
                MessageBox.Show("Добавен МПС с регистрационен №:'" + vehicle.RegistryNumber + "'.");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Грешка при добавяне на МПС." + exc.Message);
            }
        }

        private Vehicle CreateVehicle()
        {
            Vehicle vehicle = new Vehicle();
            vehicle.FrameNumber = txtBoxFrameNumber.Text;
            vehicle.EngineNumber = txtBoxEngineNumber.Text;
            vehicle.Brand = txtBoxBrand.Text;
            vehicle.Model = txtBoxModel.Text;
            vehicle.Type = txtBoxType.Text;
            vehicle.Weight = int.Parse(txtBoxWeight.Text);
            vehicle.Seats = short.Parse(txtBoxSeats.Text);
            vehicle.Color = txtBoxColor.Text;
            vehicle.RegistryDate = txtBoxRegDate.Text;
            vehicle.RegistryNumber = txtBoxRegNumber.Text;
            vehicle.DrivingLicenseNumber = txtBoxOwnerDLN.Text;
            return vehicle;
        }

        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                Vehicle vehicle = CreateVehicle();
                UserData.UpdateVehicle(vehicle.FrameNumber, vehicle.RegistryNumber, vehicle.Color, vehicle.DrivingLicenseNumber);
                ReloadMainForm();
                MessageBox.Show("Актуализацията е успешна.");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Грешка при актуализация. " + exc.Message);
            }
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                string regNumber = txtBoxRegNumber.Text;
                UserData.DeleteVehicle(regNumber);
                MessageBox.Show("Изтрит МПС с регистрационен №:'" + regNumber + "'.");
                ClearAllControls();
                ReloadMainForm();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Грешка при изтриване." + exc.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            this.pictureLocation = GetPictureLocation();
            LoadPicture(pictureLocation);
        }

        private void LoadPicture(string location)
        {
            try
            {
                pictureBox1.Load(location);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                MessageBox.Show("Грешка при отварянето на снимка.");
            }
        }

        private string GetPictureLocation()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string location = openFileDialog.FileName;
                string[] parsedLocation = location.Split('.');
                string availableFormats = "jpeg jpg bmp png";
                string picFormat = parsedLocation[parsedLocation.Length - 1];
                if (!availableFormats.Contains(picFormat))
                {
                    MessageBox.Show("'" + picFormat + "' не се поддържа\n Формата трябва да е: " + availableFormats);
                }
                return location;
            }
            return null;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTitle.Text = tabControl.SelectedTab.Text;
        }

        //Driver info page buttons tool tips

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            ttClearDriver.Show(clearPage, btnClear);
        }

        private void btnAddDriver_MouseHover(object sender, EventArgs e)
        {
            ttAddDriver.Show("Добави шофьор", btnAddDriver);
        }

        private void btnDell_MouseHover(object sender, EventArgs e)
        {
            ttDeleteDriver.Show("Изтрий шофьор", btnDell);
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            ttSaveDriver.Show(saveChanges, btnUpdate);
        }

        //Fines page buttons tool tips

        private void btnClearFine_MouseHover(object sender, EventArgs e)
        {
            ttClearFine.Show(clearPage, btnClearFine);
        }

        private void btnAddFine_MouseHover(object sender, EventArgs e)
        {
            ttAddFine.Show("Добави глоба", btnAddFine);
        }

        private void btnDeleteFine_MouseHover(object sender, EventArgs e)
        {
            ttDeleteFine.Show("Изтрий глоба", btnDeleteFine);
        }

        private void btnUpdateFine_MouseHover(object sender, EventArgs e)
        {
            ttSaveFine.Show(saveChanges, btnUpdateFine);
        }

        //Vehicle page buttons tool tips

        private void btnClearVehicle_MouseHover(object sender, EventArgs e)
        {
            ttClearVehicle.Show(clearPage, btnClearVehicle);
        }

        private void btnAddVehicle_MouseHover(object sender, EventArgs e)
        {
            ttAddVehicle.Show("Добави МПС", btnAddVehicle);
        }

        private void btnDeleteVehicle_MouseHover(object sender, EventArgs e)
        {
            ttDeleteVehicle.Show("Изтрий МПС", btnDeleteVehicle);
        }

        private void btnUpdateVehicle_MouseHover(object sender, EventArgs e)
        {
            ttSaveVehicle.Show(saveChanges, btnUpdateVehicle);
        }

        private void lblOffenderDLN_MouseHover(object sender, EventArgs e)
        {
            ttOffenderDLN.Show("Шофьорска книижка №", lblOffenderDLN);
        }

        private void lblOwnerDLN_MouseHover(object sender, EventArgs e)
        {
            ttOwnerDLN.Show("Шофьорска книижка №", lblOwnerDLN);
        }

        private void btnPrintDriver_MouseHover(object sender, EventArgs e)
        {
            ttPrintDriver.Show("Разпечатай лични данни", btnPrintDriver);
        }

        private void btnPrintFine_MouseHover(object sender, EventArgs e)
        {
            ttPrintFine.Show("Разпечатай нарушение", btnPrintFine);
        }

        private void btnPrintVehicle_MouseHover(object sender, EventArgs e)
        {
            ttPrintVehicle.Show("Разпечатай данни за МПС", btnPrintVehicle);
        }

        private void btnPrintDriver_Click(object sender, EventArgs e)
        {
            Driver driver = UserData.GetDriverByLicenseID(txtBoxLicenseId.Text);
            if (driver == null)
            {
                MessageBox.Show("Моля, първо изберете шофьор");
                return;
            }
            string documentData = @"---Лични данни---

Име: " + driver.FirstName + @"
Презиме: " + driver.MiddleName + @"
Фамилия: " + driver.LastName + @"
ЕГН: " + driver.IdNumber + @"
Държава: " + driver.Country + @"
Град: " + driver.City + @"
Адрес: " + driver.Address + @"

---Шофьорски данни---
Документ №: " + driver.DrivingLicenseNumber + @"
Tочки: " + driver.DrivingPointsLeft + @"
Категории: " + driver.DrivingCategories;

            saveFile(documentData, "Данните не могат да се разпечатат.");
        }

        private void btnPrintFine_Click(object sender, EventArgs e)
        {
            Driver driver = UserData.GetDriverByLicenseID(txtBoxOffenderDLN.Text);
            string price = txtBoxPrice.Text;
            if ("".Equals(price))
            {
                price = "платена";
            }
            if (driver == null)
            {
                MessageBox.Show("Моля, първо изберете глоба.");
                return;
            }
            string documentData = @"                                                №: " + txtBoxFineId.Text + @"
РЕПУБЛИКА БЪЛГАРИЯ / REPUBLIC OF BULGARIA
МИНИСТЕРСТРО НА ВЪТРЕШНИТЕ РАБОТИ/ MINISTRY OF INTERIOR
ГЛОБА С " + GetTypeName(cbType.SelectedIndex) + @"/ TRAFFIC TICKET

Днес/Today " + txtBoxDate.Text + @" подписаният/undersigned " + txtBoxPoliceman.Text + @"
На длъжност/ official post полицай в " + txtBoxPlace.Text + @" установих, че/ascertain the fact that "
                                       + driver.FirstName + " " + driver.MiddleName + " " + driver.LastName + @"
Шофьорска книжка/Driving License №:" + txtBoxOffenderDLN.Text + @"
Постоянен адрес/permanent address " + txtBoxAddress.Text + @"
е извършил нарушение/commit a violation " + txtBoxReason.Text + @"
поради което на основание чл. 186, налагам глоба/and upon article 186 set a fine " + price + @"
лева/BG leva

СЪСТАВИТЕЛ/COMPLIER: " + txtBoxPoliceman.Text + @"
ПОДПИС/SIGNITURE:                       ";

            saveFile(documentData, "Глобата не може да се разпечата.");
        }

        private string GetTypeName(int p)
        {
            switch (p)
            {
                case 0:
                    return "Фиш";
                default:
                    return "Акт";
            }
        }

        private void btnPrintVehicle_Click(object sender, EventArgs e)
        {
            Driver driver = UserData.GetDriverByLicenseID(txtBoxOwnerDLN.Text);
            if (driver == null)
            {
                MessageBox.Show("Моля, първо изберете МПС.");
                return;
            }

            string documentData = @"
РЕПУБЛИКА БЪЛГАРИЯ
МИНИСТЕРСТВО НА ВЪТРЕШНИТЕ РАБОТИ
REPUBLIC OF BULGARIA 
MINISTRY OF INTERIOR

               СВИДЕТЕЛСТВО ЗА 
РЕГИСТРАЦИЯ НА МОТОРНО ПРЕВОЗНО СРЕДСТВО 

---ДАННИ ЗА МПС---						
А. Регистрационен №: " + txtBoxRegNumber.Text + @"
E. Рама №: " + txtBoxFrameNumber.Text + @"			     
     Двигател №: " + txtBoxEngineNumber.Text + @"  			     
D. Марка: " + txtBoxBrand.Text + @"
     Модел: " + txtBoxModel.Text + @"
      Вид: " + txtBoxType.Text + @"
F. Брой места: " + txtBoxSeats.Text + @"
    Общо тегло: " + txtBoxWeight.Text + @"			
B. Дата на регистрация: " + txtBoxRegDate.Text + @"

---ДАННИ ЗА СОБСТВЕНИК---
С. Собственик: " + driver.FirstName + " " + driver.LastName + @"
   ЕГН: " + driver.IdNumber + @"
   Aдрес: " + driver.City + ", " + driver.Address;

            saveFile(documentData, "Данните не могат да се разпечатат.");
        }

        private void saveFile(string documentData, string errMessage)
        {
            try
            {
                FileStream stream = new FileStream(GetFileName(), FileMode.OpenOrCreate);
                StreamWriter writer = new StreamWriter(stream, Encoding.UTF8);
                writer.Write(documentData);
                writer.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(errMessage);
            }
        }

        private string GetFileName()
        {
            saveFileDialog.Filter = "DOC Files|*.doc";
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && (saveFileDialog.FileName.Length > 0))
            {
                return saveFileDialog.FileName;
            }
            return null;
        }

        
    }
}

