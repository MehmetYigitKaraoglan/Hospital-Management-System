namespace Hastane
{
    partial class DocLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocLogin));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.exitTxt = new System.Windows.Forms.Label();
            this.clearFieldsTxt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernamePic = new System.Windows.Forms.PictureBox();
            this.passwordPic = new System.Windows.Forms.PictureBox();
            this.loginPic = new System.Windows.Forms.PictureBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtPw = new System.Windows.Forms.TextBox();
            this.btn_HidePw = new System.Windows.Forms.Button();
            this.btn_ShowPw = new System.Windows.Forms.Button();
            this.mainmenuTxt = new System.Windows.Forms.Label();
            this.btn_Login = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.loginTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(199)))), ((int)(((byte)(222)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUser.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtUser.Location = new System.Drawing.Point(62, 231);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(224, 17);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "Kullanıcı Adınız";
            this.txtUser.Enter += new System.EventHandler(this.txtUserEnter);
            this.txtUser.Leave += new System.EventHandler(this.txtUserLeave);
            // 
            // exitTxt
            // 
            this.exitTxt.AutoSize = true;
            this.exitTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitTxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.exitTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitTxt.Location = new System.Drawing.Point(241, 413);
            this.exitTxt.Name = "exitTxt";
            this.exitTxt.Size = new System.Drawing.Size(45, 23);
            this.exitTxt.TabIndex = 6;
            this.exitTxt.Text = "Çıkış";
            this.exitTxt.Click += new System.EventHandler(this.exitTxt_Click);
            // 
            // clearFieldsTxt
            // 
            this.clearFieldsTxt.AutoSize = true;
            this.clearFieldsTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearFieldsTxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.clearFieldsTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearFieldsTxt.Location = new System.Drawing.Point(153, 335);
            this.clearFieldsTxt.Name = "clearFieldsTxt";
            this.clearFieldsTxt.Size = new System.Drawing.Size(133, 23);
            this.clearFieldsTxt.TabIndex = 4;
            this.clearFieldsTxt.Text = "Alanları Temizle";
            this.clearFieldsTxt.Click += new System.EventHandler(this.clearFieldsTxt_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Location = new System.Drawing.Point(26, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 1);
            this.panel2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Location = new System.Drawing.Point(26, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 1);
            this.panel1.TabIndex = 16;
            // 
            // usernamePic
            // 
            this.usernamePic.Image = ((System.Drawing.Image)(resources.GetObject("usernamePic.Image")));
            this.usernamePic.Location = new System.Drawing.Point(26, 225);
            this.usernamePic.Name = "usernamePic";
            this.usernamePic.Size = new System.Drawing.Size(30, 30);
            this.usernamePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usernamePic.TabIndex = 19;
            this.usernamePic.TabStop = false;
            // 
            // passwordPic
            // 
            this.passwordPic.Image = ((System.Drawing.Image)(resources.GetObject("passwordPic.Image")));
            this.passwordPic.Location = new System.Drawing.Point(26, 282);
            this.passwordPic.Name = "passwordPic";
            this.passwordPic.Size = new System.Drawing.Size(30, 30);
            this.passwordPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordPic.TabIndex = 17;
            this.passwordPic.TabStop = false;
            // 
            // loginPic
            // 
            this.loginPic.Image = ((System.Drawing.Image)(resources.GetObject("loginPic.Image")));
            this.loginPic.Location = new System.Drawing.Point(91, 33);
            this.loginPic.Name = "loginPic";
            this.loginPic.Size = new System.Drawing.Size(128, 128);
            this.loginPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginPic.TabIndex = 14;
            this.loginPic.TabStop = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "eye.png");
            this.ımageList1.Images.SetKeyName(1, "view.png");
            // 
            // txtPw
            // 
            this.txtPw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(199)))), ((int)(((byte)(222)))));
            this.txtPw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPw.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtPw.Location = new System.Drawing.Point(62, 288);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '*';
            this.txtPw.Size = new System.Drawing.Size(224, 17);
            this.txtPw.TabIndex = 3;
            this.txtPw.Text = "********";
            this.txtPw.Enter += new System.EventHandler(this.txtPwEnter);
            this.txtPw.Leave += new System.EventHandler(this.txtPwLeave);
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
            this.btn_HidePw.TabIndex = 28;
            this.btn_HidePw.UseVisualStyleBackColor = true;
            this.btn_HidePw.Click += new System.EventHandler(this.btn_HidePw_Click);
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
            this.btn_ShowPw.TabIndex = 28;
            this.btn_ShowPw.UseVisualStyleBackColor = true;
            this.btn_ShowPw.Click += new System.EventHandler(this.btn_ShowPw_Click);
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
            this.mainmenuTxt.TabIndex = 5;
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
            // loginTxt
            // 
            this.loginTxt.AutoSize = true;
            this.loginTxt.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginTxt.Location = new System.Drawing.Point(55, 164);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(212, 41);
            this.loginTxt.TabIndex = 15;
            this.loginTxt.Text = "Doctor Login";
            this.loginTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DocLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(199)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(312, 467);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.mainmenuTxt);
            this.Controls.Add(this.btn_ShowPw);
            this.Controls.Add(this.btn_HidePw);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.exitTxt);
            this.Controls.Add(this.clearFieldsTxt);
            this.Controls.Add(this.usernamePic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.passwordPic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginTxt);
            this.Controls.Add(this.loginPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DocLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Girişi";
            this.Load += new System.EventHandler(this.DocLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usernamePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label exitTxt;
        private System.Windows.Forms.Label clearFieldsTxt;
        private System.Windows.Forms.PictureBox usernamePic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox passwordPic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox loginPic;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Button btn_HidePw;
        private System.Windows.Forms.Button btn_ShowPw;
        private System.Windows.Forms.Label mainmenuTxt;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btn_Login;
        private System.Windows.Forms.Label loginTxt;
    }
}