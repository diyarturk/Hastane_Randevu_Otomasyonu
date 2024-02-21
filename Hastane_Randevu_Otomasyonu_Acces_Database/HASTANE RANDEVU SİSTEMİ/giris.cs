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
    class giris
    {
        OleDbConnection baglantiac = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=randevusistemi.accdb;Persist Security Info=False;");
        bool girisyaptimi=false;
        public void girisyap(string tc,string sifre,string sol,string sol2)
         {            
           try
            {
                baglantiac.Open();
                OleDbCommand cmd1 = new OleDbCommand("Select * From YeniUye WHERE TC='" + tc + "' AND Sifre='" + sifre + "'", baglantiac);
                cmd1.ExecuteNonQuery();
                OleDbDataReader rd1 = cmd1.ExecuteReader();
               while(rd1.Read())
               {
                   if (sol==sol2)
                   {
                       saatkonrol randevuac = new saatkonrol(tc,sifre);
                        randevuac.Show();
                        girisyaptimi = true; 
                   }
                          
                    }
              baglantiac.Close();
               if (girisyaptimi==false)
               {
                   MessageBox.Show("TC Kimlik Numarası Şifre veya Güvenlik Kodu Yanlış...", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               }
            }
            catch (Exception)
            {
                baglantiac.Close();
            }
        }
    
    }
            
 }

