using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noti
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void url_ch_Click(object sender, EventArgs e)
        {
            if (check_url())
            {
                if (hide_url_show_login_form())
                {
                    if (check_url_captcha())
                    {
                        show_captch();
                    }   
                }
               
            }

        }

        public void show_captch()
        {
            captcha.Visible = true;
            captcha_img.Visible = true;
            reload_img.Visible = true;

        }
    public Boolean check_url_captcha()
        {
            return true;
        }
       public Boolean hide_url_show_login_form()
        {

            /// true 
            label3.Visible = true;
            label4.Visible = true;
            Username.Visible = true;
            Password.Visible = true;
            login_btn.Visible = true;

            //false
            label1.Visible = false;
            url.Visible = false;
            url_ch_btn.Visible = false;
            captcha.Visible = false;
            captcha_img.Visible = false;
            reload_img.Visible = false;


            return true;
        }

        public Boolean hide_login_show_url_form()
        {

            /// false 
            label3.Visible = false;
            label4.Visible = false;
            Username.Visible = false;
            Password.Visible = false;
            login_btn.Visible = false;
            captcha.Visible = false;
            captcha_img.Visible = false;
            reload_img.Visible = false;

            //true
            label1.Visible = true;
            url.Visible = true;
            url_ch_btn.Visible = true;

      
            return true;
        }


        public Boolean check_url()
        {
            MyWebRequest re = new MyWebRequest("http://oasdemypeyvand.ir/UI/login.php","GET");
            MessageBox.Show(re.GetResponse());

            
            return true;
           // return false;
        }
    }
}
