using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxSon.Text = (Convert.ToDouble(textBoxSayi1.Text) * Convert.ToDouble(textBoxSayi2.Text)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           textBoxSon.Text = (Convert.ToDouble(textBoxSayi1.Text) + Convert.ToDouble(textBoxSayi2.Text)).ToString();
        }

        private void buttonCik_Click(object sender, EventArgs e)
        {
            textBoxSon.Text = (Convert.ToDouble(textBoxSayi1.Text) - Convert.ToDouble(textBoxSayi2.Text)).ToString();
        }

        private void buttonBol_Click(object sender, EventArgs e)
        {
            textBoxSon.Text = (Convert.ToDouble(textBoxSayi1.Text) / Convert.ToDouble(textBoxSayi2.Text)).ToString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBoxSayi1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
