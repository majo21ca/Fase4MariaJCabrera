namespace Fase4MariaJCabrera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtcontraseña.Text == "")
            {
                MessageBox.Show("Registre la contraseña");
            }
            else
            {
                if (txtcontraseña.Text == "UNAD")
                {
                    Formulario_Principal Entrada = new Formulario_Principal();
                    Entrada.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("contraseña incorrecta");
                }
            }

        }
    }
}
