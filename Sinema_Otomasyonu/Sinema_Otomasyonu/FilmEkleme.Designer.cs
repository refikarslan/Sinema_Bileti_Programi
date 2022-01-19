namespace Sinema_Otomasyonu
{
    partial class frmFilmEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilmEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.txtYönetmen = new System.Windows.Forms.TextBox();
            this.txtYapımYili = new System.Windows.Forms.TextBox();
            this.txtSüre = new System.Windows.Forms.TextBox();
            this.comboFilmTürü = new System.Windows.Forms.ComboBox();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetmen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Film Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Süre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yapım Yılı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Film Adı";
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Location = new System.Drawing.Point(166, 14);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(121, 22);
            this.txtFilmAdi.TabIndex = 1;
            // 
            // txtYönetmen
            // 
            this.txtYönetmen.Location = new System.Drawing.Point(166, 50);
            this.txtYönetmen.Name = "txtYönetmen";
            this.txtYönetmen.Size = new System.Drawing.Size(121, 22);
            this.txtYönetmen.TabIndex = 1;
            // 
            // txtYapımYili
            // 
            this.txtYapımYili.Location = new System.Drawing.Point(166, 170);
            this.txtYapımYili.Name = "txtYapımYili";
            this.txtYapımYili.Size = new System.Drawing.Size(121, 22);
            this.txtYapımYili.TabIndex = 1;
            // 
            // txtSüre
            // 
            this.txtSüre.Location = new System.Drawing.Point(166, 128);
            this.txtSüre.Name = "txtSüre";
            this.txtSüre.Size = new System.Drawing.Size(121, 22);
            this.txtSüre.TabIndex = 1;
            // 
            // comboFilmTürü
            // 
            this.comboFilmTürü.FormattingEnabled = true;
            this.comboFilmTürü.Location = new System.Drawing.Point(166, 88);
            this.comboFilmTürü.Name = "comboFilmTürü";
            this.comboFilmTürü.Size = new System.Drawing.Size(121, 24);
            this.comboFilmTürü.TabIndex = 2;
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilmEkle.ImageIndex = 0;
            this.btnFilmEkle.ImageList = this.ımageList1;
            this.btnFilmEkle.Location = new System.Drawing.Point(158, 237);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(117, 57);
            this.btnFilmEkle.TabIndex = 3;
            this.btnFilmEkle.Text = "FİLM EKLE";
            this.btnFilmEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "FilmEkle.jpg");
            this.ımageList1.Images.SetKeyName(1, "Afiş.png");
            this.ımageList1.Images.SetKeyName(2, "depositphotos_84356776-stock-illustration-its-movie-time-web-banner.jpg");
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 209);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tarih";
            // 
            // btnResimSec
            // 
            this.btnResimSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResimSec.ImageIndex = 2;
            this.btnResimSec.ImageList = this.ımageList1;
            this.btnResimSec.Location = new System.Drawing.Point(429, 300);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(109, 57);
            this.btnResimSec.TabIndex = 4;
            this.btnResimSec.Text = "AFİŞ SEÇ";
            this.btnResimSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(353, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 250);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmFilmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(578, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.btnFilmEkle);
            this.Controls.Add(this.comboFilmTürü);
            this.Controls.Add(this.txtYapımYili);
            this.Controls.Add(this.txtSüre);
            this.Controls.Add(this.txtYönetmen);
            this.Controls.Add(this.txtFilmAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "frmFilmEkle";
            this.Text = "Film Ekleme Sayfası";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFilmEkle_FormClosing);
            this.Load += new System.EventHandler(this.frmFilmEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.TextBox txtYönetmen;
        private System.Windows.Forms.TextBox txtYapımYili;
        private System.Windows.Forms.TextBox txtSüre;
        private System.Windows.Forms.ComboBox comboFilmTürü;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}