using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anasayfa
{
    public partial class ödemebakiye : Form
    {
        public ödemebakiye()
        {
            InitializeComponent();
        }
        public static int azalanbakiye;
        public static string seç1gönder = " ";
        public static string seç2gönder = " ";
        public static string ödendimikontrol = " ";
        public static string pic1kontrol = " ";
        public static string pic2kontrol = " ";
        public static string seçtimyemek = " ";
        public static string seçtimyemek2= " ";
        private void ödemebakiye_Load(object sender, EventArgs e)
        {

            double ödencek123 = rezervasyonform.form2tutarint;
            int gelengunc = Form1.güncbakiye;
            label1.Text = gelengunc.ToString();
            label5.Text = Convert.ToString(ödencek123);

            string pic1gelen = rezervasyonform.pic1click;
            string pic2gelen = rezervasyonform.pic2click;
            string seçyeemk = rezervasyonform.seçilenyemekhane;
            string seçyeemk2 = rezervasyonform.seçilenyemekhane2;

            pic1kontrol = pic1gelen;
            pic2kontrol = pic2gelen;
            seçtimyemek = seçyeemk;
            seçtimyemek2 = seçyeemk2;
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int gelengunc = Form1.güncbakiye;

            int ödencek1 =Convert.ToInt32(label5.Text);
            if (gelengunc<ödencek1)
            {
                MessageBox.Show("Yetersiz Bakiye");
            }
            else if (gelengunc>ödencek1)
            {


                azalanbakiye = ödencek1;

                
                MessageBox.Show("Ödeme Başarılı");
                label5.Text = "000";
                seç1gönder = rezervasyonform.seç1.ToString();
                seç2gönder = rezervasyonform.seç2.ToString();
                string ödendimi = "okey";
                ödendimikontrol = ödendimi;

            }

           
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            Form1 sdfs = new Form1();   
            sdfs.Show();
            this.Hide();
        }
    }
}
