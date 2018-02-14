using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System_EF.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (cmbPosition.Text == "Manager")
            {
                if (txtUserName == null || txtPassword == null)
                {
                    MessageBox.Show("Please Fill the Field");
                }
                else
                {
                    string userName = txtUserName.Text;
                    string password = txtPassword.Text;
                    if (userName == "admin" && password == "admin")
                    {
                        OpeningForm op = new OpeningForm();
                        op.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please try to valid authentication");
                    }

                }


            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            this.Close();
        }
    }
}
