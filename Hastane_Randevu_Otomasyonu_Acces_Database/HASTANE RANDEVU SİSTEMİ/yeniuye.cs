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
using System.Data.OleDb;

namespace HASTANE_RANDEVU_SİSTEMİ
{
    class yeniuye
    {
        OleDbConnection baglantiac = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=randevusistemi.accdb;Persist Security Info=False;");
        OleDbCommand cmd = new OleDbCommand();
        
        public void baglan()
        {
            try
            {
                baglantiac.Open();
            }
            catch (Exception)
            {
                baglantiac.Close();
                baglantiac.Open();
            }
        }
       public void kayitekle(string tc, string ad, string soyad,string dtarih,string dyeri,int yas,string eposta,string sifre,string sifretekrar,string cinsiyet)
        {
          
            baglan();
            cmd.Connection = baglantiac;
            cmd.CommandText = "INSERT INTO YeniUye(TC,Ad,Soyad,Cinsiyet,DogumTarih,DogumYer,Yas,Eposta,Sifre,SifreTekrar) VALUES (@TC,@Ad,@Soyad,@Cinsiyet,@DogumTarih,@DogumYer,@Yas,@Eposta,@Sifre,@SifreTekrar)";
            cmd.Parameters.AddWithValue("TC", tc);
            cmd.Parameters.AddWithValue("Ad", ad);
            cmd.Parameters.AddWithValue("Soyad", soyad);
            cmd.Parameters.AddWithValue("Cinsiyet", cinsiyet);
            cmd.Parameters.AddWithValue("DogumTarih", dtarih);
            cmd.Parameters.AddWithValue("DogumYer", dyeri);
            cmd.Parameters.AddWithValue("Yas", yas);
            cmd.Parameters.AddWithValue("Eposta", eposta);
            cmd.Parameters.AddWithValue("Sifre", sifre);
            cmd.Parameters.AddWithValue("SifreTekrar", sifretekrar);
            cmd.ExecuteNonQuery();
            MessageBox.Show("HESAP DOĞRULAMA İŞLEMİ GERÇEKLEŞTİRİLMİŞTİR", "GİRİŞ EKRANINA YÖNLENDİRİLİORSUNUZ...");
            baglantiac.Close();    
            
            
           }
           public void kayitvarmi(string tc, string epsta)
           {
               
               baglan();
               OleDbCommand cmd1 = new OleDbCommand("Select * From YeniUye", baglantiac);
               cmd1.ExecuteNonQuery();
               OleDbDataReader rd = cmd1.ExecuteReader();
               while (rd.Read())
               {
                       if (rd["TC"].ToString() == tc)
                      {
                       MessageBox.Show("Sisteme Kaydınız Bulunmaktadır...\nParolanızı Unuttuysanız Parolamı Unuttum Bölümünü Ziyaret Edin.","UYARI",MessageBoxButtons.OK);
                       }        
                   }
                   
               }
          
           }
        }
    

