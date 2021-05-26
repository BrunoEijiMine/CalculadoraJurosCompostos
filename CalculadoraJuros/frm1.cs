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
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnJUROSSIMPLES_Click(object sender, EventArgs e)
        {
            var frm4 = new frm4();
            frm4.ShowDialog();
            this.Hide();
        }

        private void btnTTAXAUNITARIA_Click(object sender, EventArgs e)
        {
            var frm3 = new frm3();
            frm3.Show();
            this.Hide();
        }

        private void btnCAPITAL_Click(object sender, EventArgs e)
        {
            Eiji1 menu = new Eiji1();
            menu.ShowDialog();
            this.Hide();
        }

        private void btnCALCAPLI_Click(object sender, EventArgs e)
        {
            var frm5 = new frm5();
            frm5.Show();
            this.Hide();
        }

        private void frm1_Load(object sender, EventArgs e)
        {

        }
    }
}
