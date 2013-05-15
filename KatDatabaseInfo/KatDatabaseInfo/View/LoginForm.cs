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
        public Data.User user { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            user = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginValidation loginValidation = new LoginValidation(txtBoxUsername.Text, txtBoxPassword.Text);
            Data.User user;

            if (loginValidation.ValidateUserInput(out user))
            {
                this.user = user;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(loginValidation.errText);
            } 
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
       
    }
}
