using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.Mail;
using System.Net;

namespace HASTANE_RANDEVU_SİSTEMİ
{
    public partial class PAROLA_UNUTTUM : Form
    {
        public PAROLA_UNUTTUM()
        {
            InitializeComponent();
        }
        OleDbConnection baglantiac = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=randevusistemi.accdb;Persist Security Info=False;");
        int Mov;
        int mx;
        int my;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            baglantiac.Open();
            OleDbCommand cmd = new OleDbCommand("Select* From YeniUye where TC='" + txt_tck.Text + "'", baglantiac);
            OleDbDataReader dr = cmd.ExecuteReader(); 
               bool parola_Verildimi = false;
                while (dr.Read())
                {
                     try
                    {     
                        MailMessage msj = new MailMessage();
                        SmtpClient iletim = new SmtpClient();
                        iletim.Credentials = new System.Net.NetworkCredential("randevusistemimhrs@gmail.com", "randevu123");
                        iletim.Port = 587;
                        iletim.Host = "smtp.gmail.com";
                        iletim.EnableSsl = true;
                        msj.To.Add(dr["Eposta"].ToString());
                        msj.From = new MailAddress("randevusistemimhrs@gmail.com", "MHRS RANDEVU SİSTEMİ");
                        msj.Subject = "PAROLA HATIRLATMA";
                        msj.Body = "Sayın " + dr["Ad"].ToString() + " " + dr["Soyad"].ToString() + " Parolanız : " + dr["Sifre"].ToString();
                        iletim.Send(msj);
                         MessageBox.Show("Şifreniz Mail Hesabınıza Gönderilmistir","BAŞARILI");      
                     }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                    parola_Verildimi = true;
                    if (parola_Verildimi)
                    {
                        this.Close();
                    }
                }
                if (parola_Verildimi==false)
                {
                    MessageBox.Show("HATALI BİLGİLER");
                }
                baglantiac.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                this.Close();
            }
         }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = 1;
            mx = e.X;
            my = e.Y;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
             if (Mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
             Mov = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PAROLA_UNUTTUM_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}