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
    public partial class frm6 : Form
    {
        public frm6()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var frm4 = new frm4();
            frm4.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double M, C, T, J, L1, L2;

            C = Double.Parse(txtCAPITAL.Text);
            J = Double.Parse(txtJUROS.Text);
            M = Double.Parse(txtMONTANTE.Text);

            J = J / 100;
            L1 = Math.Log(M / C);
            L2 = Math.Log(1 + J);

            T = L1 / L2;

            txtPERIODO.Text = T.ToString();
        }
    }
}
