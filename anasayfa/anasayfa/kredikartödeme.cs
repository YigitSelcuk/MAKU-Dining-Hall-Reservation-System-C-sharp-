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
    public partial class kredikartödeme : Form
    {
        public kredikartödeme()
        {
            InitializeComponent();
        }

      

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void kredikartödeme_Load(object sender, EventArgs e)
        {
            form2label7.Text = rezervasyonform.form2tutar.ToString();
            form2label8.Text = rezervasyonform.form2günsayısı.ToString();
            pictureBox2.Visible=false;
            label11.Visible=false;
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
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
                MessageBox.Show("Ödeme Başarılı");
                Form1 form1 = new Form1();
                form1.Show();
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
            textBox1.MaxLength = 30;
           label8.Text = textBox1.Text ;
        }

        private void maskedTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            label9.Text = maskedTextBox1.Text ;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label10.Text = comboBox1.Text+"/"+comboBox2.Text ;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label10.Text = comboBox1.Text + "/" + comboBox2.Text;
        }

        private void maskedTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            pictureBox2.Visible = true;
            label11.Visible = true;
            label11.Text = maskedTextBox2.Text;
        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            label11.Visible = true;
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

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            rezervasyonform frm3 = new rezervasyonform();
            frm3.Show();
            this.Hide();
        }
    }


}

