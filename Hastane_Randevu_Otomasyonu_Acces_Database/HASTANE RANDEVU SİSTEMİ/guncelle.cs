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
    class guncelle
    {
        OleDbConnection baglantiac = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=randevusistemi.accdb;Persist Security Info=False;");
        public void baglantiac1()
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
        public void güncelle(string tc,string ad, string soyad, string eposta,string sifre,string sifre2, string guncel)
        {
            string update;
            update = "UPDATE YeniUye SET [TC] = '" + tc + "' , [Ad] = '" + ad + "' ,[Soyad] = '" + soyad + "',[Eposta] = '" + eposta + "' ,[Sifre] = '" + sifre + "' ,[SifreTekrar] = '" + sifre2 + "' Where [TC] = '" + guncel + "'";
            baglantiac1();
            OleDbCommand guncelle = new OleDbCommand(update, baglantiac);
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçeklerştirilmiştir", "Güncelle");
            baglantiac.Close();
        }
    }
}
