using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Otomasyonu
{
    public partial class frmSatışListeleme : Form
    {
        public frmSatışListeleme()
        {
            InitializeComponent();
        }

        SinemaTableAdapters.Satış_bilgileriTableAdapter satislistesi = new SinemaTableAdapters.Satış_bilgileriTableAdapter();
             
        private void frmSatışListeleme_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satislistesi.TariheGöreListele2(dateTimePicker1.Text);
            ToplamUcretHesapla();
        }

        private void ToplamUcretHesapla()
        {
            int ucrettoplami = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ucrettoplami += Convert.ToInt32(dataGridView1.Rows[i].Cells["Ücret"].Value);

            }
            label1.Text = "Toplam Satış= " + ucrettoplami + "TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satislistesi.SatışListesi2();

            ToplamUcretHesapla();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satislistesi.TariheGöreListele2(dateTimePicker1.Text);
            ToplamUcretHesapla();

        }

        private void frmSatışListeleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnaSayfa anasayfa = new frmAnaSayfa();
            anasayfa.ShowDialog();
        }
    }
}
