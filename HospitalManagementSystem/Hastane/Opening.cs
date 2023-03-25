using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane
{
    public partial class Opening : Form
    {
        public Opening()
        {
            InitializeComponent();
        }

        private void btn_doktor_Click(object sender, EventArgs e)
        {
            DocLogin loginScreen = new DocLogin();
            loginScreen.Show();
            this.Hide();

        }
        private void btn_DocLogin_Click(object sender, EventArgs e)
        {
            DocLogin loginScreen = new DocLogin();
            loginScreen.Show();
            this.Hide();
        }

        private void btn_SecLogin_Click(object sender, EventArgs e)
        {
            SecLogin loginScreen = new SecLogin();
            loginScreen.Show();
            this.Hide();
        }


        private bool isMouseDown = false;
        private Point lastLocation;

        private void Opening_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastLocation = e.Location;
        }

        private void Opening_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Opening_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Opening_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamayı kapatmak istediğinize emin misiniz?", "Hastane", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastLocation = e.Location;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}
