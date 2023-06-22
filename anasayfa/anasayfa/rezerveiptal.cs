using System;
using System.Windows.Forms;

namespace anasayfa
{
    public partial class rezerveiptal : Form
    {
        public rezerveiptal()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void rezerveiptal_Load(object sender, EventArgs e)
        {
            
            if (ödemebakiye.seç1gönder==" "&& ödemebakiye.seç2gönder != " ")
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

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            Form1 sdf = new Form1();
            sdf.Show();
            this.Hide();
        }
    }
}
