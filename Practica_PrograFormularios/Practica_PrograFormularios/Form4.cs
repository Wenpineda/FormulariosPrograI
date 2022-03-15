using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_PrograFormularios
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(numero1.Text);
            double b = Convert.ToDouble(numero2.Text);
            double resultado = 0.0;
            if (rbdSumar.Checked == true) { resultado = a + b; }
            if (rbdResta.Checked == true) { resultado = a - b; }
            if (rbdMultiplicacion.Checked == true) { resultado = a * b; }
            if (rbdDivision.Checked == true) { resultado = a / b; }
            txtReultado.Text = resultado.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }

        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            numero1.Text = String.Empty;
            numero2.Text = String.Empty;
            txtReultado.Text = String.Empty;

        }

        private void txtReultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
