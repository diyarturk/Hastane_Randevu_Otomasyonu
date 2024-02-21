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
    class randevualim
   {
        OleDbConnection baglantiac = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=randevusistemi.accdb;Persist Security Info=False;");
      public void randevusecme(Panel saatpaneli,string tarihcb,string doktorcb)
        {
            foreach (Control saatlerYesil in saatpaneli.Controls)
            {
                if (saatlerYesil.Text != "Randevu Saati Seçiniz :")
                {
                    saatlerYesil.BackColor = System.Drawing.Color.FromArgb(0, 101, 153);
                }
            }

            DateTime date = DateTime.Now;

            if (date.ToShortDateString() == tarihcb)
            {
                int dakika = date.Minute;
                int saat = date.Hour;
                foreach (Control randevukontroletveal in saatpaneli.Controls)
                {
                    if (randevukontroletveal.Text != "Randevu Saati Seçiniz :")
                    {
                        if (int.Parse(randevukontroletveal.Text.Substring(0, 2)) < saat)
                        {
                            randevukontroletveal.BackColor = Color.Brown;
                            randevukontroletveal.Cursor = Cursors.Default;
                        }
                        if (int.Parse(randevukontroletveal.Text.Substring(0, 2)) == saat)
                        {
                            if (int.Parse(randevukontroletveal.Text.Substring(3)) <= dakika)
                            {
                                randevukontroletveal.BackColor = Color.Brown;
                                randevukontroletveal.Cursor = Cursors.Default;
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (Control randevukontroletveal in saatpaneli.Controls)
                {
                    if (randevukontroletveal.Text != "Randevu Saati Seçiniz :")
                    {
                        randevukontroletveal.BackColor = System.Drawing.Color.FromArgb(0, 101, 153);
                        randevukontroletveal.Cursor = Cursors.Hand;
                    }
                }
            }
            try
            {
                baglantiac.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From Randevu where DoktorAd='" + doktorcb + "' and Tarih='" + tarihcb + "'", baglantiac);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    foreach (Control randevukontroletveal in saatpaneli.Controls)
                    {
                        if (rd["Saat"].ToString() == randevukontroletveal.Text)
                        {
                            randevukontroletveal.BackColor = Color.Brown;
                            randevukontroletveal.Cursor = Cursors.Default;
                        }
                    }
                }
                baglantiac.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
    
    }
        
        
        
        public void doktorlarigetir(ComboBox doktorcb,string klinikid="")
        {
            baglantiac.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand("Select * From Doktor where KilinikID=@id", baglantiac);
                cmd.Parameters.AddWithValue("@id", klinikid);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    doktorcb.Items.Add(rd["DoktorAdSoyad"].ToString());
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            baglantiac.Close();
        }
      public void klinilerigetir(ComboBox klinik)
       {
           baglantiac.Open();
           try
           {
               klinik.Items.Clear();
               OleDbCommand cmd = new OleDbCommand("Select * From Klinik", baglantiac);
               cmd.ExecuteNonQuery();
               OleDbDataReader rd = cmd.ExecuteReader();
               while (rd.Read())
               {
                   klinik.Items.Add(rd["KilinikAdi"].ToString());

               }
           }
           catch (Exception hata)
           {
               MessageBox.Show(hata.Message);
           }
           baglantiac.Close();
       }
      public void kllinikidara(ComboBox klinik,ComboBox cbdoktor,string klinikid2="")
      {
          try
          {
              baglantiac.Open();
              OleDbCommand cmd = new OleDbCommand("Select * From Klinik where KilinikAdi='" + klinik.Text + "'", baglantiac);
              cmd.ExecuteNonQuery();
              OleDbDataReader dr = cmd.ExecuteReader();
              while (dr.Read())
              {
                  klinikid2 = dr["KilinikID"].ToString();
              }
              baglantiac.Close();
              doktorlarigetir(cbdoktor, klinikid2);
          }
          catch (Exception hata)
          {
              MessageBox.Show(hata.Message);
              baglantiac.Close();
          }
          }
       }
     }
      
    

