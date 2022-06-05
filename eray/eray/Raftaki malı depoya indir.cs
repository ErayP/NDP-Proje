using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eray
{
    public partial class Raftaki_malı_depoya_indir : Form
    {
        Urun urun = new Urun();
        public bool kontrol = true;
        public bool kontrol1 = true;
        public Raftaki_malı_depoya_indir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urun.urunkodu = textBox1.Text;
            urun.raftaki = Convert.ToInt32(textBox2.Text);
            for (int i = 0; i < depo.Raf.Count; i++)
            {
                if (urun.urunkodu == depo.Urunk[i])
                {
                    kontrol = true;
                    if (urun.raftaki<=depo.Raf[i])
                    {
                        kontrol1 = true;
                        depo.Raf[i] -= urun.raftaki;
                        depo.Depo[i] += urun.raftaki;
                        MessageBox.Show("İşlem başarı ile tamamlandı", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Rafta Yeterli ürün yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    kontrol1 = false;
                }
               
            }
            if (!(kontrol))
            {
                MessageBox.Show("Böyle bir ürün bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

