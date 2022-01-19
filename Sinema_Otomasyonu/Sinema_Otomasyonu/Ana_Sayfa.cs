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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        int sayac = 0;


        private void FilmVeSalonGetir(ComboBox combo, string sql1, string sql2)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql1, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read[sql2].ToString());

            }
            baglanti.Close();
        }
        private void FilmAfişiGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Film_bilgileri where Film_adi='" + comboFilmAdi.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                pictureBox1.ImageLocation = read["Resim"].ToString();
            }
            baglanti.Close();
        }

        private void Combo_Dolu_Koltuklar()
        {
            comboKoltukİptal.Items.Clear();
            comboKoltukİptal.Text = "";

            foreach (Control item in panel2.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor==Color.Red)
                    {
                        comboKoltukİptal.Items.Add(item.Text);
                    }
                }
            }
        }
        private void YenidenRenklendir()
        {
            foreach (Control item in panel2.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }
        private void Veritabanı_Dolu_Koltuklar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Satış_bilgileri where Film_adi='"+comboFilmAdi.SelectedItem+"'and Salon_adi='"+comboSalonAdi.Text+"' and Tarih='"+comboFilmTarihi.SelectedItem+"'and Saat='"+comboFilmSeansı.SelectedItem+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                foreach (Control item in panel2.Controls)
                {
                    if (item is Button)
                    {
                        if (read["Koltuk_no"].ToString()==item.Text)
                        {
                             item.BackColor = Color.Red;
                        }

                    }
                }
            }
            baglanti.Close();

        }
        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            Boş_Koltuklar();
            FilmVeSalonGetir(comboFilmAdi,"select *from Film_bilgileri", "Film_adi");
            FilmVeSalonGetir(comboSalonAdi, "select *from Salon", "Salon_adi");
        }

        private void Boş_Koltuklar()
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.BackColor = Color.White;
                    btn.Location = new Point(j * 30 + 20, i * 30 + 30);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (j == 4)
                    {
                        continue;
                    }
                    sayac++;

                    this.panel2.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor==Color.White)
            {
                txtKoltukNo.Text = b.Text;

            }
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FNTJ6AP;Initial Catalog=SinemaOtomasyonu;Integrated Security=True");

        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
            frmSalonEkle ekle = new frmSalonEkle();
            ekle.Show();
            this.Hide();
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            frmFilmEkle ekle2 = new frmFilmEkle();
            ekle2.Show();
            this.Hide();
        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            frmSeansEkle ekle = new frmSeansEkle();
            ekle.Show();
            this.Hide();
        }

        

       
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSatış_Click(object sender, EventArgs e)
        {
            frmSatışListeleme satıs = new frmSatışListeleme();
            satıs.Show();
            this.Hide();
        }

        private void btnSeansListele_Click(object sender, EventArgs e)
        {
            frmSeansListele seans = new frmSeansListele();
            seans.Show();
            this.Hide();
        }

        private void comboFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboFilmSeansı.Items.Clear();
            comboFilmTarihi.Items.Clear();
            comboFilmSeansı.Text = "";
            comboFilmTarihi.Text = "";
            comboSalonAdi.Text= "";
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";   
            
            FilmAfişiGoster();
            YenidenRenklendir();
            Combo_Dolu_Koltuklar();
        }

        SinemaTableAdapters.Satış_bilgileriTableAdapter satis = new SinemaTableAdapters.Satış_bilgileriTableAdapter();
        private void btnBiletSat_Click(object sender, EventArgs e)
        {
            if (txtKoltukNo.Text != "")
            {
                try
                {
                    satis.SatışYap(txtKoltukNo.Text, comboSalonAdi.Text, comboFilmAdi.Text, comboFilmTarihi.Text, comboFilmSeansı.Text, txtAd.Text, txtSoyad.Text, comboUcret.Text, DateTime.Now.ToString());
                    foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                    YenidenRenklendir();
                    Veritabanı_Dolu_Koltuklar();
                    Combo_Dolu_Koltuklar();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata Oluştu !!" + hata.Message, "Uyarı");

                }
            }
            else
            {
                MessageBox.Show("Koltuk Seçimi Yapmadınız!!!", "UYARI");

            }
        }
        private void Film_Tarihi_Getir()
        {
            comboFilmTarihi.Text = "";
            comboFilmSeansı.Text = "";
            comboFilmTarihi.Items.Clear();
            comboFilmSeansı.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Seanslar where Film_adi = '" + comboFilmAdi.SelectedItem + "' and Salon_adi='" + comboSalonAdi.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["Tarih"].ToString()) >= DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (!comboFilmTarihi.Items.Contains(read["Tarih"].ToString()))
                    {
                        comboFilmTarihi.Items.Add(read["Tarih"].ToString());
                    }

                }

            }
            baglanti.Close();
        }
        private void comboSalonAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film_Tarihi_Getir();
        }
        private void Film_Seansı_Getir()
        {
            comboFilmSeansı.Text = "";
            comboFilmSeansı.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Seanslar where Film_adi = '" + comboFilmAdi.SelectedItem + "' and Salon_adi='" + comboSalonAdi.SelectedItem + "' and Tarih='" + comboFilmTarihi.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["Tarih"].ToString()) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    try
                    {
                        if (DateTime.Parse(read["Seans"].ToString()) > DateTime.Parse(DateTime.Now.ToShortTimeString()))
                        {
                            comboFilmSeansı.Items.Add(read["Seans"].ToString());
                        }

                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Dogru Bir Zaman Dilimi Secmediniz", "Uyarı");
                    }


                }
                else if (DateTime.Parse(read["Tarih"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    comboFilmSeansı.Items.Add(read["Seans"].ToString());
                }
            }
            baglanti.Close();
        }
        private void comboFilmTarihi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film_Seansı_Getir();
        }

        private void comboFilmSeansı_SelectedIndexChanged(object sender, EventArgs e)
        {
            YenidenRenklendir();
            Veritabanı_Dolu_Koltuklar();
            Combo_Dolu_Koltuklar();

        }

        private void btnBiletİptal_Click(object sender, EventArgs e)
        {
            if (comboKoltukİptal.Text != "")
            {
                try
                {
                    satis.Satış_İptal(comboFilmAdi.Text, comboSalonAdi.Text, comboFilmTarihi.Text, comboFilmSeansı.Text, comboKoltukİptal.Text);
                    YenidenRenklendir();
                    Veritabanı_Dolu_Koltuklar();
                    Combo_Dolu_Koltuklar();

                }
                catch (Exception hata)
                {

                    MessageBox.Show("Hata Oluştu" + hata.Message, "Uyarı");
                }

            }
            else
            {
                MessageBox.Show("Koltuk Seçimi Yapmadınız!!", "UYARI");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
