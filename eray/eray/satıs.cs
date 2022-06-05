using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eray
{
    public partial class satıs : Form
    {
        Urun urun = new Urun();
        Müsteri müsteri = new Müsteri();
        public static List<string> Urunk = new List<string>();
        public static List<int> Raf = new List<int>();
        public static List<int> Depo = new List<int>();
        public static List<string> adsoyad = new List<string>();
        public static List<string> TC = new List<string>();
        depo deposayfasi = new depo();
        public static bool kontrol = false;
        public static List<int> gelir = new List<int>();
        int gelirrr;
        int a = 0;
        public satıs()
        {
            InitializeComponent();
        }

        private void satıs_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < depo.Urunk.Count; i++)
            {
                urun.urunkodu = depo.Urunk[i];
                Urunk.Add(urun.urunkodu);
                urun.depo = depo.Depo[i];
                Depo.Add(urun.depo);
                urun.raftaki = depo.Raf[i];
                Raf.Add(urun.raftaki);

            }
            urun.urunkodu = textBox1.Text;
            urun.birimadedi = Convert.ToInt32(textBox2.Text);
            urun.satılanurunfiyatı = Convert.ToInt32(textBox3.Text);
            müsteri.adsoy = textBox4.Text;
            müsteri.TC = textBox5.Text;
            for (int i = 0; i < depo.Urunk.Count; i++)
            {
                if (urun.urunkodu==Urunk[i])
                {
                    if (urun.birimadedi<=depo.Raf[i])
                    {
                        depo.Raf[i] -= urun.birimadedi;
                        MessageBox.Show(Convert.ToString(depo.Raf[i]));
                        listBox1.Items.Add("Ürün kodu   : " + urun.urunkodu + " Satılan ürün miktarı   : " + urun.birimadedi + " Satılan ürünün birim fiyatı   : " + urun.satılanurunfiyatı + " Müşterinin Adı soyadı   : " + müsteri.adsoy + " Müşterinin TC kimlik numarası   :" + müsteri.TC);
                        gelir.Add(urun.satılanurunfiyatı * urun.birimadedi);
                        
                    }
                    else
                    {
                        MessageBox.Show("Hata !", "Rafta Yeterli ürün yok", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    kontrol = true;
                }
                else
                {
                    kontrol = true;
                }
            }
            if (!(kontrol))
            {
                MessageBox.Show("Ürün kodu bulunamadı", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            for (int i = 0; i < gelir.Count; i++)
            {
                gelirrr += gelir[i];
            }
            label7.Text = Convert.ToString(gelirrr);
        }
    }
}
