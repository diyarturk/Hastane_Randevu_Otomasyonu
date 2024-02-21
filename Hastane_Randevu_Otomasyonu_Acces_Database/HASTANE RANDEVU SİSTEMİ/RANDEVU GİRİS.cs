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
    public partial class Form1 : Form
    {
       
       OleDbConnection baglantiac1 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=randevusistemi.accdb;Persist Security Info=False;");
        public Form1()
        {
            InitializeComponent();
        
         }
        private void btn_yeniüye_Click(object sender, EventArgs e)
        {
            YENİÜYE yeniac = new YENİÜYE();
            yeniac.Show();
            this.Hide();
        }

        private void txt_tck_KeyPress(object sender, KeyPressEventArgs e)
        {          
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;       
            else
                e.Handled = false;
        }
        void sayiüret()
        { 
           Random rast = new Random();
           LBL_RAST.Text = rast.Next(10000,99999).ToString();
           //txt_kodkimlik.Text = LBL_RAST.Text;
           ToolTip RAST = new ToolTip();
           toolTip1.SetToolTip(LBL_RAST,LBL_RAST.Text); 
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            sayiüret();

        }
        private void btn_degistir_Click(object sender, EventArgs e)
        {
            sayiüret();
        }
        int Mov;
        int mx;
        int my;
        private void label7_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (Mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void label7_MouseDown_1(object sender, MouseEventArgs e)
        {
            Mov = 1;
            mx = e.X;
            my = e.Y;
        }

        private void label7_MouseUp_1(object sender, MouseEventArgs e)
        {
            Mov = 0;
              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txt_sifrekimlik.PasswordChar == '*')
            {
                txt_sifrekimlik.PasswordChar = '\0';
            }
            else
            {
             txt_sifrekimlik.PasswordChar = '*';
            }           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            PAROLA_UNUTTUM hatirlat = new PAROLA_UNUTTUM();
            hatirlat.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PAROLA_UNUTTUM hatirlat = new PAROLA_UNUTTUM();
            hatirlat.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YENİÜYE yeniac = new YENİÜYE();
            yeniac.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_kodkimlik.Text==""||txt_sifrekimlik.Text==""||txt_tckimlik.Text=="")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız...","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                 giris girisyap2 = new giris();
                 girisyap2.girisyap(txt_tckimlik.Text, txt_sifrekimlik.Text,LBL_RAST.Text,txt_kodkimlik.Text);     
            }
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;
            
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void txt_tckimlik_Click(object sender, EventArgs e)
        {
            txt_tckimlik.Text = "";
            txt_tckimlik.ForeColor = Color.Black;
        }

        private void txt_sifrekimlik_Click(object sender, EventArgs e)
        {
            txt_sifrekimlik.Text = "";
            txt_sifrekimlik.PasswordChar = '*';
            txt_sifrekimlik.ForeColor = Color.Black;
        }

        private void txt_kodkimlik_Click(object sender, EventArgs e)
        {
            txt_kodkimlik.Text = "";
            txt_kodkimlik.ForeColor = Color.Black;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.microsoft.com/tr-tr/p/mhrs-mobil/9nrfcmk93ns0?activetab=pivot%3Aoverviewtab"); 
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://play.google.com/store/apps/details?id=tr.com.innova.fta.mhrs&hl=tr"); 
        }

        private void pictureBox4_Click_3(object sender, EventArgs e)
        {
          System.Diagnostics.Process.Start("https://itunes.apple.com/tr/app/mhrs-mobil/id589804718?l=tr&mt=8"); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminGirisi ac = new AdminGirisi();
            ac.ShowDialog();
            this.Hide();
        }

        private void txt_sifrekimlik_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void txt_sifrekimlik_TabStopChanged(object sender, EventArgs e)
        {
        }

    }
}
