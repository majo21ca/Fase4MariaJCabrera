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

            if (txtcontrase�a.Text == "")
            {
                MessageBox.Show("Registre la contrase�a");
            }
            else
            {
                if (txtcontrase�a.Text == "UNAD")
                {
                    Formulario_Principal Entrada = new Formulario_Principal();
                    Entrada.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("contrase�a incorrecta");
                }
            }

        }
    }
}
