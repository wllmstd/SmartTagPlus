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
    public partial class F02_AdminOrUser : Form
    {
        public F02_AdminOrUser()
        {
            InitializeComponent();
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            new F03_LogIn().Show();
            this.Hide();
        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            new F06_InOrOut().Show();
            this.Hide();
        }
    }
}
