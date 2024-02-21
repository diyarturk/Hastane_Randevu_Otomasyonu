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
    public partial class bilgiguncelle : Form
    {
        string tcc = "";
        string parolla = "";
        public bilgiguncelle(string tc,string parola)
        {
            InitializeComponent();
            tcc = tc;
            parolla = parola;
        }
        OleDbConnection baglantiac = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=randevusistemi.accdb;Persist Security Info=False;");
        private void bilgiguncelle_Load(object sender, EventArgs e)
        {
            baglantiac.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM YeniUye WHERE TC='" + tcc + "' ", baglantiac);
            cmd.ExecuteNonQuery();
            OleDbDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                txt_ep1.Text = oku["Eposta"].ToString();
                txt_tcü.Text = oku["TC"].ToString();
                txt_tca.Text = oku["Ad"].ToString();
                txt_tcs.Text = oku["Soyad"].ToString();
                txt_dt.Text = oku["DogumTarih"].ToString();
                cb_cin.Text = oku["Cinsiyet"].ToString();
                txt_yas.Text = oku["Yas"].ToString();
            }
            baglantiac.Close();
        }
        bool parolakontrol = false;
        bool hatakontrolleri = false;
        private void button3_Click(object sender, EventArgs e)
        {

            if (txt_p1.Text == "" || txt_s2.Text == "" || txt_eskip.Text == "" || txt_tca.Text == "" || txt_tcs.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız");
                hatakontrolleri = true;
                
            }
            else
                hatakontrolleri = false;
            if (txt_eskip.Text==parolla)
            {
                if (txt_p1.Text!=txt_s2.Text)
                {
                    kontroller.SetError(txt_p1, "Parolalar Eşleşmiyor !");
                    kontroller.SetError(txt_s2, "Parolalar Eşleşmiyor !");
                    parolakontrol = true;
                }
                else
                {
                    kontroller.Dispose();
                    parolakontrol = false;
                }
            }
            else
            {
                parolakontrol = true;
                kontroller.SetError(txt_eskip, "Eski Parola Hatalı");
            }
            if (parolakontrol||hatakontrolleri)
	           {
                MessageBox.Show("Bilgileri Konrol Edin");
	          }
            if (hatakontrolleri==false&&parolakontrol==false)
	           {
             kontroller.Dispose();
	         guncelle guncelleme = new guncelle();
             guncelleme.güncelle(txt_tcü.Text, txt_tca.Text, txt_tcs.Text, txt_ep1.Text, txt_p1.Text, txt_s2.Text, tcc);
            }
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int Mov, mx, my;
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void label7_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = 0;
        }

        private void txt_tca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txt_tcs_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tcs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
    }
}
