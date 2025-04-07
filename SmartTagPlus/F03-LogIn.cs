using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTagPlus
{
    public partial class F03_LogIn : Form
    {
        public F03_LogIn()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            // Get the text entered by the user
            string username = USN.Text;
            string password = PSW.Text;

            // Check if the credentials match
            if (username == "admin" && password == "admin123")
            {
                // Credentials are correct, proceed to the next form
                new F07_Dashboard().Show();
                this.Hide();
            }
            else
            {
                // Incorrect credentials, show a message
                MessageBox.Show("Wrong credentials, please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
