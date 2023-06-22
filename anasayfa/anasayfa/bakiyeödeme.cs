using System;
using System.Collections;
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
    public partial class bakiyeödeme : Form
    {
        public bakiyeödeme()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Kart Üzerindeki İsimi Giriniz");
            }
            else if (maskedTextBox1.Text == " ")
            {
                MessageBox.Show("Kart Numarasını Giriniz");
            }

            else if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Son Kullanma Tarihini Giriniz");

            }
            else if (maskedTextBox2.Text == "")
            {
                MessageBox.Show("CVV Giriniz");

            }
            else if (maskedTextBox2.Text.Length != 3)
            {
                MessageBox.Show("CVV Eksik Girdiniz");

            }
            else
            {

            }
            ArrayList kart = new ArrayList();

            for (int i = 0; i < 19; i++)
            {
                kart.Add(maskedTextBox1.Text.Substring(i, 1));
                kart.Remove(" "); kart.Remove(" "); kart.Remove(" ");

            }

            ArrayList cift = new ArrayList();
            for (int k = 0; k < 16; k++)
            {
                if (k % 2 == 0)
                {
                    cift.Add(2 * Convert.ToInt32(kart[k].ToString()));
                }
            }
            string tam = "";
            foreach (int a in cift)
            {
                tam += a.ToString();

            }

            int toplam_cift = 0, toplam_tek = 0, toplam = 0;
            for (int j = 0; j < tam.Length; j++)
            {
                toplam_cift += Convert.ToInt32(tam.Substring(j, 1));
            }
            for (int m = 1; m < 16; m += 2)
            {
                toplam_tek += Convert.ToInt32(kart[m]);
            }
            toplam = toplam_tek + toplam_cift;
            if (toplam % 10 == 0)
            {


                textBox1.Text = " ";
                comboBox1.Text = " ";
                comboBox2.Text = " ";
                maskedTextBox2.Text = " ";
                int gelengunc = Form1.güncbakiye;
                int yükle = Convert.ToInt32(label7.Text);
                yüklencekbakiye = yükle;
                MessageBox.Show("Ödeme Başarılı");
                this.Hide();


            }
            else
            {
                MessageBox.Show("Geçersiz Kart Numarası");
                maskedTextBox1.Text = " ";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label8.Text = textBox1.Text;
            textBox1.MaxLength = 30;
        }


        private void maskedTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            label9.Text = maskedTextBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label10.Text = comboBox1.Text + "/" + comboBox2.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label10.Text = comboBox1.Text + "/" + comboBox2.Text;
        }

        private void maskedTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            label11.Text = maskedTextBox2.Text;
            pictureBox2.Visible = true;
            label11.Visible = true;
        }

        private void bakiyeödeme_Load(object sender, EventArgs e)
        {
            label7.Text = bakiyeyükleme.ödemegtutar.ToString();
            int gelengunc = Form1.güncbakiye;
            label13.Text = gelengunc.ToString();
            pictureBox2.Visible = false;
            label11.Visible = false;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            label11.Visible = false;
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            label11.Visible = false;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            label11.Visible = false;
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            label11.Visible = false;
        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            label11.Visible = true;
        }


        public static int yüklencekbakiye;
    }
}
