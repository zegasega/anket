using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanciadi = textBox1.Text;
            int yas;

            if (!int.TryParse(textBox2.Text, out yas))
            {
                MessageBox.Show("Geçerli bir yaş değeri giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string cinsiyet = "";
            if (radioButton1.Checked)
            {
                cinsiyet = "Erkek";
            }
            else if (radioButton2.Checked)
            {
                cinsiyet = "Kadın";
            }

            
            var kullaniciBilgisi = new
            {
                kullanciadi = kullanciadi,
                yas = yas,
                cinsiyet = cinsiyet
            };

            
            string dosyaAdi = "kullanicilar.json";
            List<object> kullaniciListesi;

            try
            {
                
                string json = File.ReadAllText(dosyaAdi);
                kullaniciListesi = JsonConvert.DeserializeObject<List<object>>(json);
            }
            catch (FileNotFoundException)
            {
                
                kullaniciListesi = new List<object>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dosya Okuma Hatası: " + ex.Message);
                return;
            }

            
            kullaniciListesi.Add(kullaniciBilgisi);

            try
            {
                
                string yeniJson = JsonConvert.SerializeObject(kullaniciListesi, Formatting.Indented);
                File.WriteAllText(dosyaAdi, yeniJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dosya Yazma Hatası: " + ex.Message);
                return;
            }
            MessageBox.Show("Bilgileriniz Başarıyla Kayıt Edildi");
            
            Application.Exit();
        }
    }
}
