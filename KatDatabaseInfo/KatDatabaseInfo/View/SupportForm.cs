using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatDatabaseInfo.View
{
    public partial class SupportForm : Form
    {
        public SupportForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            try
            {
                SmtpClient client = new SmtpClient();

                string server = GetServerName();

                if (server.Contains("gmail"))
                {
                    client.Port = 587;
                }
                else
                {
                    client.Port = 456;
                }

                client.Host = server;
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(txtBoxFrom.Text, txtBoxPassword.Text);

                MailMessage mail = new MailMessage(txtBoxFrom.Text, "toni.krasimirova@gmail.com", txtBoxSubject.Text, txtBoxMessage.Text);
                mail.BodyEncoding = UTF8Encoding.UTF8;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mail);
                MessageBox.Show("Съобщението е изпратено.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot send message: " + ex.Message + "\nЗа момента поддържаме изпращане на съобщения само от gmail");
            }

        }


        private string GetServerName()
        {
            return "smtp." + txtBoxFrom.Text.Split('@')[1];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

