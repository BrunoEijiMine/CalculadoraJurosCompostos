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
    public partial class frm5 : Form
    {
        public frm5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double M, C, T, J;

            C = Double.Parse(txtCAPITAL.Text);
            T = Double.Parse(txtPERIODO.Text);
            M = Double.Parse(txtMONTANTE.Text);

            double P = (M / C);
            double D = (1 / T);
            double L = Math.Pow(P, D);

            J = L - 1;

            J = J * 100;

            txtJUROS.Text = J.ToString();


        }

        private void txtTAXA_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frm5_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var frm4 = new frm4();
            frm4.Show();
            this.Hide();
        }

        private void txtCAPITAL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
