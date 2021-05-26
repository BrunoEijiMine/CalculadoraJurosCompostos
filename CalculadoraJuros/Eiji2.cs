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
    public partial class Eiji2 : Form
    {
        public Eiji2()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Blue;
            button1.BackColor = Color.Transparent;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Pink;
            button1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //D = (V X i X n) / (1 + i X n) 
            double D, V, N, I, var1, var2;

            V = Convert.ToDouble(txtNOMINAL.Text);
            I = Convert.ToDouble(txtTAXADEJUROS.Text);
            N = Convert.ToDouble(txtPERIODO.Text);

            I = I / 100;
            var1 = V * I * N;
            var2 = 1 + I * N;
            D = var1 / var2;

            txtDESCONTO.Text = D.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
