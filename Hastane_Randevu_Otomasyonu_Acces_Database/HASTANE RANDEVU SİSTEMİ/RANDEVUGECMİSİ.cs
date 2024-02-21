using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HASTANE_RANDEVU_SİSTEMİ
{
    public partial class randevuekrani : Form
    {
        string tcn = "";
        public randevuekrani(string tc)
        {
            InitializeComponent();
            tcn = tc;
        }
        private void RANDEVUGECMİSİ_Load(object sender, EventArgs e)
        {
            randevuguncelle();
        }
        void randevuguncelle()
        {
            randevugoster randevular = new randevugoster();
            randevular.listviewGuncelle(randevugoster, tcn);
        }

        int Mov, mx, my;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        { 
            Mov = 1;
            mx = e.X;
            my = e.Y;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        { if (Mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
           Mov = 0;
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            randevugoster iptal = new randevugoster();
            iptal.randevuiptalet(randevugoster, tcn);
        }
    }
}
