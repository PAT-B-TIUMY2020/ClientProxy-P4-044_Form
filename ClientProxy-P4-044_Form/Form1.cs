using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxy_P4_044_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            txtPenjumlahan1.Enabled = false;
            txtPenjumlahan2.Enabled = false;
            txtPengurangan1.Enabled = false;
            txtPengurangan2.Enabled = false;
            txtPerkalian1.Enabled = false;
            txtPerkalian2.Enabled = false;
            txtPembagian1.Enabled = false;
            txtPembagian2.Enabled = false;
            txtKoordinat.Enabled = false;
            txtHasilPenjumlahan.Enabled = false;
            txtHasilPengurangan.Enabled = false;
            txtHasilPerkalian.Enabled = false;
            txtHasilPembagian.Enabled = false;
            txtHasilKoordinat.Enabled = false;


            int hasil;

            txtPenjumlahan1.Text = "1";
            txtPenjumlahan2.Text = "2";
            hasil = Convert.ToInt32(txtPenjumlahan1.Text) + Convert.ToInt32(txtPenjumlahan2.Text);
            txtHasilPenjumlahan.Text = hasil.ToString();

            txtPengurangan1.Text = "3";
            txtPengurangan2.Text = "2";
            hasil = Convert.ToInt32(txtPengurangan1.Text) - Convert.ToInt32(txtPengurangan2.Text);
            txtHasilPengurangan.Text = hasil.ToString();

            txtPerkalian1.Text = "2";
            txtPerkalian2.Text = "2";
            hasil = Convert.ToInt32(txtPerkalian1.Text) * Convert.ToInt32(txtPerkalian2.Text);
            txtHasilPerkalian.Text = hasil.ToString();

            txtPembagian1.Text = "2";
            txtPembagian2.Text = "2";
            hasil = Convert.ToInt32(txtPembagian1.Text) / Convert.ToInt32(txtPembagian2.Text);
            txtHasilPembagian.Text = hasil.ToString();

            
            double aX = 7;
            double aY = 8;

            double bX = 5;
            double bY = 6;
            double selisihX = aX - bX;
            double selisihY = aY - bY;
            double jarak = Math.Sqrt(Math.Pow(selisihX, 2) + Math.Pow(selisihY, 2));
            txtHasilKoordinat.Text = jarak.ToString();
        }

        private void txtHasilPenjumlahan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPenjumlahan1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
