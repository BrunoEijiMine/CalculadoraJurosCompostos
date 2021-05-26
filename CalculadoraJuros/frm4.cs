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
    public partial class frm4 : Form
    {
        public frm4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm3 = new frm3();
            frm3.Show();
            this.Hide();
        }

        private void frm4_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm2 = new frm2();
            frm2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frm5 = new frm5();
            frm5.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var frm6 = new frm6();
            frm6.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var frm1 = new frm1();
            frm1.Show();
            this.Hide();
        }
    }
}
