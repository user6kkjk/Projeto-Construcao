using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetin_de_Construção
{
    public partial class Form3 : Form
    {
        decimal cimento;
        decimal areia;
        decimal brita;
        decimal agua;

        public Form3()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            cimento = Convert.ToDecimal(textBox2.Text);
            areia = Convert.ToDecimal(textBox1.Text);
            brita = Convert.ToDecimal(textBox3.Text);
            agua = Convert.ToDecimal(textBox5.Text);




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
