using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KatDatabaseInfo.Logic;
using KatDatabaseInfo.Data;

namespace KatDatabaseInfo.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginValidator loginValidation = new LoginValidator(txtBoxUsername.Text, txtBoxPassword.Text);
            Data.User user = UserData.IsUserPassCorrect(txtBoxUsername.Text, txtBoxPassword.Text);

            if (loginValidation.ValidateUserInput(out user))
            {
                MainForm mainForm = new MainForm(user);
                mainForm.Visible = true;
                mainForm.LoadForm(user);
                this.Hide();
            }
            else
            {
                MessageBox.Show(loginValidation.errText);
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
