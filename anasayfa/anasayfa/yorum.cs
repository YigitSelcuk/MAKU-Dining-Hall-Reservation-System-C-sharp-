using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace anasayfa
{
    public partial class yorum : Form
    {
        public yorum()
        {
            InitializeComponent();
        }

        private void yorum_Load(object sender, EventArgs e)
        {
            if (ödemebakiye.seç1gönder == " " && ödemebakiye.seç2gönder != " ")
            {
                bunifuFlatButton1.Text = rezervasyonform.seç2;
            }
            else if (ödemebakiye.seç1gönder != " " && ödemebakiye.seç2gönder != " ")
            {
                bunifuFlatButton1.Text = ödemebakiye.seç1gönder;
                bunifuFlatButton2.Text = ödemebakiye.seç2gönder;
            }
            else if (ödemebakiye.seç1gönder != " " && ödemebakiye.seç2gönder == " ")
            {
                bunifuFlatButton1.Text = ödemebakiye.seç1gönder;

            }


        }

        private void bunifuFlatButton1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = bunifuFlatButton1.Text+" Tarihli Yemekhane Rezervasyonu Hakkında ";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 500;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="  ")
            {
                MessageBox.Show(" Lütfen Seçim Yapınız ");
            }

            else if (textBox3.Text == "  ")
            {
                MessageBox.Show(" Lütfen E-postanızı Giriniz");

            }
            else
            {
                MailMessage sms = new MailMessage();
                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential("yigitselcuk2910@gmail.com", "nmkrmsrbkler1");
                client.Port = 587;
                client.Host = "smtp.outlook.com";
                client.EnableSsl = true;
                sms.To.Add(textBox3.Text);
                sms.From = new MailAddress("yigitselcuk2910@gmail.com");
                sms.Subject = textBox1.Text;
                sms.Body = textBox2.Text;
                client.Send(sms);
                MessageBox.Show("İşlem Başarılı");
            }

           
            
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = bunifuFlatButton2.Text + " Tarihli Yemekhane Rezervasyonu Hakkında ";

            bunifuFlatButton2.Text = " ";
            bunifuFlatButton2.Enabled = false;
        }
    }
}
