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
    class randevugoster
    {
        OleDbConnection baglantiac = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=randevusistemi.accdb;Persist Security Info=False;");
        public void listviewGuncelle(ListView randevular,string tcno)
        {
            randevular.Items.Clear();
            try
            {
                baglantiac.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Randevu WHERE Tc='" + tcno + "' ORDER BY RandevuID DESC ", baglantiac);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                int no = 0;
                while (rd.Read())
                {
                    no++;
                    randevular.Items.Add(no.ToString());
                    randevular.Items[no - 1].SubItems.Add(rd["KilinikAd"].ToString());
                    randevular.Items[no - 1].SubItems.Add(rd["DoktorAd"].ToString());
                    randevular.Items[no - 1].SubItems.Add(rd["Tarih"].ToString());
                    randevular.Items[no - 1].SubItems.Add(rd["Saat"].ToString());
                    randevular.Items[no - 1].SubItems.Add(rd["RandevuID"].ToString());
                }
                baglantiac.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        public void randevuiptalet(ListView iptalet,string tcno2)
        {
            string[] idler = new string[iptalet.CheckedItems.Count];

            for (int i = 0; i < iptalet.CheckedItems.Count; i++)
            {
                idler[i] = iptalet.CheckedItems[i].Text;
                try
                {
                    baglantiac.Open();
                    OleDbCommand cmd = new OleDbCommand("Delete * From Randevu where RandevuID=@id", baglantiac);
                    cmd.Parameters.AddWithValue("@id", iptalet.CheckedItems[i].SubItems[5].Text);
                    cmd.ExecuteNonQuery();
                    baglantiac.Close();

                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }

            }
            listviewGuncelle(iptalet,tcno2);
        }
    }
}
