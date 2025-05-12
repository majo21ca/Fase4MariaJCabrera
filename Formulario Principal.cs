using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase4MariaJCabrera
{
    public partial class Formulario_Principal : Form
    {
        private Arbol Elarbol;

        public Formulario_Principal()
        {
            InitializeComponent();
            Elarbol = new Arbol();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtregistro.Text, out int valor))
            {
                Elarbol.Agregar(valor);
                txtregistro.Clear();
                picarbol.Invalidate();
                panePre.Invalidate();
                panelIn.Invalidate();
                panelPos.Invalidate();

            }
            else
            {
                MessageBox.Show("Registre un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void picarbol_Paint(object sender, PaintEventArgs e)
        {
            Elarbol.Dibujararbol(e.Graphics, Elarbol.raiz, picarbol.Width / 2, 20, 100);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtregistro.Text, out int valor))
            {
                bool existe = Elarbol.Buscar(valor);
                if (existe)
                {
                    MessageBox.Show("Ya existe", "Buscar nodo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Nodo inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void panePre_Paint(object sender, PaintEventArgs e)
        {
            List<int> recorrido = Elarbol.RecPreorden();
            Graphics g = e.Graphics;

            int radio = 25;
            int espacio = 15;
            int x = 15;
            int y = (panePre.Height - radio) / 2;

            foreach (int valor in recorrido)
            {
                g.FillEllipse(Brushes.LightGreen, x, y, radio, radio);
                g.DrawEllipse(Pens.Black, x, y, radio, radio);

                using (Font fuente = new Font("Arial", 12))
                {
                    string texto = valor.ToString();
                    SizeF tamañoTexto = g.MeasureString(texto, fuente);
                    float textoX = x + (radio - tamañoTexto.Width) / 2;
                    float textoY = y + (radio - tamañoTexto.Height) / 2;
                    g.DrawString(texto, fuente, Brushes.Black, textoX, textoY);

                }
                x += radio + espacio;
            }
        }

        private void panelIn_Paint(object sender, PaintEventArgs e)
        {
            List<int> recorrido = Elarbol.RecInorden();
            Graphics g = e.Graphics;

            int radio = 25;
            int espacio = 15;
            int x = 15;
            int y = (panelIn.Height - radio) / 2;

            foreach (int valor in recorrido)
            {
                g.FillEllipse(Brushes.LightGreen, x, y, radio, radio);
                g.DrawEllipse(Pens.Black, x, y, radio, radio);

                using (Font fuente = new Font("Arial", 12))
                {
                    string texto = valor.ToString();
                    SizeF tamañoTexto = g.MeasureString(texto, fuente);
                    float textoX = x + (radio - tamañoTexto.Width) / 2;
                    float textoY = y + (radio - tamañoTexto.Height) / 2;
                    g.DrawString(texto, fuente, Brushes.Black, textoX, textoY);

                }
                x += radio + espacio;
            }
        }

        private void panelPos_Paint(object sender, PaintEventArgs e)
        {
            List<int> recorrido = Elarbol.RecPosorden();
            Graphics g = e.Graphics;

            int radio = 25;
            int espacio = 15;
            int x = 15;
            int y = (panelPos.Height - radio) / 2;

            foreach (int valor in recorrido)
            {
                g.FillEllipse(Brushes.LightGreen, x, y, radio, radio);
                g.DrawEllipse(Pens.Black, x, y, radio, radio);

                using (Font fuente = new Font("Arial", 12))
                {
                    string texto = valor.ToString();
                    SizeF tamañoTexto = g.MeasureString(texto, fuente);
                    float textoX = x + (radio - tamañoTexto.Width) / 2;
                    float textoY = y + (radio - tamañoTexto.Height) / 2;
                    g.DrawString(texto, fuente, Brushes.Black, textoX, textoY);

                }
                x += radio + espacio;
            }
        } 
    }

}



