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
    public partial class yemeklistesi : Form
    {
        public yemeklistesi()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            rezervasyonform rezervasyonform = new rezervasyonform();
            rezervasyonform.Show();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            bakiyeyükleme bakiyeform = new bakiyeyükleme();
            bakiyeform.Show();
            this.Hide();

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            rezerveiptal sf =new rezerveiptal();
            sf.Show();
            this.Hide();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            yorum sdf =new yorum();
            sdf.Show();
            this.Hide();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            yemeklistesi yemeklistesi1 = new yemeklistesi();
            yemeklistesi1.Show();
            this.Hide();

        }
    }
}
