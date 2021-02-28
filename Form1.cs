using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversiteNotHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }//
        Islem IS = new Islem();
        private void button2_Click(object sender, EventArgs e)
        {
            double not, katsayi;
            int vize, final, kredi;
            string katHarf;

            kredi = Convert.ToInt32(nudKredi.Value);
            vize = Convert.ToInt32(nudVize.Value);
            final = Convert.ToInt32(nudFinal.Value);



            IS.NotAl(vize, final, kredi, out not, out katsayi, out katHarf);

            lblDersOrtalamasi.Text = "Ortalama : " + not.ToString();
            lblVize.Text = "Vize : " + vize.ToString();
            lblFinal.Text = "Final : " + final.ToString();

            string[] bilgiler = {"", not.ToString(), kredi.ToString(), katHarf, katsayi.ToString(), txtDers.Text };
            ListViewItem lst = new ListViewItem(bilgiler);
            listViewNotlar.Items.Add(lst);

            clearTextbox();
            notYazdir();

            nudKredi.Select();
        }

        void notYazdir()
        {
            if (listViewNotlar.Items.Count > 1)
            {
                double ort = IS.Hesapla();
                lblGenelOrtalama.Text = (ort * 25).ToString("0.##");
                lbl4uzerinden.Text = ort.ToString("0.##");
            }
            lblGirilenDersSayisi.Text = listViewNotlar.Items.Count.ToString();
        }

        void clearTextbox()
        {
            nudFinal.Value = 0;
            nudVize.Value = 0;
            nudKredi.Value = 1;
            txtDers.Clear();
        }

        void clearLabel()
        {
            lbl4uzerinden.Text = null;
            lblDersOrtalamasi.Text = null;
            lblGenelOrtalama.Text = null;
            lblVize.Text = null;
            lblFinal.Text = null;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listViewNotlar.CheckedItems.Count > 0)
            {
                DialogResult x = MessageBox.Show("Seçilen dersin notunu silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
                if (x == DialogResult.Yes)
                {
                    foreach (ListViewItem secilikayitbilgisi in listViewNotlar.CheckedItems)
                    {
                        IS.sil(secilikayitbilgisi.Index);
                        secilikayitbilgisi.Remove();

                    }
                    notYazdir();
                    if (listViewNotlar.Items.Count < 2)
                    {
                        clearLabel();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seçilen herhangi bir ders olmadığı için silme işlemi yapılamadı.");
            }
        }

        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Bütün notları ve ortalamaları silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                IS.HepsiniSil();
                listViewNotlar.Items.Clear();
                clearLabel();
                lblGirilenDersSayisi.Text = "0";
            }

        }

        private void nudKredi_Click(object sender, EventArgs e)
        {
            nudKredi.Select(0, 2);
        }

        private void nudVize_Click(object sender, EventArgs e)
        {
            nudVize.Select(0, 3);
        }

        private void nudFinal_Click(object sender, EventArgs e)
        {
            nudFinal.Select(0, 3);
        }
    }
}
