using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.FE
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btSumar_Click(object sender, EventArgs e)
        {
            int Op1;
            int Op2;
            int Resultado;

            Op1 = Convert.ToInt32(txtOp1.Text);
            Op2 = Convert.ToInt32(txtOp2.Text);

            Resultado = Op1 + Op2;

            
            txtResultado.Text = Resultado.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Op1;
            int Op2;
            int Resultado;

            Op1 = Convert.ToInt32(txtOp1.Text);
            Op2 = Convert.ToInt32(txtOp2.Text);

            Resultado = Op1 * Op2;

            
            txtResultado.Text = Resultado.ToString();
        }
    }
}
