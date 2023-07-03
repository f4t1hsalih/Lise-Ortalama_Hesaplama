using System;
using System.Windows.Forms;

namespace Ortalama_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Öğrenci ort = new Öğrenci();
            ort.Tckimlikno = textBox4.Text;
            ort.Ad = textBox6.Text;
            ort.Soyad = textBox5.Text;
            MessageBox.Show(ort.Durum(double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text)));
        }
    }
}
