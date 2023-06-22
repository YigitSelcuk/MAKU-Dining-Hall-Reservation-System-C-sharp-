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
    public partial class yemekhanedeğişim2 : Form
    {
        public yemekhanedeğişim2()
        {
            InitializeComponent();
        }
        public static string yemekhanedegişim123;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "")
            {
                string yemekhane = comboBox2.Text;
                yemekhanedegişim123 = yemekhane;
                this.Close();
            }
            else if (comboBox2.Text == " ")
            {
                MessageBox.Show("Lütfen Seçim Yapınız");
            }
        }
    }
}
