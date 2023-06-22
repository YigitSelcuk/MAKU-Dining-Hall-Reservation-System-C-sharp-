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
    public partial class bakiyeyükleme : Form
    {
        public bakiyeyükleme()
        {
            InitializeComponent();
        }

        public static string ödemegtutar = " ";
        

        int bakiye = 0;

        private void bakiyeyükleme_Load(object sender, EventArgs e)
        {
            label1 .Text =Form1.güncbakiye.ToString();
        }
        private void bunifuMaterialTextbox1_Click_1(object sender, EventArgs e)
        {
            

        }

   

       

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
            int label6sayı = Convert.ToInt32(textBox2.Text);
            int label1sayı=Convert.ToInt32(label1.Text);
             int toplamartış= label6sayı +label1sayı;
            ödemegtutar = textBox2.Text;

            if (textBox2.Text != "000"&&textBox2.Text!=" ")
            {
                bakiyeödeme frm7 = new bakiyeödeme();
                frm7.ShowDialog();
            }
            bakiye = 0;
            textBox2.Text = "000";
            

          
           
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button81_Click(object sender, EventArgs e)
        {
            bakiye += 5;
            textBox2.Text = bakiye.ToString();
        }

        private void button131_Click(object sender, EventArgs e)
        {
            bakiye += 10;
            textBox2.Text = bakiye.ToString();
        }

        private void button121_Click(object sender, EventArgs e)
        {
            bakiye += 20;
            textBox2.Text = bakiye.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            bakiye += 30;
            textBox2.Text = bakiye.ToString();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            bakiye += 40;
            textBox2.Text = bakiye.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bakiye += 50;
            textBox2.Text = bakiye.ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            bakiye += 100;
            textBox2.Text = bakiye.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bakiye += 200;
            textBox2.Text = bakiye.ToString();
        }

            private void button11_Click(object sender, EventArgs e)
        {
            bakiye += 500;
            textBox2.Text = bakiye.ToString();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            Form1 grm1 = new Form1();
            grm1.Show();
            this.Hide();
        }

        
    }
}
