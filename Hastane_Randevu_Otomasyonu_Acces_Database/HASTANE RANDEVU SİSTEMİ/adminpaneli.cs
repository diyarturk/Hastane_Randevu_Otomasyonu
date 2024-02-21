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
    class adminpaneli
    {
        OleDbConnection baglantiac = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=randevusistemi.accdb;Persist Security Info=False;");
        public void KlinikleriGetir(ListBox klinik)
        {
            klinik.Items.Clear();
            try
            {
                baglantiac.Open();

                OleDbCommand cmd = new OleDbCommand("Select * From Klinik", baglantiac);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    klinik.Items.Add(rd["KilinikAdi"].ToString());
                }

                baglantiac.Close();
            }
            catch (Exception hata)
            {
                baglantiac.Close();
                MessageBox.Show(hata.Message);
            }
        }
        public int admingirisi(string kad,string sifre)
        {
            baglantiac.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Admin WHERE k_adi='"+kad+"' AND sifre='"+sifre+"'",baglantiac);
            //cmd.Connection = baglantiac;
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Admin ac = new Admin();
                ac.Show();
                return 1;
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış");
                return 0;
            }
        }
        public void doktorsil(ListBox doktorlar1)
        {
                doktorlar1.SelectedItem.ToString();
                baglantiac.Open();
                OleDbCommand cmd = new OleDbCommand("Delete * From Doktor where DoktorAdSoyad='" + doktorlar1.SelectedItem.ToString() + "'", baglantiac);
                cmd.ExecuteNonQuery();
                baglantiac.Close();
        }
        public void doktorekleme(string klinikidd3,ListBox klinikler3,string doktorr,ListBox doktorlarr)
        {
            try
            {
                baglantiac.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From Klinik where KilinikAdi='" + klinikler3.SelectedItem.ToString() + "'", baglantiac);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    klinikidd3 = rd["KilinikID"].ToString();
                }
                baglantiac.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            if (doktorr != "")
            {
                try
                {
                    baglantiac.Open();

                    OleDbCommand cmd = new OleDbCommand("insert into Doktor (KilinikID,DoktorAdSoyad) values ('" + klinikidd3 + "','" + doktorr+ "')", baglantiac);
                    cmd.ExecuteNonQuery();
                    baglantiac.Close();
                    kliniksecilince(doktorlarr, klinikler3, klinikidd3);
                }
                catch (Exception hata)
                {
                    baglantiac.Close();
                    MessageBox.Show(hata.Message);
                }
            }
        }
        public void kliniksecilince(ListBox doktor2,ListBox klinik2,string klinikidd)
        {
            doktor2.Items.Clear();
            try
            {
                baglantiac.Open();

                OleDbCommand cmd = new OleDbCommand("Select * From Klinik where KilinikAdi='" + klinik2.SelectedItem.ToString() + "'", baglantiac);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    klinikidd = rd["KilinikID"].ToString();
                }

                baglantiac.Close();
            }
            catch (Exception hata)
            {
                baglantiac.Close();
                MessageBox.Show(hata.Message);
            }

            try
            {
                baglantiac.Open();

                OleDbCommand cmd = new OleDbCommand("Select * From Doktor where KilinikID=@id", baglantiac);
                cmd.Parameters.AddWithValue("@id", klinikidd);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    doktor2.Items.Add(rd["DoktorAdSoyad"].ToString());
                }

                baglantiac.Close();
            }
            catch (Exception hata)
            {
                baglantiac.Close();
                MessageBox.Show(hata.Message);
            }
        
        }
        public void klinikekle(string klinikismi,ListBox klinikler2)
        {
            if (klinikismi != "")
            {
                try
                {
                    baglantiac.Open();

                    OleDbCommand cmd = new OleDbCommand("INSERT INTO Klinik (KilinikAdi) values ('" + klinikismi + "')", baglantiac);
                    cmd.ExecuteNonQuery();

                    baglantiac.Close();
                    KlinikleriGetir(klinikler2);
                }
                catch (Exception hata)
                {
                    baglantiac.Close();
                    MessageBox.Show(hata.Message);
                }
            }
        
        
        }
        public void kliniksilme(ListBox klinikler1,string klinikid,ListBox doktorlar1)
        {
            try
            {
                klinikler1.SelectedItem.ToString();
                baglantiac.Open();
                OleDbCommand cmd2 = new OleDbCommand("Select * From Klinik where KilinikAdi='" + klinikler1.SelectedItem.ToString() + "'", baglantiac);
                cmd2.ExecuteNonQuery();
                OleDbDataReader rd = cmd2.ExecuteReader();
                while (rd.Read())
                {
                    klinikid = rd["KilinikID"].ToString();
                }

                OleDbCommand cmd = new OleDbCommand("Delete * From Klinik where KilinikAdi='" + klinikler1.SelectedItem.ToString() + "'", baglantiac);
                cmd.ExecuteNonQuery();
                OleDbCommand cmd1 = new OleDbCommand("Delete * From Doktor where KilinikID=@id", baglantiac);
                cmd1.Parameters.AddWithValue("@id", klinikid);
                cmd1.ExecuteNonQuery();
                baglantiac.Close();
                KlinikleriGetir(klinikler1);
                doktorlar1.Items.Clear();
            }
            catch (Exception)
            {
                baglantiac.Close();
                MessageBox.Show("Silinecek Kliniği Seçmediniz");
            }
        
        
        }
    }
}
