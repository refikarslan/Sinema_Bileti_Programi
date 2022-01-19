using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Otomasyonu
{
    public partial class frmSeansListele : Form
    {
        public frmSeansListele()
        {
            InitializeComponent();
        }

       
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FNTJ6AP;Initial Catalog=SinemaOtomasyonu;Integrated Security=True");
        DataTable tablo = new DataTable();
        private void SeansListesi(string sql)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
                
        }
        private void frmSeansListele_Load(object sender, EventArgs e)
        {
            tablo.Clear();
             SeansListesi("select *from Seanslar where tarih like '" + dateTimePicker1.Text + "'");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SeansListesi("select *from Seanslar where tarih like '" + dateTimePicker1.Text + "'");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            SeansListesi("select *from Seanslar ");
        }

        private void frmSeansListele_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnaSayfa anasayfa = new frmAnaSayfa();
            anasayfa.Show();

        }
    }
}
