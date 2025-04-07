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
    public partial class F01_Welcome : Form
    {
        public F01_Welcome()
        {
            InitializeComponent();
        }

        private void proceed_btn_Click(object sender, EventArgs e)
        {
            new F02_AdminOrUser().Show();
            this.Hide();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
