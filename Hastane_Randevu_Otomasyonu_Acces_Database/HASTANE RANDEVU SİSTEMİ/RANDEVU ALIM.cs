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

namespace HASTANE_RANDEVU_SİSTEMİ
{
   
    public partial class saatkonrol : Form
    {
        string tcno = "";
        string parola1 = "";
        public saatkonrol(string tc,string parolaa)
        {
            InitializeComponent();
            tcno = tc;
            parola1 = parolaa;

        } 
        OleDbConnection baglantiac = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=randevusistemi.accdb;Persist Security Info=False;");
        string klinikid = "";
        DateTime datee = DateTime.Now;
        
        void visiable(dynamic goster)
        {
            bebek.Visible = false;
            teyze.Visible = false;
            genc_erkek.Visible = false;
            genc_kiz.Visible = false;
            dede.Visible = false;
            yet_erkek.Visible = false;
            yet_kadın.Visible = false;
            goster.Visible = true;
        }  
        void klinileriGoster()
        {   
            randevualim kilinkgoster=new randevualim();
            kilinkgoster.klinilerigetir(cb_klinik);
        }

        void tarihyazdir()
        {
            int i = 1;
            while (cb_tarih.Items.Count != 7)
            {
                if (datee.AddDays(i).DayOfWeek.ToString() != "Saturday" && datee.AddDays(i).DayOfWeek.ToString() != "Sunday")
                { 
                    cb_tarih.Items.Add(datee.AddDays(i).ToShortDateString());
                    
                }
                i++;
            }
        }
        bool ayniSaatVarmi = false;
        void randevukontroletveal_Click(object sender, EventArgs e)
        {
            secileniduzenle();
            ayniSaatVarmi = false;
            foreach (Control saatler in saatpaneli.Controls)
            {
                if (saatler.Text == sender.ToString().Substring(34))
                {
                        if (saatler.ForeColor != Color.Brown)
                        {
                            baglantiac.Open();
                            OleDbCommand cmdsaatkontrolu = new OleDbCommand("Select * From Randevu where TC='" + lbl_tc.Text + "' and Tarih='" + cb_tarih.Text + "' and DoktorAd='" + cb_doktor2.Text + "'", baglantiac);
                            cmdsaatkontrolu.ExecuteNonQuery();
                            OleDbDataReader saatKontrol = cmdsaatkontrolu.ExecuteReader();
                        while (saatKontrol.Read())
                        {
                            if (saatler.Text == saatKontrol["Saat"].ToString())
                            {
                            ayniSaatVarmi = true;
                            MessageBox.Show("Aynı Gün ve Saatte Yalnızca Bir Kere Randevu Alabilirsiniz...","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            baglantiac.Close();
                            break;
                        }

                    }
                    baglantiac.Close();
                }
                if (saatler.BackColor != Color.Brown)
                    {
                        if (ayniSaatVarmi == false)
                        {
                            baglantiac.Close();
                if (MessageBox.Show(cb_tarih.Text + " Tarihinde " + sender.ToString().Substring(34) + " Saatinde " + cb_klinik.Text + " Kliniğinde \n" + cb_doktor2.Text + " Tarafından Muayene İçin Randevu Alınıyor ", "MHRS RANDEVU SİSTEMİ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                            {
                                baglantiac.Open();
                                OleDbCommand cmd = new OleDbCommand("INSERT INTO Randevu (Tc,KilinikAd,DoktorAd,Tarih,Saat) values ('" + lbl_tc.Text + "','" + cb_klinik.Text + "','" + cb_doktor2.Text + "','" + cb_tarih.Text + "','" + saatler.Text + "')", baglantiac);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Randevu Alınmıştır...", "Mesaj", MessageBoxButtons.OK);
                        baglantiac.Close();
                        formutekrarbaslat();
                        cb_klinik.Select();
                        klinileriGoster();
                            }
                            catch (Exception hata)
                            {
                                MessageBox.Show(hata.Message);
                            }
                        }

                break;
            }
        }
                }
            }
        }
        void formutekrarbaslat()
        {
            cb_klinik.Items.Clear();
            cb_tarih.Items.Clear();
            cb_doktor2.Items.Clear();
            saatpaneli.Visible = false;
        }
        void klinikidsec()
        {
            randevualim klinikidbul = new randevualim();
            klinikidbul.kllinikidara(cb_klinik, cb_doktor2, klinikid);
            
        }
        void doktorgetir()
        {
            randevualim dooktorgoster = new randevualim();
            dooktorgoster.doktorlarigetir(cb_doktor2, klinikid);
        }
        void ogledenonce()
        {
            labell1.Text = "08:00"; labell2.Text = "08:15"; labell3.Text = "08:30"; labell4.Text = "08:45";
            labell5.Text = "09:00"; labell6.Text = "09:15"; labell7.Text = "09:30"; labell8.Text = "09:45";
            labell9.Text = "10:00"; labell10.Text = "10:15"; labell11.Text = "10:30"; labell12.Text = "10:45";
            labell13.Text = "11:00"; labell14.Text = "11:15"; labell15.Text = "11:30"; labell16.Text = "11:45";
            labell17.Text = "12:00"; labell18.Text = "12:15"; labell19.Text = "12:30"; labell20.Text = "12:45";
        
        }
        void ogledensonra()
        {
            labell1.Text = "13:00"; labell2.Text = "13:15"; labell3.Text = "13:30"; labell4.Text = "13:45";
            labell5.Text = "14:00"; labell6.Text = "14:15"; labell7.Text = "14:30"; labell8.Text = "14:45";
            labell9.Text = "15:00"; labell10.Text = "15:15"; labell11.Text = "15:30"; labell12.Text = "15:45";
            labell13.Text = "16:00"; labell14.Text = "16:15"; labell15.Text = "16:30"; labell16.Text = "16:45";
            labell17.Text = "17:00"; labell18.Text = "17:15"; labell19.Text = "17:30"; labell20.Text = "17:45";
        
        }
        void secileniduzenle()
        {
            //foreach (Control saatlerYesil in saatpaneli.Controls)
            //{
            //    if (saatlerYesil.Text != "Randevu Saati Seçiniz :")
            //    {
            //        saatlerYesil.BackColor = System.Drawing.Color.FromArgb(0, 101, 153);
            //    }
            //}

            //DateTime date = DateTime.Now;

            //if (date.ToShortDateString() == cb_tarih.Text)
            //{
            //    int dakika = date.Minute;
            //    int saat = date.Hour;
            //    foreach (Control randevukontroletveal in saatpaneli.Controls)
            //    {
            //        if (randevukontroletveal.Text != "Randevu Saati Seçiniz :")
            //        {
            //            if (int.Parse(randevukontroletveal.Text.Substring(0, 2)) < saat)
            //            {
            //                randevukontroletveal.BackColor = Color.Brown;
            //                randevukontroletveal.Cursor = Cursors.Default;
            //            }
            //            if (int.Parse(randevukontroletveal.Text.Substring(0, 2)) == saat)
            //            {
            //                if (int.Parse(randevukontroletveal.Text.Substring(3)) <= dakika)
            //                {
            //                    randevukontroletveal.BackColor = Color.Brown;
            //                    randevukontroletveal.Cursor = Cursors.Default;
            //                }
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    foreach (Control randevukontroletveal in saatpaneli.Controls)
            //    {
            //        if (randevukontroletveal.Text != "Randevu Saati Seçiniz :")
            //        {
            //            randevukontroletveal.BackColor = System.Drawing.Color.FromArgb(0, 101, 153);
            //            randevukontroletveal.Cursor = Cursors.Hand;
            //        }
            //    }
            //}
            //try
            //{
            //    baglantiac.Open();
            //    OleDbCommand cmd = new OleDbCommand("Select * From Randevu where DoktorAd='" + cb_doktor2.Text + "' and Tarih='" + cb_tarih.Text + "'", baglantiac);
            //    cmd.ExecuteNonQuery();
            //    OleDbDataReader rd = cmd.ExecuteReader();
            //    while (rd.Read())
            //    {
            //        foreach (Control randevukontroletveal in saatpaneli.Controls)
            //        {
            //            if (rd["Saat"].ToString() == randevukontroletveal.Text)
            //            {
            //                randevukontroletveal.BackColor = Color.Brown;
            //                randevukontroletveal.Cursor = Cursors.Default;
            //            }
            //        }
            //    }
            //    baglantiac.Close();
            //}
            //catch (Exception hata)
            //{
            //    MessageBox.Show(hata.Message);
            //}

            randevualim randevusec = new randevualim();
            randevusec.randevusecme(saatpaneli, cb_tarih.Text, cb_doktor2.Text);
        }
        
        void bilgigetir()
        {
            baglantiac.Open();
            OleDbCommand cmd = new OleDbCommand("Select * From YeniUye where TC='" + tcno + "' ", baglantiac);
            cmd.ExecuteNonQuery();
            OleDbDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                lbl_eposta.Text = oku["Eposta"].ToString();
                lbl_tc.Text = oku["TC"].ToString();
                lbl_adsoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                lbl_dtarih.Text = oku["DogumTarih"].ToString();
                lbl_cinsiyet.Text = oku["Cinsiyet"].ToString();
                lbl_yas.Text = oku["Yas"].ToString();
            }
            baglantiac.Close();

        }

        private void RANDEVU_ALIM_Load(object sender, EventArgs e)
        {
            bilgigetir();
            klinileriGoster();
            saatpaneli.Visible = false;
            timer1.Start();
            foreach (Control randevukontroletveal in saatpaneli.Controls)
            {
                        if (randevukontroletveal.Text != "Randevu Saati Seçiniz :")
                        {
                                if (randevukontroletveal.ForeColor != Color.Red)
                        {
                            randevukontroletveal.Click += new EventHandler(randevukontroletveal_Click);
                          }
                        }              
            }
           
            int yas = int.Parse(lbl_yas.Text);
            if (yas < 6)
                visiable(bebek);
            if (yas > 6 && yas < 18 && lbl_cinsiyet.Text == "Erkek")
                visiable(genc_erkek);
            if (yas > 6 && yas < 18 && lbl_cinsiyet.Text == "Kadın")
                visiable(genc_kiz);
            if (yas > 18 && yas < 50 && lbl_cinsiyet.Text == "Erkek")
                visiable(yet_erkek);
            if (yas > 18 && yas < 50 && lbl_cinsiyet.Text == "Kadın")
                visiable(yet_kadın);
            if (yas > 50 && yas < 100 && lbl_cinsiyet.Text == "Erkek")
                visiable(dede);
            if (yas > 50 && yas < 100 && lbl_cinsiyet.Text == "Kadın")
                visiable(teyze);          
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int Mov, mx,my;
        private void btn_kapat_Click(object sender, EventArgs e)
        { if (MessageBox.Show("ÇIKMAK İSTİYOR MUSUNUZ","ÇIKIŞ",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_rangec_Click(object sender, EventArgs e)
        {
            randevuekrani ac = new randevuekrani(lbl_tc.Text);
            ac.Show();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            bilgiguncelle guncelle = new bilgiguncelle(tcno,parola1);
            guncelle.Show();
        }

        private void cb_klinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_klinik.Select();
            cb_doktor2.Items.Clear();
            cb_doktor2.Text = "";
            saatpaneli.Visible = false;
            cb_tarih.Items.Clear();
            cb_tarih.Text = "";
            klinikidsec();
        }

        private void cb_tarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            randevukontroletveal_Click(sender, e);
            saatpaneli.Visible = true;
            secileniduzenle(); 
        }

        private void cb_doktor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_tarih.Select();
            cb_tarih.Items.Clear();
            cb_tarih.Text = "";
            saatpaneli.Visible = false;
            tarihyazdir();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            ogledensonra();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ogledenonce();
        }

        private void saatpaneli_MouseClick(object sender, MouseEventArgs e)
        {
            
           
        }

        private void saatpaneli_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void saatpaneli_Move(object sender, EventArgs e)
        {
        }

        private void bilgipaneli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = 1;
            mx = e.X;
            my = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = 0;
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            string bugun = DateTime.Now.ToString();
            lbl_tarih.Text = bugun;
        }

        private void saatpaneli_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
