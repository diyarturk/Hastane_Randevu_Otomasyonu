using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HASTANE_RANDEVU_SİSTEMİ
{
    public partial class AdminGirisi : Form
    {
        public AdminGirisi()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminpaneli ac=new adminpaneli();
            if (ac.admingirisi(txt_kad.Text, txt_siffre.Text) == 1)
            {
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = 1;
            mx = e.X;
            my = e.Y;
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
          if (Mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }
        int Mov;
        int mx;
        int my;
        private void label7_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = 0;
        }
    }
}
