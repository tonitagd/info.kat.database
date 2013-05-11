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

// I love silly comments
 
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
                ShowUserInfo(UserData.GetDriverByLicenseID(logForm.user.DrivingLicenseN));

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

            for (int i = 0; i < categoriesList.Length; i++)
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
            cbGender.Text = "";


            txtBoxCountry.Text = "";
            txtBoxCity.Text = "";
            txtBoxAddress.Text = "";

            txtBoxLicenseId.Text = "";
            cbPointsLeft.Text = "";

            cbCategories.SelectedValue = "";

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

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            try
            {
                Driver driver = createDriver();
                UserData.addDriver(driver);
                UserData.CreateUsernameAndPassword(CreateUser());
            }
            catch(Exception exc)
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            this.vehicleTableAdapter.Fill(this.databaseDataSet.Vehicle);
            this.finesTableAdapter.Fill(this.databaseDataSet.Fines);
            this.driversTableAdapter.Fill(this.databaseDataSet.Drivers);

        }

        private void cbSearchDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }

        private User CreateUser()
        {
            User user = new User();
            user.Username = txtBoxId.Text;
            user.Password = txtBoxLicenseId.Text;
            user.DrivingLicenseN = txtBoxLicenseId.Text;
            user.Role_ = Convert.ToInt16(cbRole.SelectedIndex + 1);
            return user;
        }
    }
}

