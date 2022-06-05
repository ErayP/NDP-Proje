using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eray
{
    public partial class Form1 : Form
    {
        public static List<string> Urunk = new List<string>();
        public static List<int> Depo = new List<int>();
        public static List<int> gelenurun = new List<int>();
        public static List<int> Raf = new List<int>();
        Tedarikci tedarikci = new Tedarikci();
        Urun urun = new Urun();
        public bool kontrol = true;
        public static List<int> gider = new List<int>();
        public int sayac = 0;
        public int giderr;
        public Form1()
        {
            InitializeComponent();
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
            tedarikci.adsoyad = textBox2.Text;
            tedarikci.gelenurun = Convert.ToInt32(textBox3.Text);
            tedarikci.numarasi = textBox4.Text;
            tedarikci.fiyati = Convert.ToInt32(textBox5.Text);

            for (int i = 0; i < depo.Urunk.Count; i++)
            {
                if (urun.urunkodu==Urunk[i])
                {
                    depo.Depo[i] += tedarikci.gelenurun;
                    kontrol = false;
                    listBox1.Items.Add("Ürünün kodu : " + urun.urunkodu + " Tedarikci Adı ve Soyadı : " + tedarikci.adsoyad + " " + "Alınan ürün adedi : " + tedarikci.gelenurun + " Tedarikci numarası : " + tedarikci.numarasi);
                    gider.Add(tedarikci.gelenurun*tedarikci.fiyati);
                    break;
                }    
            }
            if (kontrol)
            {
                depo.Urunk.Add(urun.urunkodu);
                depo.Depo.Add(tedarikci.gelenurun);
                depo.Raf.Add(0);
                listBox1.Items.Add("Ürünün kodu : " + urun.urunkodu + " Tedarikci Adı ve Soyadı : " + tedarikci.adsoyad + " " + "Alınan ürün adedi : " + tedarikci.gelenurun + " Tedarikci numarası : " + tedarikci.numarasi);
                MessageBox.Show("Gelen mallar depoya ilave edildi", "", MessageBoxButtons.OK);
                gider.Add(tedarikci.gelenurun * tedarikci.fiyati);
            }
            for (int i = 0; i < gider.Count; i++)
            {
                giderr += gider[i];
            }
            label5.Text = Convert.ToString(giderr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
