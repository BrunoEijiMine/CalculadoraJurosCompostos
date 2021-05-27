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
    public partial class Eiji3 : Form
    {
        public Eiji3()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double D, I, N, aux1, aux2, resultado;

            D = Convert.ToDouble(txtDesconto.Text);
            I = Convert.ToDouble(txtTaxaUnitaria.Text);
            N = Convert.ToDouble(txtAntecipação.Text);

            I = I / 100;
            aux1 = (1 + I * N);
            aux2 = (I * N);

            resultado = (D * aux1) / aux2;

            txtResultados.Text = resultado.ToString();

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Purple;
            button2.BackColor = Color.Transparent;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
            button2.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
