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

namespace KatDatabaseInfo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void Login()
        {
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
               // EnableAllControls();
            }
            loginToolStripMenuItem.Text = "Logout";
        }

        private void Logout()
        {
            // DisableAllControls();
            // ClearAllControls();
            loginToolStripMenuItem.Text = "Login";
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
=======
        private void SetEditable(bool editable){

            //Info page

            txtBoxName.ReadOnly = editable;
            txtBoxMiddleName.ReadOnly = editable;
            txtBoxLastName.ReadOnly = editable;

            txtBoxId.ReadOnly = editable;
            txtBoxBirthDate.ReadOnly = editable;
            //gender
            cbGender.IsAccessible = !editable;


            txtBoxCountry.ReadOnly = editable;
            txtBoxCity.ReadOnly = editable;
            txtBoxAddress.ReadOnly = editable;

            txtBoxLicenseId.ReadOnly = editable;
            cbPointsLeft.IsAccessible = !editable;

            cbCategories.CheckOnClick = !editable;

            //Fines page

            //type
            cbType.IsAccessible = !editable;
            txtBoxDate.ReadOnly = editable;
            txtBoxPoliceman.ReadOnly = editable;
            //paid
            cbPaid.IsAccessible = !editable;
            txtBoxOffenderDLN.ReadOnly = editable;
            txtBoxFineId.ReadOnly = editable;
            txtBoxReason.ReadOnly = editable;

            //Cars page

            txtBoxFrameNumber.ReadOnly = editable;
            txtBoxEngineNumber.ReadOnly = editable;
            txtBoxBrand.ReadOnly = editable;
            txtBoxModel.ReadOnly = editable;
            txtBoxType.ReadOnly = editable;

            txtBoxWeight.ReadOnly = editable;
            txtBoxColor.ReadOnly = editable;
            txtBoxRegDate.ReadOnly = editable;
            txtBoxRegNumber.ReadOnly = editable;

            txtBoxOwnerDLN.ReadOnly = editable;
        }

        private void SetStatusToAllControls(bool status){
            gbCarData.Enabled = status;
            gbFine.Enabled = status;
            gbPerfonalData.Enabled = status;
            gbLicense.Enabled = status;
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

            cbCategories.Text = "";

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
>>>>>>> support methods for login/logout
        }
    }
}
