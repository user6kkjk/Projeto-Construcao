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
    public partial class AreaEVolume : Form
    {
        decimal comprimento;
        decimal largura;
        decimal altura;
        public AreaEVolume()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comprimento = Convert.ToDecimal(textBox2.Text);
            largura = Convert.ToDecimal(textBox4.Text);
            altura = Convert.ToDecimal(textBox1.Text);

            decimal resultado = comprimento * largura * altura;

            textBox3.Text = resultado.ToString() + " m³";
        }
    }
}
