using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Noti

{

    public partial class Login : Form

    {

      public TimeoutWebClient req = new TimeoutWebClient();
        public Login()
        {
            InitializeComponent();
           
        }

        private void url_ch_Click(object sender, EventArgs e)
        {
            
            if (check_url(url.Text))
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
           // req.DownloadData("");
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


        public Boolean check_url(string url_oa)
        {
            if (url_oa == "")
            {
                MessageBox.Show("آدرس را وارد کنید!!!");
                return false;
            }
            else
            {
                int start_po = url_oa.IndexOf("UI");
                if (start_po == -1)
                {
                    MessageBox.Show("آدرس وارد شده نادرست میباشد");
                    return false;
                }
                else
                {
                    string url_pro=convert_url(url_oa);
                    if (save_seeting("url", url_pro))
                    {
                        return true;
                    }

                }
            }
            MessageBox.Show("آدرس وارد شده نادرست میباشد");
            return false;
            
          
               // WebClient r = new WebClient();
                //r.QueryString.Add("module", "Login");
               // r.QueryString.Add("action", "getSalt");
               // r.QueryString.Add("uname", "baghbanan");
                
              //  int stringPosition = url_o.IndexOf("UI");
              
                //MessageBox.Show(url_o);
               
               // MessageBox.Show(stringPosition.ToString());
                //MessageBox.Show(url_o.Remove(stringPosition));
                //string responsebytes = r.DownloadString("");

                //  r.Ti
                // MessageBox.Show(responsebytes);
                //client = new HttpClient();

                //MyWebRequest re = new MyWebRequest(url.Text, "GET");
                // string s = re.GetResponse();
                //MessageBox.Show(s);

                // captcha_img.Load(" http://172.16.86.3/OfficeAS/Runtime/process.php?rand=0.9902902313764774&module=Captcha&action=show&width=173&height=50");
           // return false;
        }

   
        public string GET_Salt(WebClient r,string username)
        {
            try
            {
                r.QueryString.Add("module", "Login");
                r.QueryString.Add("action", "getSalt");
                r.QueryString.Add("uname", username);
                string res = r.DownloadString(Properties.Settings.Default.web_url);
                
                res = res.Replace(@"(", "");
                res = res.Replace(@")", "");
                res = res.Replace("\"", "");

                return res;
            }catch(WebException e)
            {
                MessageBox.Show(e.Message);
                return "error";
            }
        }
        public string convert_url(string url_oas)
        {
            int start_pos= url_oas.IndexOf("UI");
            string u = url_oas.Remove(start_pos);
            return  u+ "Runtime/process.php";
        }

        public Boolean save_seeting(string key,string value)
        {
            switch (key)
            {
                case "url":
                    Properties.Settings.Default.web_url=value ;
                    break;
                case "time":
                    Properties.Settings.Default.timer_synce = Convert.ToInt32(value);
                    break;
            }

            return true;
        }
    }
}
