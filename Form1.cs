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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculoMassa form2 = new CalculoMassa();
            this.Hide();

            form2.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AreaEVolume form2 = new AreaEVolume();
            this.Hide();

            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalculoMassa form2 = new CalculoMassa();
            this.Hide();

            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Blocos form2 = new Blocos();
            this.Hide();

            form2.ShowDialog();
        }
    }
}
