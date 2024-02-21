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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        OleDbConnection baglantiac = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=randevusistemi.accdb;Persist Security Info=False;");
        string klinikid1 = "";
        string klinikid2 = "";
        string klinikid3 = "";
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            KlinikleriGetir();
        }

        private void btnKlinikEkle_Click(object sender, EventArgs e)
        {
            pnlKlinikEkle.Visible = true;
            pnlDoktorEkle.Visible = false;
            txt_klinik.Select();
        }
        void KlinikleriGetir()
        {
            adminpaneli klinikgetir = new adminpaneli();
            klinikgetir.KlinikleriGetir(klinikler);
        }
        private void btnKlinikSil_Click(object sender, EventArgs e)
        {
            adminpaneli kliniksil = new adminpaneli();
            kliniksil.kliniksilme(klinikler, klinikid2, doktorlar);
        }

        private void btnKlinikİptal_Click(object sender, EventArgs e)
        {
            pnlKlinikEkle.Visible = false;
            txt_klinik.Text = "";
        }

        private void pnlKlinikEkleTamam_Click(object sender, EventArgs e)
        {
            adminpaneli klinikele1 = new adminpaneli();
            klinikele1.klinikekle(txt_klinik.Text.Trim(),klinikler);
            btnKlinikİptal_Click(sender, e);
        }

        private void btnDoktorIptal_Click(object sender, EventArgs e)
        {
            pnlDoktorEkle.Visible = false;
            txt_doktor.Text = "";
        }

        private void DoktorEkleTamam_Click(object sender, EventArgs e)
        {
            adminpaneli doktorekleme3 = new adminpaneli();
            doktorekleme3.doktorekleme(klinikid3, klinikler, txt_doktor.Text.Trim(), doktorlar);
            btnDoktorIptal_Click(sender, e);

        }
        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            try
            {
                klinikler.SelectedItem.ToString();
                pnlDoktorEkle.Visible = true;
                pnlKlinikEkle.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Doktoru Ekeleyeceğiniz Kliniği Seçmediniz");
            }

        }

        private void btnDoktorSil_Click(object sender, EventArgs e)
        {
            try
            {
                adminpaneli doktorsil1 = new adminpaneli();
                doktorsil1.doktorsil(doktorlar);
                klinikler_SelectedIndexChanged_1(sender, e);

            }
            catch (Exception)
            {
                baglantiac.Close();
                MessageBox.Show("Silinecek Doktoru Seçmediniz");
            }

        }
        string secilendoktor;
        private void listBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                secilendoktor = doktorlar.SelectedItem.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Doktor Seçiniz");
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void klinikler_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            adminpaneli klniksec = new adminpaneli();
            klniksec.kliniksecilince(doktorlar, klinikler, klinikid1);
        }
        int Mov, mx,my;

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = 1;
            mx = e.X;
            my = e.Y;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
           if (Mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
       }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = 0;
        }
    }
}
