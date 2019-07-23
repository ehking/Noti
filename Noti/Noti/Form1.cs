using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Noti
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Login login = new Login();
            Loading loading = new Loading();
            login.Show();
            loading.Hide();
            loading.Close();
            timer1.Enabled = false;

            if (label2.Text == ".........")
            {
                label2.Text = "";
               
            }
            else
            {
                label2.Text += ".";
            }
               

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
