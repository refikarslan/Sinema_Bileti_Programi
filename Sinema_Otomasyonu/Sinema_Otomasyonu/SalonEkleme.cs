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
    public partial class frmSalonEkle : Form
    {
        public frmSalonEkle()
        {
            InitializeComponent();
        }

        private void frmSalonEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnaSayfa anasayfa = new frmAnaSayfa();
            anasayfa.ShowDialog();
          
        }
        SinemaTableAdapters.SalonTableAdapter salon = new SinemaTableAdapters.SalonTableAdapter();
                
        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
            try
            {
                salon.SalonEkleme(txtSalonAdı.Text);
                MessageBox.Show("Salon Eklendi", "Kayıt");
            }
            catch (Exception)
            {
                MessageBox.Show("Aynı Salonu Daha Önce Eklediniz", "UYARI");
            }
            txtSalonAdı.Text = "";
        }

        private void frmSalonEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
