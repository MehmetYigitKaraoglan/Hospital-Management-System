namespace Hastane
{
    partial class RandevuUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuUpdate));
            this.txtMainMenu = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_Dakika = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_Saat = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.comboBox_Bolum = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.comboBox_Doktoradi = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_List = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneAnimateWindow1 = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_TCKN = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_HastaAdi = new System.Windows.Forms.TextBox();
            this.txt_HastaSoyadi = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_Telefon = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Update = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btn_Delete = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMainMenu
            // 
            this.txtMainMenu.AutoSize = true;
            this.txtMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.txtMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMainMenu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.txtMainMenu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtMainMenu.Location = new System.Drawing.Point(625, 373);
            this.txtMainMenu.Name = "txtMainMenu";
            this.txtMainMenu.Size = new System.Drawing.Size(85, 23);
            this.txtMainMenu.TabIndex = 83;
            this.txtMainMenu.Text = "Ana Menü";
            this.txtMainMenu.Click += new System.EventHandler(this.txtMainMenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 415);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(705, 169);
            this.dataGridView1.TabIndex = 66;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listeleme);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBox_Dakika);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboBox_Saat);
            this.groupBox2.Controls.Add(this.comboBox_Bolum);
            this.groupBox2.Controls.Add(this.comboBox_Doktoradi);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox2.Location = new System.Drawing.Point(307, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 321);
            this.groupBox2.TabIndex = 92;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hastane Bilgileri";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Animated = true;
            this.dateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.dateTimePicker1.BorderThickness = 2;
            this.dateTimePicker1.Checked = true;
            this.dateTimePicker1.FillColor = System.Drawing.Color.BlanchedAlmond;
            this.dateTimePicker1.Font = new System.Drawing.Font("Corbel", 12F);
            this.dateTimePicker1.ForeColor = System.Drawing.Color.DarkCyan;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker1.Location = new System.Drawing.Point(39, 173);
            this.dateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(334, 36);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateTimePicker1.UseTransparentBackground = true;
            this.dateTimePicker1.Value = new System.DateTime(2023, 1, 17, 14, 24, 34, 257);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(36, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Bölüm ";
            // 
            // comboBox_Dakika
            // 
            this.comboBox_Dakika.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_Dakika.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox_Dakika.BorderThickness = 2;
            this.comboBox_Dakika.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_Dakika.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Dakika.FillColor = System.Drawing.Color.BlanchedAlmond;
            this.comboBox_Dakika.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_Dakika.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_Dakika.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_Dakika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_Dakika.ItemHeight = 30;
            this.comboBox_Dakika.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.comboBox_Dakika.Location = new System.Drawing.Point(208, 219);
            this.comboBox_Dakika.Name = "comboBox_Dakika";
            this.comboBox_Dakika.Size = new System.Drawing.Size(165, 36);
            this.comboBox_Dakika.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.comboBox_Dakika.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(36, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 5;
            this.label11.Text = "Doktor Adı";
            // 
            // comboBox_Saat
            // 
            this.comboBox_Saat.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_Saat.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox_Saat.BorderThickness = 2;
            this.comboBox_Saat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_Saat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Saat.FillColor = System.Drawing.Color.BlanchedAlmond;
            this.comboBox_Saat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_Saat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_Saat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_Saat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_Saat.ItemHeight = 30;
            this.comboBox_Saat.Items.AddRange(new object[] {
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBox_Saat.Location = new System.Drawing.Point(39, 219);
            this.comboBox_Saat.Name = "comboBox_Saat";
            this.comboBox_Saat.Size = new System.Drawing.Size(165, 36);
            this.comboBox_Saat.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.comboBox_Saat.TabIndex = 8;
            // 
            // comboBox_Bolum
            // 
            this.comboBox_Bolum.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_Bolum.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox_Bolum.BorderRadius = 17;
            this.comboBox_Bolum.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.comboBox_Bolum.BorderThickness = 2;
            this.comboBox_Bolum.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_Bolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Bolum.FillColor = System.Drawing.Color.BlanchedAlmond;
            this.comboBox_Bolum.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_Bolum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_Bolum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_Bolum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_Bolum.ItemHeight = 30;
            this.comboBox_Bolum.Items.AddRange(new object[] {
            "Kardiyoloji",
            "Genel Cerrahi",
            "Psikiyatri",
            "Kulak-Burun-Boğaz",
            "Üroloji",
            "Dahiliye"});
            this.comboBox_Bolum.Location = new System.Drawing.Point(144, 76);
            this.comboBox_Bolum.Name = "comboBox_Bolum";
            this.comboBox_Bolum.Size = new System.Drawing.Size(229, 36);
            this.comboBox_Bolum.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.comboBox_Bolum.TabIndex = 5;
            this.comboBox_Bolum.SelectedIndexChanged += new System.EventHandler(this.comboBox_Bolum_SelectedIndexChanged);
            // 
            // comboBox_Doktoradi
            // 
            this.comboBox_Doktoradi.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_Doktoradi.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox_Doktoradi.BorderThickness = 2;
            this.comboBox_Doktoradi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_Doktoradi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Doktoradi.FillColor = System.Drawing.Color.BlanchedAlmond;
            this.comboBox_Doktoradi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_Doktoradi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_Doktoradi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_Doktoradi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_Doktoradi.ItemHeight = 30;
            this.comboBox_Doktoradi.Location = new System.Drawing.Point(144, 119);
            this.comboBox_Doktoradi.Name = "comboBox_Doktoradi";
            this.comboBox_Doktoradi.Size = new System.Drawing.Size(229, 36);
            this.comboBox_Doktoradi.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.comboBox_Doktoradi.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.DarkCyan;
            this.label12.Location = new System.Drawing.Point(6, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Adı";
            // 
            // btn_List
            // 
            this.btn_List.Animated = true;
            this.btn_List.BackColor = System.Drawing.Color.Transparent;
            this.btn_List.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btn_List.BorderRadius = 10;
            this.btn_List.BorderThickness = 1;
            this.btn_List.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_List.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_List.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_List.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_List.FillColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_List.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btn_List.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_List.Location = new System.Drawing.Point(12, 339);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(186, 57);
            this.btn_List.TabIndex = 93;
            this.btn_List.Text = "RANDEVULARI LİSTELE";
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(115, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 1);
            this.panel3.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(115, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 1);
            this.panel2.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(115, 185);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(125, 1);
            this.panel4.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(115, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 1);
            this.panel1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.txt_TCKN);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txt_HastaAdi);
            this.groupBox1.Controls.Add(this.txt_HastaSoyadi);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_Telefon);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Location = new System.Drawing.Point(12, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 200);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.DarkCyan;
            this.label13.Location = new System.Drawing.Point(6, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "Soyadı";
            // 
            // txt_TCKN
            // 
            this.txt_TCKN.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txt_TCKN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TCKN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_TCKN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_TCKN.Location = new System.Drawing.Point(114, 124);
            this.txt_TCKN.Multiline = true;
            this.txt_TCKN.Name = "txt_TCKN";
            this.txt_TCKN.Size = new System.Drawing.Size(126, 25);
            this.txt_TCKN.TabIndex = 3;
            this.txt_TCKN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TCKN_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.DarkCyan;
            this.label14.Location = new System.Drawing.Point(6, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 23);
            this.label14.TabIndex = 0;
            this.label14.Text = "Telefon";
            // 
            // txt_HastaAdi
            // 
            this.txt_HastaAdi.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txt_HastaAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_HastaAdi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_HastaAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_HastaAdi.Location = new System.Drawing.Point(114, 44);
            this.txt_HastaAdi.Multiline = true;
            this.txt_HastaAdi.Name = "txt_HastaAdi";
            this.txt_HastaAdi.Size = new System.Drawing.Size(126, 25);
            this.txt_HastaAdi.TabIndex = 1;
            // 
            // txt_HastaSoyadi
            // 
            this.txt_HastaSoyadi.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txt_HastaSoyadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_HastaSoyadi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_HastaSoyadi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_HastaSoyadi.Location = new System.Drawing.Point(114, 84);
            this.txt_HastaSoyadi.Multiline = true;
            this.txt_HastaSoyadi.Name = "txt_HastaSoyadi";
            this.txt_HastaSoyadi.Size = new System.Drawing.Size(126, 25);
            this.txt_HastaSoyadi.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(6, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 20);
            this.textBox1.TabIndex = 78;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.DarkCyan;
            this.label15.Location = new System.Drawing.Point(6, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 23);
            this.label15.TabIndex = 0;
            this.label15.Text = "Kimlik No";
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txt_Telefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Telefon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Telefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_Telefon.Location = new System.Drawing.Point(114, 164);
            this.txt_Telefon.Multiline = true;
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.Size = new System.Drawing.Size(126, 25);
            this.txt_Telefon.TabIndex = 4;
            this.txt_Telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telefon_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Update
            // 
            this.btn_Update.Animated = true;
            this.btn_Update.BackColor = System.Drawing.Color.Transparent;
            this.btn_Update.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Update.BorderRadius = 10;
            this.btn_Update.BorderThickness = 1;
            this.btn_Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Update.FillColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Update.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Update.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Update.Location = new System.Drawing.Point(204, 339);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(186, 57);
            this.btn_Update.TabIndex = 93;
            this.btn_Update.Text = "RANDEVU GÜNCELLE";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Animated = true;
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Delete.BorderRadius = 10;
            this.btn_Delete.BorderThickness = 1;
            this.btn_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Delete.FillColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Delete.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Delete.Location = new System.Drawing.Point(396, 339);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(186, 57);
            this.btn_Delete.TabIndex = 93;
            this.btn_Delete.Text = "RANDEVU SİL";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // RandevuUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(722, 587);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_List);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMainMenu);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RandevuUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Güncelleme";
            this.Load += new System.EventHandler(this.HastaEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtMainMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox comboBox_Dakika;
        private System.Windows.Forms.Label label11;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox comboBox_Saat;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox comboBox_Bolum;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox comboBox_Doktoradi;
        private System.Windows.Forms.Label label12;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btn_List;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_TCKN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_HastaAdi;
        private System.Windows.Forms.TextBox txt_HastaSoyadi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_Telefon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btn_Update;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btn_Delete;
    }
}