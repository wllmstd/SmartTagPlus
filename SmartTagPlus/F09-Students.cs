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
    public partial class F09_Students : Form
    {
        public F09_Students()
        {
            InitializeComponent();
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            new F07_Dashboard().Show();
            this.Hide();
        }

        private void records_btn_Click(object sender, EventArgs e)
        {
            new F08_Records().Show();
            this.Hide();
        }

        private void calendar_btn_Click(object sender, EventArgs e)
        {
            new F10_Calendar().Show();
            this.Hide();
        }

        private void news_btn_Click(object sender, EventArgs e)
        {
            new F11_News().Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            new F12_ConfirmLogOut().Show();
            this.Hide();
        }


    }
}
