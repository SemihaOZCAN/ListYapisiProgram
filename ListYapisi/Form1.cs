using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ListYapisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Kisiler listesini listele
        private void buttonListele1_Click(object sender, EventArgs e)
        {
            List<string> kisiler = new List<string>();
            kisiler.Add("Mazhar");
            kisiler.Add("Ruhsar");
            kisiler.Add("Menkıbe");
            kisiler.Add("Müfit");
            kisiler.Add("Reyhan");
            kisiler.Add("Firdevs");
            foreach (string k in kisiler)
            {
                listBox1.Items.Add(k);
            }

        }
        // Sayilar listesini listele ve 5'e bölünen sayıları göster
        private void buttonListele2_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(45);
            sayilar.Add(74);
            sayilar.Add(25);
            sayilar.Add(33);
            sayilar.Add(22);
            sayilar.Add(15);
            sayilar.Add(17);

            // 5'e bölünen sayıları listbox'a ekle
            foreach (int s in sayilar)
            {
                if (s % 5 == 0)
                {
                    listBox2.Items.Add(s);
                }
            }

            // TextBox'tan girilen sayıyı al ve kontrol et
            if (int.TryParse(textBox1.Text, out int girilenSayi))
            {
                if (sayilar.Contains(girilenSayi))
                {
                    MessageBox.Show($"{girilenSayi} sayısı listede mevcut.");
                }
                else
                {
                    MessageBox.Show($"{girilenSayi} sayısı listede bulunmuyor.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.");
            }
        }
        // KISILER sınıfı listele
        private void buttonListele3_Click_1(object sender, EventArgs e)
        {
            List<KISILER> kisi = new List<KISILER>();
            kisi.Add(new KISILER()
            {
                ADI = "Ali",
                SOYADI = "ÇINAR",
                MESLEKI = "Yazılım Mühendisi"
            });
            foreach (KISILER k in kisi)
            {
                listBox3.Items.Add(k.ADI+ " " +k.SOYADI+ " "+k.MESLEKI);
            }
        }
    }

}

