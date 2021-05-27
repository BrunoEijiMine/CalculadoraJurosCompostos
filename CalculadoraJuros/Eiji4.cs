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
    public partial class Eiji4 : Form
    {
        public Eiji4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        double resultado;
        public void button1_Click(object sender, EventArgs e)
        {
            double D, V, N, aux1, aux2;

            D = Convert.ToDouble(txtDESCONTOO.Text);
            V = Convert.ToDouble(txtVALORNOMINAL.Text);
            N = Convert.ToDouble(txtPERIODOO.Text);

            aux1 = (V - D);
            aux2 = (N * aux1);

            resultado = D / aux2;

            txtResposta.Text = resultado.ToString();
          
        }

        public void button3_Click(object sender, EventArgs e)
        {
            resultado = resultado * 100;

            txtResposta.Text = resultado.ToString("0.000") + "%";
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Blue;
            button3.BackColor = Color.Transparent;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
            button3.BackColor = Color.Transparent;
        }
    }
}
