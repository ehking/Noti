namespace Noti
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.url_ch_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.captcha = new System.Windows.Forms.TextBox();
            this.captcha_img = new System.Windows.Forms.PictureBox();
            this.reload_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captcha_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reload_img)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 66);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // url
            // 
            this.url.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.url.Location = new System.Drawing.Point(12, 182);
            this.url.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(258, 22);
            this.url.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "آدرس اتوماسیون";
            // 
            // url_ch_btn
            // 
            this.url_ch_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.url_ch_btn.ForeColor = System.Drawing.Color.White;
            this.url_ch_btn.Location = new System.Drawing.Point(94, 230);
            this.url_ch_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.url_ch_btn.Name = "url_ch_btn";
            this.url_ch_btn.Size = new System.Drawing.Size(100, 34);
            this.url_ch_btn.TabIndex = 3;
            this.url_ch_btn.Text = "مرحله بعد";
            this.url_ch_btn.UseVisualStyleBackColor = false;
            this.url_ch_btn.Click += new System.EventHandler(this.url_ch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(71, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "© Copyright 2019 Samatoos";
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Username.Location = new System.Drawing.Point(29, 182);
            this.Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Username.Multiline = true;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(229, 29);
            this.Username.TabIndex = 5;
            this.Username.Visible = false;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Password.Location = new System.Drawing.Point(29, 247);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(229, 29);
            this.Password.TabIndex = 6;
            this.Password.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "نام کاربری";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "گذرواژه";
            this.label4.Visible = false;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(83, 340);
            this.login_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(100, 34);
            this.login_btn.TabIndex = 9;
            this.login_btn.Text = "ورود";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Visible = false;
            // 
            // captcha
            // 
            this.captcha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.captcha.Location = new System.Drawing.Point(161, 300);
            this.captcha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.captcha.Multiline = true;
            this.captcha.Name = "captcha";
            this.captcha.Size = new System.Drawing.Size(97, 25);
            this.captcha.TabIndex = 10;
            this.captcha.Visible = false;
            // 
            // captcha_img
            // 
            this.captcha_img.Image = ((System.Drawing.Image)(resources.GetObject("captcha_img.Image")));
            this.captcha_img.Location = new System.Drawing.Point(42, 290);
            this.captcha_img.Name = "captcha_img";
            this.captcha_img.Size = new System.Drawing.Size(100, 44);
            this.captcha_img.TabIndex = 11;
            this.captcha_img.TabStop = false;
            this.captcha_img.Visible = false;
            // 
            // reload_img
            // 
            this.reload_img.Image = ((System.Drawing.Image)(resources.GetObject("reload_img.Image")));
            this.reload_img.Location = new System.Drawing.Point(12, 290);
            this.reload_img.Name = "reload_img";
            this.reload_img.Size = new System.Drawing.Size(24, 25);
            this.reload_img.TabIndex = 12;
            this.reload_img.TabStop = false;
            this.reload_img.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 403);
            this.Controls.Add(this.reload_img);
            this.Controls.Add(this.captcha_img);
            this.Controls.Add(this.captcha);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.url_ch_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.url);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم ورود ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captcha_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reload_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button url_ch_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox captcha;
        private System.Windows.Forms.PictureBox captcha_img;
        private System.Windows.Forms.PictureBox reload_img;
    }
}