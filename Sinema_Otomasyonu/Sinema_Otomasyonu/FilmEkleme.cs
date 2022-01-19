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
    public partial class frmFilmEkle : Form
    {
        public frmFilmEkle()
        {
            InitializeComponent();
        }

        SinemaTableAdapters.Film_bilgileriTableAdapter film = new SinemaTableAdapters.Film_bilgileriTableAdapter();
        private void frmFilmEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {

            try
            {

                film.FiilmEklee(txtFilmAdi.Text, txtYönetmen.Text, comboFilmTürü.Text, txtSüre.Text, dateTimePicker1.Text, txtYapımYili.Text, pictureBox1.ImageLocation);
                MessageBox.Show("Film Bilgileri Eklendi.", "KAYIT");
            }
            catch (Exception)
            {

                MessageBox.Show("Bu Film Daha Önce Eklendi!!", "UYARI");
            }
         
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            comboFilmTürü.Text = "";
            

        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

        }

        private void frmFilmEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnaSayfa anasayfa = new frmAnaSayfa();
            anasayfa.Show();
        }
    }
}
