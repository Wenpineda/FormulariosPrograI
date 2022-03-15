namespace Practica_PrograFormularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 frm = new Form2();

            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 frm = new Form3();

            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form4 frm = new Form4();

            frm.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}