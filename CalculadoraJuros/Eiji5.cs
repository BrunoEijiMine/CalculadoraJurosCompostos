using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraJuros
{
    public partial class Eiji5 : Form
    {
        public Eiji5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double D, V, I, aux1, resultado;

            D = double.Parse(txtD.Text);
            V = double.Parse(txtV.Text);
            I = double.Parse(txtI.Text);

            I = I / 100;
            aux1 = (I * (V - D));

            resultado = D / aux1;
            txtR.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Blue;
            button1.BackColor = Color.Transparent;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
            button1.BackColor = Color.Transparent;
        }
    }
}
