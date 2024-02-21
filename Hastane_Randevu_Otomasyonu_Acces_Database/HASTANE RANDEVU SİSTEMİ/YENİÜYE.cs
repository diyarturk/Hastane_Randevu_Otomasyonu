using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace HASTANE_RANDEVU_SİSTEMİ
{
    public partial class YENİÜYE : Form
    {
        public YENİÜYE()
        {
            InitializeComponent();
        }
        int Mov;
        int mx;
        int my;
        int yas;
        private void btn_dtarih_Click(object sender, EventArgs e)
        {
            dt_doğum.Visible = !dt_doğum.Visible;
            txt_dt.Text = dt_doğum.Value.ToString();
            DateTime dogumtarihi;
            dogumtarihi = Convert.ToDateTime(dt_doğum.Text);
            yas = DateTime.Now.Year - dogumtarihi.Year;
            txt_yas.Text = yas.ToString();                     
        }
        private void txt_tcü_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;   
        }
        int sayi;
        bool parolahatasi=false;
        bool hatakontrolleri = false;
        private void btn_uyeol_Click(object sender, EventArgs e)
         {
            Regex emailRegex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            yeniuye kontrol = new yeniuye(); 
            kontrol.kayitvarmi(txt_tcü.Text, txt_ep1.Text);
            foreach (Control bosmu in uyepaneli.Controls)
            {
                if (bosmu is TextBox)
                {
                    if (bosmu.Text == "")
                    {
                        errorProvider1.SetError(bosmu, "Boş Alan Bırakmayınız");
                        hatakontrolleri = true;
                    }
                    else
                    {
                        errorProvider1.Dispose();
                        hatakontrolleri = false;
                    }
                    
                }
            }
            if (txt_p1.Text!=txt_s2.Text)
            {
                errorProvider1.SetError(txt_p1, "Parolalar Eşleşmiyor");
                parolahatasi = true;
            }
            else
            {
                errorProvider1.Dispose();
                parolahatasi = false;
            }
            if (hatakontrolleri||parolahatasi)
            {
                MessageBox.Show("Bilgilerinizi Kontrol Ediniz");
            }
            if (hatakontrolleri==false||parolahatasi==false)
	      {
                if (emailRegex.IsMatch(txt_ep1.Text))
              {
                sayi = gkod.Next(10000, 99999);
                MailMessage msj = new MailMessage();
                SmtpClient iletim = new SmtpClient();
                iletim.Credentials = new System.Net.NetworkCredential("randevusistemimhrs@gmail.com", "randevu123");
                iletim.Port = 587;
                iletim.Host = "smtp.gmail.com";
                iletim.EnableSsl = true;
                msj.To.Add(txt_ep1.Text);
                msj.From = new MailAddress("randevusistemimhrs@gmail.com", "MHRS RANDEVU SİSTEMİ");
                msj.Subject = "GÜVENLİK KONTROLÜ";
                msj.Body = "Güvenlik Kodu: " + sayi.ToString();
                iletim.Send(msj);
                panel2.Visible = true;
                panel1.Visible = false;        
             }
            else
             {
                 MessageBox.Show(txt_ep1.Text + " E-Posta Adresi Geçersizdir.", "UYARI");
             }
		 
	      }
            

         
         }


        private void YENİÜYE_Load(object sender, EventArgs e)
        {
            dt_doğum.CustomFormat = "d/M/yyyy";
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void cb_cin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        Random gkod = new Random();
        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_kod.Text==sayi.ToString())
            {
                yeniuye KayitEkle = new yeniuye();
                KayitEkle.kayitekle(txt_tcü.Text, txt_tca.Text, txt_tcs.Text,txt_dt.Text,d_yer.Text,int.Parse(txt_yas.Text),txt_ep1.Text,txt_p1.Text,txt_s2.Text,cb_cin.Text);

                Form1 A = new Form1();
                A.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("GÜVENLİK KODU YANLIŞ");
            }
        }

        private void txt_tca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txt_tcs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
 
    }
}
