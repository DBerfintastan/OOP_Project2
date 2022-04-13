/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 2
**				ÖĞRENCİ ADI............: Deniz Berfin Taştan
**				ÖĞRENCİ NUMARASI.......: B181210010
**              DERSİN ALINDIĞI GRUP...: 1-D
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b181210010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void arkadasmi_Click(object sender, EventArgs e)
        {
            this.Width = 822;
            this.Height = 437; //Ekran yeni boyutunu ayarlar.

            Label lblx = new Label();
            lblx.Text = "X Bölenleri";
            lblx.Location = new Point(400, 50);
            this.Controls.Add(lblx); 

            Label lbly = new Label();
            lbly.Text = "Y Bölenleri";
            lbly.Location = new Point(600, 50);
            this.Controls.Add(lbly); 

            Label toplamlar = new Label();
            toplamlar.Text = "TOPLAMLAR";
            toplamlar.Location = new Point(300, 241);
            this.Controls.Add(toplamlar); //Yeni label oluşturur.

            ListBox x_bolen = new ListBox();
            x_bolen.Location = new Point(400, 85);
            this.Controls.Add(x_bolen); // Arkadaş mı butonuna basıldığında yanda x bölenlerinin yazıldığı bir listbox alanı oluşturur.

            ListBox y_bolen = new ListBox();
            y_bolen.Location = new Point(600, 85);
            this.Controls.Add(y_bolen); // Arkadaş mı butonuna basıldığında yanda y bölenlerinin yazıldığı bir listbox alanı oluşturur.


            int x, y;
            int toplam1 = 0, toplam2 = 0;
            x = Convert.ToInt32(txtSayiX.Text);
            y = Convert.ToInt32(txtSayiY.Text);
            for (int i = 1; i < x; i++)
            {
                if (x % i == 0)
                {

                    x_bolen.Items.Add(Convert.ToString(i));
                    toplam1 += i;

                }
            } // x bölenlerini bulur
            for (int j = 1; j < y; j++)
            {
                if (y % j == 0)
                {

                    y_bolen.Items.Add(Convert.ToString(j));
                    toplam2 += j;

                }
            } // y bölenlerini bulur

            TextBox xtoplam = new TextBox();
            xtoplam.Location = new Point(400, 240);
            xtoplam.Text = Convert.ToString(toplam1);
            xtoplam.Size = new System.Drawing.Size(125, 25);
            this.Controls.Add(xtoplam); // Yanda x bölenlerinin toplamının yazıldığı bir textbox alanı oluşturur.

            TextBox ytoplam = new TextBox();
            ytoplam.Location = new Point(600, 240);
            ytoplam.Text = Convert.ToString(toplam2);
            xtoplam.Size = new System.Drawing.Size(125, 25);
            this.Controls.Add(ytoplam); // Yanda y bölenlerinin toplamının yazıldığı bir textbox alanı oluşturur.

        }

        private void son_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
