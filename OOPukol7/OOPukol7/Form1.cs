using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPukol7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Produkt vec;
        bool x;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                vec = new Produkt(textBox1.Text, double.Parse(textBox2.Text), dateTimePicker1.Value, (int)numericUpDown1.Value,x );
                label5.Text = vec.ToString();
            }
            catch { }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            x = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            x = false;
        }
    }
}
