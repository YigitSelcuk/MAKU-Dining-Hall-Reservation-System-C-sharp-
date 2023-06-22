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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int güncbakiye ;
        public static string yemekhaneadı = " ";
        public static string yemekhaneadı2 = " ";
        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            int bakiyelerr = Convert.ToInt32(label11.Text);
            güncbakiye =bakiyelerr;
            rezervasyonform frm2 = new rezervasyonform();
            frm2.Show();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            int bakiyelerr = Convert.ToInt32(label11.Text);
            güncbakiye = bakiyelerr;
            bakiyeyükleme frm4 =new bakiyeyükleme();  
            
            frm4.Show();
            this.Hide();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            rezerveiptal frm8 =new rezerveiptal();
            
            frm8.Show();
            this.Hide();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            yorum frm9 =new yorum();
            frm9.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

              if (bakiyeödeme.yüklencekbakiye != 0)
              {
               int yüklegelen = bakiyeödeme.yüklencekbakiye;
               int bakiyeınt = Convert.ToInt32(label11.Text);
               int yüklemebakiye1 = yüklegelen + bakiyeınt;
               string yüklemebakiyestr = Convert.ToString(yüklemebakiye1);
               label11.Text = yüklemebakiyestr;
                    
              }


            if (ödemebakiye.azalanbakiye != 0)
            {
                int bakiyeınt = Convert.ToInt32(label11.Text);
                int  azalanbak = ödemebakiye.azalanbakiye;
                int azalansonbak = bakiyeınt - azalanbak;
                label11.Text = Convert.ToString(azalansonbak);

            }

            yemekhaneadı = ödemebakiye.seçtimyemek;
            yemekhaneadı2 = ödemebakiye.seçtimyemek2;



        }

        private void bunifuFlatButton6_Click_1(object sender, EventArgs e)
        {
             yemeklistesi yemeklistesi = new yemeklistesi();
             yemeklistesi.Show();
             this.Hide();   
        }
    }
}
