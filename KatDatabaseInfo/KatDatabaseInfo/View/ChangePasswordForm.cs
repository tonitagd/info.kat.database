using KatDatabaseInfo.Data;
using KatDatabaseInfo.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatDatabaseInfo.View
{
    public partial class ChangePasswordForm : Form
    {
        string errMessage;
        User user;

        public ChangePasswordForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            errMessage = "";
            if (!ValidatePasswords())
            {
                MessageBox.Show(errMessage);
                return;
            }
            ChangePasswords();
            MessageBox.Show("Паролата е сменена успешно");
        }

        private bool ValidatePasswords()
        {
            bool isValid = true;
            Validator.Reset();
            isValid &= !Validator.isNullOrEmpty(txtBoxCurrentPass.Text, "текуща парола");
            isValid &= !Validator.isNullOrEmpty(txtBoxPass.Text, "нова парола");
            isValid &= !Validator.isNullOrEmpty(txtBoxConfirmedPass.Text, "потвърдена парола");

            if (!txtBoxConfirmedPass.Text.Equals(txtBoxPass.Text))
            {
                errMessage += "\nПотвърдената парола не съвпада с въведената.";
                isValid &= false;
            }


            if (UserData.IsUserPassCorrect(user.Username, txtBoxCurrentPass.Text) == null)
            {
                errMessage += "\nНевалидна текуща парола";
                isValid &= false;
            }

            this.errMessage += Validator.errText;

            return isValid;
        }

        private void ChangePasswords()
        {
            UserData.UpdatePass(user.DrivingLicenseNumber, txtBoxPass.Text);
        }
    }
}
