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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            double peso, altura, imc;
            peso = Convert.ToDouble(txtpeso.Text);
            altura = Convert.ToDouble(txtaltura.Text);
            imc = peso / (altura * altura);
            if (imc <  20)
            {
                lblResultado.Text = "Bajo de Peso \nIMC: " + imc;
            }
            else
                if(imc >= 20 && imc < 25)
                lblResultado.Text = "Peso Normal \nIMC: " + imc;
            else
                if (imc >= 25 && imc < 30)
                lblResultado.Text = "Sobre Peso \nIMC: " + imc;
            else
                if (imc >= 30 && imc < 40)
                lblResultado.Text = "Obeso \nIMC: " + imc;
            else
                lblResultado.Text = "Obeso Morbido \nIMC: " + imc;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtaltura.Text = String.Empty;
            txtpeso.Text = String.Empty;
            lblResultado.Text = String.Empty;
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
    
}
