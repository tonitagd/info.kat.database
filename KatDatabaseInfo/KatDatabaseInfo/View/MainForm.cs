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

 
namespace KatDatabaseInfo
{
    public partial class MainForm : Form
    {
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

                loginToolStripMenuItem.Text = "Logout";
            }
        }

        private void ShowUserInfo(Driver driver)
        {

            if (UserStatus.CITIZEN.Equals(userStatus))
            {
                showDriverInfo(driver);
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

            //Info page

            txtBoxName.Text = driver.FirstName;
            txtBoxMiddleName.Text = driver.MiddleName; ;
            txtBoxLastName.Text = driver.LastName;

            txtBoxId.Text = driver.IdNumber;
            txtBoxBirthDate.Text = driver.BirthDate;
            //gender
            cbGender.SelectedIndex = driver.Gender;

            txtBoxCountry.Text = driver.Country;
            txtBoxCity.Text = driver.City;
            txtBoxAddress.Text = driver.Address;

            txtBoxLicenseId.Text = driver.DrivingLicenseNumber;
            cbPointsLeft.SelectedIndex = (int)driver.DrivingPointsLeft;

            GetDriversCategories(driver.DrivingCategories);
         
            //Fines page

            //type
            cbType.Text = "";
            txtBoxDate.Text = "";
            txtBoxPoliceman.Text = "";
            //paid
            cbPaid.Text = "";
            txtBoxOffenderDLN.Text = "";
            txtBoxFineId.Text = "";
            txtBoxReason.Text = "";

            //Cars page

            txtBoxFrameNumber.Text = "";
            txtBoxEngineNumber.Text = "";
            txtBoxBrand.Text = "";
            txtBoxModel.Text = "";
            txtBoxType.Text = "";

            txtBoxWeight.Text = "";
            txtBoxColor.Text = "";
            txtBoxRegDate.Text = "";
            txtBoxRegNumber.Text = "";

            txtBoxOwnerDLN.Text = "";

        }

        private void GetDriversCategories(string categories)
        {
            string[] categoriesList = categories.Split(',');

            for (int i = 0; i < categoriesList.Length - 1; i++)
            {
                cbCategories.SetItemChecked(cbCategories.Items.IndexOf(categoriesList[i]), true);
            }
        }

        private void SetEditable(bool editable)
        {

            //Info page
            txtBoxName.ReadOnly = !editable;
            txtBoxMiddleName.ReadOnly = !editable;
            txtBoxLastName.ReadOnly = !editable;

            txtBoxId.ReadOnly = !editable;
            txtBoxBirthDate.ReadOnly = !editable;

            //gender
            cbGender.Enabled = editable;


            txtBoxCountry.ReadOnly = !editable;
            txtBoxCity.ReadOnly = !editable;
            txtBoxAddress.ReadOnly = !editable;

            txtBoxLicenseId.ReadOnly = !editable;
            cbPointsLeft.Enabled = editable;

            cbCategories.Enabled = editable; //Chech on click doesn't work

            //Fines page

            //type
            cbType.Enabled = editable;
            txtBoxDate.ReadOnly = !editable;
            txtBoxPoliceman.ReadOnly = !editable;
            //paid
            cbPaid.Enabled = editable;
            txtBoxPrice.ReadOnly = !editable;
            txtBoxOffenderDLN.ReadOnly = !editable;
            txtBoxFineId.ReadOnly = !editable;
            txtBoxReason.ReadOnly = !editable;

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

            txtBoxOwnerDLN.ReadOnly = !editable;

        }

        private void SetVisibilityToAdminButtons(bool visible)
        {
            lblSearchDriver.Visible = visible;
            cbSearchDriver.Visible = visible;
            btnAddFine.Visible = visible;
            btnAddVehicle.Visible = visible;
            btnAddDriver.Visible = visible;
            lblOwnerDLN.Visible = visible;
            txtBoxOwnerDLN.Visible = visible;
            lblRole.Visible = visible;
            cbRole.Visible = visible;
            btnDell.Visible = visible;
            btnUpdate.Visible = visible;
            lblRole.Visible = visible;
            cbRole.Visible = visible;
            btnClear.Visible = visible;
            lblPrice.Visible = visible;
            txtBoxPrice.Visible = visible;
            label2.Visible = visible;
            txtBoxFineId.Visible = visible;
        }

        private void showAdminInfo(Driver driver)
        {
            SetEditable(true);
            ClearAllControls();
        }

        private void ClearAllControls()
        {
            //Info page

            txtBoxName.Text = "";
            txtBoxMiddleName.Text = ""; ;
            txtBoxLastName.Text = "";

            txtBoxId.Text = "";
            txtBoxBirthDate.Text = "";
            //gender
            cbGender.SelectedIndex = -1;


            txtBoxCountry.Text = "";
            txtBoxCity.Text = "";
            txtBoxAddress.Text = "";

            txtBoxLicenseId.Text = "";
            cbPointsLeft.SelectedIndex = -1;

            for (int i = 0; i < 11; i++)
            {
                cbCategories.SetItemChecked(i, false);
            }
            
            cbRole.SelectedIndex = -1;

            //Fines page

            //type
            cbType.SelectedIndex = -1;
            txtBoxDate.Text = "";
            txtBoxPoliceman.Text = "";
            //paid
            cbPaid.SelectedIndex = -1;
            txtBoxOffenderDLN.Text = "";
            txtBoxFineId.Text = "";
            txtBoxReason.Text = "";

            //Cars page

            txtBoxFrameNumber.Text = "";
            txtBoxEngineNumber.Text = "";
            txtBoxBrand.Text = "";
            txtBoxModel.Text = "";
            txtBoxType.Text = "";

            txtBoxWeight.Text = "";
            txtBoxColor.Text = "";
            txtBoxRegDate.Text = "";
            txtBoxRegNumber.Text = "";

            txtBoxOwnerDLN.Text = "";
        }

        private void Logout()
        {
            SetUserStatus(null);
            SetStatusToAllControls(false);
            SetVisibilityToAdminButtons(false);
            ClearAllControls();
            SetEditable(false);
            loginToolStripMenuItem.Text = "Login";
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

        // Diver Data Window

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
            cbRole.SelectedIndex = (int)role-1;
            ChangeDriverToUpdateble();
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
                MessageBox.Show("Adding driver " + driver.FirstName + " " + driver.LastName + " successful.");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Failed adding driver." + exc.Message);
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
            return driver;
        }

        private string GetCategories()
        {
            string categories = "";
            ListBox.SelectedObjectCollection lb = cbCategories.SelectedItems;

            for (int i = 0; i < lb.Count; i++)
            {
                categories += lb[i];
            }
            return categories;
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

        private void btnDell_Click(object sender, EventArgs e)
        {
            try
            {
                UserData.DeleteDriver(txtBoxLicenseId.Text);
                MessageBox.Show("Deleting driver with license id:'" + txtBoxLicenseId.Text + "' completed successfully.");
                ClearAllControls();
                ReloadMainForm();
            }
            catch (Exception exc)
            {
              MessageBox.Show("Failed deleting driver." + exc.Message);
            }
        }

        //END OF DRIVERS WINDOWS

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearButton();
        }

        private void ClearButton()
        {
            ClearAllControls();
            SetEditable(true);
        }

        // Fine Data Window

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
            SetEditable(false);
            cbPaid.Enabled = true;
            txtBoxPrice.ReadOnly = false;
        }

        private void btnAddFine_Click(object sender, EventArgs e)
        {
            try
            {
                Fine fine = CreateFine();
                UserData.AddNewFine(fine);
                ReloadMainForm();
                MessageBox.Show("Adding fine with ID: '" + fine.SerialNumber + "' successful.");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Failed adding fine." + exc.Message);
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

        private void btnClearFine_Click(object sender, EventArgs e)
        {
            ClearButton();
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
            ChangeVehicleToUpdateble();
        }

        private void showVehicleInfo(Vehicle vehicle)
        {
            txtBoxFrameNumber.Text = vehicle.FrameNumber;
            txtBoxEngineNumber.Text = vehicle.EngineNumber;
            txtBoxBrand.Text = vehicle.Brand;
            txtBoxModel.Text = vehicle.Model;
            txtBoxType.Text = vehicle.Type;

            txtBoxWeight.Text = vehicle.Weight.ToString();
            txtBoxSeats.Text = vehicle.Seats.ToString();
            txtBoxColor.Text = vehicle.Color;
            txtBoxRegDate.Text = vehicle.RegistryDate;
            txtBoxRegNumber.Text = vehicle.RegistryNumber;

            txtBoxOwnerDLN.Text = vehicle.DrivingLicenseNumber;
        }

        private void ChangeVehicleToUpdateble()
        {
            SetEditable(false);
            txtBoxColor.ReadOnly = false;
            txtBoxRegNumber.ReadOnly = false;
        }

        private void btnClearVehicle_Click(object sender, EventArgs e)
        {
            ClearButton();
        }  
    }
}

