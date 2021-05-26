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
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();           
        }       

        private void frm3_Load(object sender, EventArgs e)
        {

        }

        private void txtJUROS_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var frm4 = new frm4();
            frm4.Show();
            this.Hide();
        }

        private void txtPERÍODO_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            double M, C, T, J;

            C = Double.Parse(txtCAPITAL.Text);
            J = Double.Parse(txtJUROS.Text);
            T = Double.Parse(txtPERÍODO.Text);

            J = J / 100;
            double D = (1 + J);
            double L = Math.Pow(D, T);  

            M = C * L;

            txtMONTANTE.Text = M.ToString();
        }
    }
}
