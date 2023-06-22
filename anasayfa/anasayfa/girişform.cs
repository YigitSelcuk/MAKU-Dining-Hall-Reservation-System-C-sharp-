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
    public partial class girişform : Form
    {
        public girişform()
        {
            InitializeComponent();
           





        }
        
        private void girişform_Load(object sender, EventArgs e)
        {

            string ogrencino = "123";
            string ogrencisifre = "123";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_MouseClick(object sender, MouseEventArgs e)
        {
            bunifuTextbox1.text = " ";
        }

        private void bunifuTextbox2_MouseClick(object sender, MouseEventArgs e)
        {
            bunifuTextbox2.text = " ";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string ogrencino = "123";
            string ogrencisifre = "123";
            
          

            
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            


        }
    }
}
