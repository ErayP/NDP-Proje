using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Concurrent;
namespace eray
{
    public partial class depo : Form
    {
        Urun urun = new Urun();
        public static List<string> Urunk = new List<string>();
        public static List<int> Raf = new List<int>();
        public  static List<int> Depo = new List<int>();
        int a = 0;

        public depo()
        {
            InitializeComponent();
        }

        private void depo_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            try
            {
            urun.urunkodu = textBox1.Text;
            urun.depo = Convert.ToInt32(textBox2.Text);
            urun.raftaki = Convert.ToInt32(textBox3.Text);
            Urunk.Add(urun.urunkodu);
            Depo.Add(urun.depo);
            Raf.Add(urun.raftaki);
            listBox1.Items.Add("Ürün kodu :  " + Urunk[a]+"  " + " Depodaki ürün miktarı : " + Depo[a] +"  "+ "Raftaki ürün miktarı : " + Raf[a]);
            a++;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Hata Listede ürün yok");
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Depo veya rafta ürün yok");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int silinecekindex=(listBox1.SelectedIndex);
            listBox1.Items.Remove(listBox1.SelectedItem);
            for (int i = 0; i < Urunk.Count; i++)
            {
                if (i==silinecekindex)
                {
                    Depo.RemoveAt(i);
                    Raf.RemoveAt(i);
                    Urunk.RemoveAt(i);
                    MessageBox.Show("Tamamlandı", "Silinme islemi tamamdır", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    a--;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < Urunk.Count; i++)
            {
                listBox1.Items.Add("Ürün kodu :  " + Urunk[i] + "  " + " Depodaki ürün miktarı : " + Depo[i] + "  " + "Raftaki ürün miktarı : " + Raf[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            satıs satıssayfası = new satıs();
            satıssayfası.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 tedarik = new Form1();
            tedarik.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2gec = new Form2();
            form2gec.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gider gidersayfasi = new gider();
            gidersayfasi.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Raftaki_malı_depoya_indir sayfagecis = new Raftaki_malı_depoya_indir();
            sayfagecis.Show();
        }
    }
}
