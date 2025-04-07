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
    public partial class F06_InOrOut : Form
    {
        public F06_InOrOut()
        {
            InitializeComponent();
        }

        private void timein_btn_Click(object sender, EventArgs e)
        {
            new F04_SignIn().Show();
            this.Hide();
        }

        private void timeout_btn_Click(object sender, EventArgs e)
        {
            new F05_SignOut().Show();
            this.Hide();
        }
    }
}
