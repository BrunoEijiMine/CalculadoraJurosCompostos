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
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void txtJUROS_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCAPITAL_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtTAXA_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtPERÍODO_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double resultado, montante, taxa, tempo;

            montante = Double.Parse(txtCAPITAL.Text);
            taxa = Double.Parse(txtTAXA.Text);
            tempo = Double.Parse(txtPERÍODO.Text);

            taxa = taxa / 100;
            double D = (1 + taxa);
            double L = Math.Pow(D, tempo);


            resultado = montante / L ;

            txtJUROS.Text = resultado.ToString();
        }

        private void txtCAPITAL_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var frm4 = new frm4();
            frm4.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtJUROS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPERÍODO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
