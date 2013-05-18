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
            LoginValidation loginValidation = new LoginValidation(txtBoxUsername.Text, txtBoxPassword.Text);
            Data.User user;

            if (loginValidation.ValidateUserInput(out user))
            {
                MainForm mainForm = new MainForm(user);
                mainForm.Visible = true;
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
