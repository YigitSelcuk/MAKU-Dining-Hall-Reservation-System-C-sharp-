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
    public partial class rezervasyonform : Form
    {
        public rezervasyonform()
        {
            InitializeComponent();
        }
        public static string seç1 = " ";
        public static string seç2 = " ";
        public static string pic1click= " ";
        public static string pic2click = " ";
        public static string seçilenyemekhane = " ";
        public static string seçilenyemekhane2 = " ";
        int toplamgün = 0;
        int tl = 1;

        public void pictureBox1_Click(object sender, EventArgs e)

        {
            string pic1 = "1";
            pic1click= pic1;
            if (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex == -1)
            {

                MessageBox.Show("Tarih ve Yemekhane Seçiniz");

            }
            else if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Yemekhane Seçiniz");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Tarih Seçiniz");
            }
            else if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
            {
                
                label1.ForeColor = Color.Orange;
                label43.Text = ("01.10.2022 Cumartesi  " + comboBox2.Text);
                seçilenyemekhane=label43.Text;
                pictureBox1.Visible = false;
                picture2Box1.Visible = true;
                picture3Box1.Visible = true;

                toplamgün++;
                günsayısı.Text = toplamgün.ToString();
                int tl = Convert.ToInt32(günsayısı.Text);
                
                odenecek.Text = Convert.ToString(tl * 8);
                
                seç1 ="               "+ label43.Text;
            }



        }

        public void picture2Box1_Click(object sender, EventArgs e)
        {
            label43.Text = "";
            picture2Box1.Visible = false;
            pictureBox1.Visible = true;
            picture3Box1.Visible= false;
            toplamgün--;
            label1.ForeColor = Color.Black;
            günsayısı.Text = toplamgün.ToString();
            int tl = Convert.ToInt32(günsayısı.Text);
            odenecek.Text = Convert.ToString(tl * 8);

        }


        public void picture3Box1_Click(object sender, EventArgs e)
        {

            yemekhanedeğişim ymkfrm = new yemekhanedeğişim();
            ymkfrm.ShowDialog();
            string seçilenyemek = yemekhanedeğişim.yemekhanedegişim12.ToString();
            comboBox2.Text = seçilenyemek;
            label43.Text = ("01.10.2022 Cumartesi  " + seçilenyemek);

        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {
            string pic2 = "2";
            pic2click = pic2;
            if (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex == -1)
            {

                MessageBox.Show("Tarih ve Yemekhane Seçiniz");

            }
            else if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Yemekhane Seçiniz");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Tarih Seçiniz");
            }
            else if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
            {
                label2.ForeColor = Color.Orange;
                label44.Text = ("01.10.2022 Cumartesi  " + comboBox2.Text);
                seçilenyemekhane2 = label44.Text;
                pictureBox2.Visible = false;
                picture2Box2.Visible = true;
                picture3Box2.Visible = true;

                toplamgün++;
                günsayısı.Text = toplamgün.ToString();
                int tl = Convert.ToInt32(günsayısı.Text);
                odenecek.Text = Convert.ToString(tl * 8);
                seç2 = "               " + label44.Text;
            }
        }

        public void picture2Box2_Click(object sender, EventArgs e)
        {
            label44.Text = "";
            picture2Box2.Visible = false;
            pictureBox2.Visible = true;
            picture3Box2.Visible = false;
            toplamgün--;
            label2.ForeColor = Color.Black;
            günsayısı.Text = toplamgün.ToString();
            int tl = Convert.ToInt32(günsayısı.Text);
            odenecek.Text = Convert.ToString(tl * 8);
        }
        public void picture3Box2_Click(object sender, EventArgs e)
        {
            yemekhanedeğişim ymkfrm = new yemekhanedeğişim();
            ymkfrm.ShowDialog();
            string seçilenyemek = yemekhanedeğişim.yemekhanedegişim12.ToString();
            comboBox2.Text = seçilenyemek;
            label44.Text = ("01.10.2022 Cumartesi  " + seçilenyemek);

        }
        public static string form2tutar ;
        public static string form2günsayısı = " ";
        public static int form2tutarint;


        public void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex == -1)

            {
                MessageBox.Show("Lütfen Tarih ve Yemekhane Seçiniz");
            }
           


          
            


            
            else if (radioButton1.Checked)

            {
                form2günsayısı = günsayısı.Text;
                form2tutar = odenecek.Text;
                kredikartödeme frm2=new kredikartödeme();
                frm2.Show();
                this.Hide();
                
                

            }
            else if (radioButton2.Checked)
            {
                int odencekbakiye = Convert.ToInt32(odenecek.Text);
                form2tutar = odenecek.Text;
                form2tutarint = odencekbakiye;
                ödemebakiye frm0=new ödemebakiye();
                frm0.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Lütfen Ödeme Yönetemi Seçiniz");
            }
        }

        public void pictureBox32_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        
        private void rezervasyonform_Load(object sender, EventArgs e)
        {
           
            if (ödemebakiye.ödendimikontrol=="okey")
            {
                if (ödemebakiye.pic1kontrol=="1")
                {
                    pictureBox1.Visible = false;
                    picture2Box1.Visible = false;
                    picture3Box1.Visible = false;
                    label35.Visible = true;
                    label1.ForeColor = Color.Orange;
                    label43.Text = Form1.yemekhaneadı;

                }
                if (ödemebakiye.pic2kontrol=="2")
                {
                    pictureBox2.Visible = false;
                    picture2Box2.Visible = false;
                    picture3Box2.Visible = false;
                    label36.Visible = true;
                    label2.ForeColor = Color.Orange;
                    label44.Text = Form1.yemekhaneadı2;

                }
            }
        }
    }
}
