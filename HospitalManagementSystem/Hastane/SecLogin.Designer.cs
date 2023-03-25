namespace Hastane
{
    partial class SecLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecLogin));
            this.txtUser2 = new System.Windows.Forms.TextBox();
            this.exitTxt2 = new System.Windows.Forms.Label();
            this.clearFieldsTxt2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginTxt2 = new System.Windows.Forms.Label();
            this.usernamePic2 = new System.Windows.Forms.PictureBox();
            this.passwordPic2 = new System.Windows.Forms.PictureBox();
            this.loginPic2 = new System.Windows.Forms.PictureBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtPw2 = new System.Windows.Forms.TextBox();
            this.btn_ShowPw = new System.Windows.Forms.Button();
            this.btn_HidePw = new System.Windows.Forms.Button();
            this.mainmenuTxt = new System.Windows.Forms.Label();
            this.btn_Login = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPic2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser2
            // 
            this.txtUser2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(199)))), ((int)(((byte)(222)))));
            this.txtUser2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUser2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUser2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtUser2.Location = new System.Drawing.Point(62, 231);
            this.txtUser2.Multiline = true;
            this.txtUser2.Name = "txtUser2";
            this.txtUser2.Size = new System.Drawing.Size(224, 24);
            this.txtUser2.TabIndex = 2;
            this.txtUser2.Text = "Kullanıcı Adınız";
            this.txtUser2.Enter += new System.EventHandler(this.txtUserEnter2);
            this.txtUser2.Leave += new System.EventHandler(this.txtUserLeave2);
            // 
            // exitTxt2
            // 
            this.exitTxt2.AutoSize = true;
            this.exitTxt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitTxt2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.exitTxt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitTxt2.Location = new System.Drawing.Point(241, 413);
            this.exitTxt2.Name = "exitTxt2";
            this.exitTxt2.Size = new System.Drawing.Size(45, 23);
            this.exitTxt2.TabIndex = 33;
            this.exitTxt2.Text = "Çıkış";
            this.exitTxt2.Click += new System.EventHandler(this.exitTxt_Click);
            // 
            // clearFieldsTxt2
            // 
            this.clearFieldsTxt2.AutoSize = true;
            this.clearFieldsTxt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearFieldsTxt2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.clearFieldsTxt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearFieldsTxt2.Location = new System.Drawing.Point(153, 335);
            this.clearFieldsTxt2.Name = "clearFieldsTxt2";
            this.clearFieldsTxt2.Size = new System.Drawing.Size(133, 23);
            this.clearFieldsTxt2.TabIndex = 4;
            this.clearFieldsTxt2.Text = "Alanları Temizle";
            this.clearFieldsTxt2.Click += new System.EventHandler(this.clearFieldsTxt2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Location = new System.Drawing.Point(26, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 1);
            this.panel2.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Location = new System.Drawing.Point(26, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 1);
            this.panel1.TabIndex = 27;
            // 
            // loginTxt2
            // 
            this.loginTxt2.AutoSize = true;
            this.loginTxt2.Font = new System.Drawing.Font("MV Boli", 24F);
            this.loginTxt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginTxt2.Location = new System.Drawing.Point(31, 164);
            this.loginTxt2.Name = "loginTxt2";
            this.loginTxt2.Size = new System.Drawing.Size(255, 41);
            this.loginTxt2.TabIndex = 26;
            this.loginTxt2.Text = "Secretary Login";
            this.loginTxt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernamePic2
            // 
            this.usernamePic2.Image = ((System.Drawing.Image)(resources.GetObject("usernamePic2.Image")));
            this.usernamePic2.Location = new System.Drawing.Point(26, 225);
            this.usernamePic2.Name = "usernamePic2";
            this.usernamePic2.Size = new System.Drawing.Size(30, 30);
            this.usernamePic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usernamePic2.TabIndex = 30;
            this.usernamePic2.TabStop = false;
            // 
            // passwordPic2
            // 
            this.passwordPic2.Image = ((System.Drawing.Image)(resources.GetObject("passwordPic2.Image")));
            this.passwordPic2.Location = new System.Drawing.Point(26, 282);
            this.passwordPic2.Name = "passwordPic2";
            this.passwordPic2.Size = new System.Drawing.Size(30, 30);
            this.passwordPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordPic2.TabIndex = 28;
            this.passwordPic2.TabStop = false;
            // 
            // loginPic2
            // 
            this.loginPic2.Image = ((System.Drawing.Image)(resources.GetObject("loginPic2.Image")));
            this.loginPic2.Location = new System.Drawing.Point(91, 33);
            this.loginPic2.Name = "loginPic2";
            this.loginPic2.Size = new System.Drawing.Size(128, 128);
            this.loginPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginPic2.TabIndex = 25;
            this.loginPic2.TabStop = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "eye.png");
            this.ımageList1.Images.SetKeyName(1, "view.png");
            // 
            // txtPw2
            // 
            this.txtPw2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(199)))), ((int)(((byte)(222)))));
            this.txtPw2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPw2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPw2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPw2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtPw2.Location = new System.Drawing.Point(62, 288);
            this.txtPw2.Multiline = true;
            this.txtPw2.Name = "txtPw2";
            this.txtPw2.PasswordChar = '*';
            this.txtPw2.Size = new System.Drawing.Size(224, 20);
            this.txtPw2.TabIndex = 3;
            this.txtPw2.Text = "********";
            this.txtPw2.Enter += new System.EventHandler(this.txtPwEnter2);
            this.txtPw2.Leave += new System.EventHandler(this.txtPwLeave2);
            // 
            // btn_ShowPw
            // 
            this.btn_ShowPw.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_ShowPw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowPw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(199)))), ((int)(((byte)(222)))));
            this.btn_ShowPw.ImageKey = "eye.png";
            this.btn_ShowPw.ImageList = this.ımageList1;
            this.btn_ShowPw.Location = new System.Drawing.Point(260, 286);
            this.btn_ShowPw.Name = "btn_ShowPw";
            this.btn_ShowPw.Size = new System.Drawing.Size(26, 26);
            this.btn_ShowPw.TabIndex = 39;
            this.btn_ShowPw.UseVisualStyleBackColor = true;
            this.btn_ShowPw.Click += new System.EventHandler(this.btn_ShowPw_Click);
            // 
            // btn_HidePw
            // 
            this.btn_HidePw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HidePw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(199)))), ((int)(((byte)(222)))));
            this.btn_HidePw.ImageKey = "view.png";
            this.btn_HidePw.ImageList = this.ımageList1;
            this.btn_HidePw.Location = new System.Drawing.Point(260, 286);
            this.btn_HidePw.Name = "btn_HidePw";
            this.btn_HidePw.Size = new System.Drawing.Size(26, 26);
            this.btn_HidePw.TabIndex = 40;
            this.btn_HidePw.UseVisualStyleBackColor = true;
            this.btn_HidePw.Click += new System.EventHandler(this.btn_HidePw_Click);
            // 
            // mainmenuTxt
            // 
            this.mainmenuTxt.AutoSize = true;
            this.mainmenuTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainmenuTxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.mainmenuTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainmenuTxt.Location = new System.Drawing.Point(22, 413);
            this.mainmenuTxt.Name = "mainmenuTxt";
            this.mainmenuTxt.Size = new System.Drawing.Size(92, 23);
            this.mainmenuTxt.TabIndex = 41;
            this.mainmenuTxt.Text = "Ana Sayfa";
            this.mainmenuTxt.Click += new System.EventHandler(this.mainmenuTxt_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BorderRadius = 10;
            this.btn_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Login.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(199)))), ((int)(((byte)(222)))));
            this.btn_Login.Location = new System.Drawing.Point(26, 361);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(260, 35);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "Giriş Yap";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // SecLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(199)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(312, 467);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.mainmenuTxt);
            this.Controls.Add(this.btn_ShowPw);
            this.Controls.Add(this.btn_HidePw);
            this.Controls.Add(this.txtPw2);
            this.Controls.Add(this.txtUser2);
            this.Controls.Add(this.exitTxt2);
            this.Controls.Add(this.clearFieldsTxt2);
            this.Controls.Add(this.usernamePic2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.passwordPic2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginTxt2);
            this.Controls.Add(this.loginPic2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SecLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Girişi";
            this.Load += new System.EventHandler(this.SecLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usernamePic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUser2;
        private System.Windows.Forms.Label exitTxt2;
        private System.Windows.Forms.Label clearFieldsTxt2;
        private System.Windows.Forms.PictureBox usernamePic2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox passwordPic2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginTxt2;
        private System.Windows.Forms.PictureBox loginPic2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox txtPw2;
        private System.Windows.Forms.Button btn_ShowPw;
        private System.Windows.Forms.Button btn_HidePw;
        private System.Windows.Forms.Label mainmenuTxt;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btn_Login;
    }
}