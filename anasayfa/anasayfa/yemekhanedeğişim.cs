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
    public partial class yemekhanedeğişim : Form
    {
        public yemekhanedeğişim()
        {
            InitializeComponent();
        }
        public static string yemekhanedegişim12;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "")
            {
                string yemekhane = comboBox2.Text;
                yemekhanedegişim12 = yemekhane;
                this.Close();
            }
            else if (comboBox2.Text ==" ")
            {
                MessageBox.Show("Lütfen Seçim Yapınız");
            }

            
        }
    }
}
