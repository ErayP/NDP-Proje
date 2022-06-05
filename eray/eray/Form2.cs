using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eray
{
    public partial class Form2 : Form
    {
        Urun urun = new Urun();
        public bool kontrol = true;
        public bool kontrol1 = true;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urun.urunkodu = textBox1.Text;
            urun.depo = Convert.ToInt32(textBox2.Text);
            for (int i = 0; i < depo.Urunk.Count ; i++)
            {
                if (urun.urunkodu==depo.Urunk[i])
                {
                    kontrol = true;
                    if (urun.depo<=depo.Depo[i])
                    {
                        kontrol1 = true;
                        depo.Depo[i] -= urun.depo;
                        depo.Raf[i] += urun.depo;
                        MessageBox.Show("İşlem başarı ile tamamlandı", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Depoda Yeterli ürün yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
