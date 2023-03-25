namespace Hastane
{
    partial class Opening
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opening));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DocLogin = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btn_SecLogin = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btn_Close = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(226, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Karaoğlan Hastanesi";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // btn_DocLogin
            // 
            this.btn_DocLogin.Animated = true;
            this.btn_DocLogin.AutoRoundedCorners = true;
            this.btn_DocLogin.BackColor = System.Drawing.Color.Transparent;
            this.btn_DocLogin.BorderRadius = 21;
            this.btn_DocLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DocLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DocLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DocLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DocLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(199)))), ((int)(((byte)(162)))));
            this.btn_DocLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btn_DocLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btn_DocLogin.Location = new System.Drawing.Point(378, 43);
            this.btn_DocLogin.Name = "btn_DocLogin";
            this.btn_DocLogin.Size = new System.Drawing.Size(180, 45);
            this.btn_DocLogin.TabIndex = 22;
            this.btn_DocLogin.Text = "Doktor Girişi";
            this.btn_DocLogin.Click += new System.EventHandler(this.btn_DocLogin_Click);
            // 
            // btn_SecLogin
            // 
            this.btn_SecLogin.Animated = true;
            this.btn_SecLogin.AutoRoundedCorners = true;
            this.btn_SecLogin.BackColor = System.Drawing.Color.Transparent;
            this.btn_SecLogin.BorderRadius = 21;
            this.btn_SecLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_SecLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_SecLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_SecLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_SecLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.btn_SecLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btn_SecLogin.ForeColor = System.Drawing.Color.Snow;
            this.btn_SecLogin.Location = new System.Drawing.Point(378, 173);
            this.btn_SecLogin.Name = "btn_SecLogin";
            this.btn_SecLogin.Size = new System.Drawing.Size(180, 45);
            this.btn_SecLogin.TabIndex = 23;
            this.btn_SecLogin.Text = "Sekreter Girişi";
            this.btn_SecLogin.Click += new System.EventHandler(this.btn_SecLogin_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Animated = true;
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Close.ForeColor = System.Drawing.Color.Black;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(555, 8);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btn_Close.Size = new System.Drawing.Size(30, 29);
            this.btn_Close.TabIndex = 24;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Opening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 360);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_SecLogin);
            this.Controls.Add(this.btn_DocLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Opening";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Opening_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Opening_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Opening_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Opening_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btn_DocLogin;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btn_SecLogin;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btn_Close;
    }
}