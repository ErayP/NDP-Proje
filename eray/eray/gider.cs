using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eray
{
    public partial class gider : Form
    {
        public static List<int> toplamgider = new List<int> { 0 };
        Gider giderler = new Gider();
        depo deposayfasi = new depo();
        satıs satis_sayfasi = new satıs();
        kar netkar = new kar();
        public int gelir;
        public int giderr;
        public int para = 0;
        
        public gider()
        {
            InitializeComponent();
        }

        private void gider_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            giderler.gidersebebi = textBox1.Text;
            giderler.toplam_gider = Convert.ToInt32(textBox2.Text);
            if (textBox2.Text!=null)
            {
                toplamgider.Add(giderler.toplam_gider);
            }
            listBox1.Items.Add("Gider sebebi : " + giderler.gidersebebi + "              Toplam gider maliyeti : " + giderler.toplam_gider);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            giderr = 0;gelir = 0;
            for (int i = 0; i < Form1.gider.Count; i++)
            {
                giderr += Form1.gider[i];
            }
            for (int i = 0; i < toplamgider.Count; i++)
            {
                giderr += toplamgider[i];
            }
            for (int i = 0; i < satıs.gelir.Count; i++)
            {
                gelir += satıs.gelir[i];
            }
            para = gelir - giderr;
            label4.Text = Convert.ToString(para);
        }
    }
}
