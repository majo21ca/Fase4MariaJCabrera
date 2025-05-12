using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase4MariaJCabrera
{
    class Arbol
    {
        public NODO raiz;

        public Arbol()
        {
            raiz = null;
        }
        public void Agregar(int valor)
        {
            raiz = AgregarRecursivo(raiz, valor);
        }

        private NODO AgregarRecursivo(NODO nodo, int valor)
        {
            if (nodo == null)
            {
                nodo = new NODO(valor);
            }
            else if (nodo.Valor< valor)
            {
                nodo.DER = AgregarRecursivo(nodo.DER, valor);
            }
            else if (nodo.Valor> valor)
            {
                nodo.IZQ = AgregarRecursivo(nodo.IZQ, valor);
            }
            return nodo;
        }

        public void Dibujararbol(Graphics g, NODO nodo,int X,int Y, int Desplazamiento)
        {
            const int radio = 30;
            if (nodo != null)
            {
                // Dibuja el nodo
                g.FillEllipse(Brushes.LightPink, X, Y, radio, radio);
                g.DrawString(nodo.Valor.ToString(), new Font("Arial", 10), Brushes.Black, X + 5, Y + 8);
                g.DrawEllipse(Pens.Black, X, Y, radio, radio);

                int centroX = X + radio / 2;
                int centroY = Y + radio / 2;

                if (nodo.IZQ != null)
                {
                    int hijoX = X - Desplazamiento;
                    int hijoY = Y + 60;
                    int hijoCentroX = hijoX + radio / 2;
                    int hijoCentroY = hijoY + radio / 2;

                    // Calcular punto desde borde del círculo padre hacia hijo
                    Point puntoInicio = CalcularPuntoEnBorde(centroX, centroY, hijoCentroX, hijoCentroY, radio / 2);
                    Point puntoFin = CalcularPuntoEnBorde(hijoCentroX, hijoCentroY, centroX, centroY, radio / 2);

                    g.DrawLine(Pens.Black, puntoInicio, puntoFin);
                    Dibujararbol(g, nodo.IZQ, hijoX, hijoY, Desplazamiento / 2);
                }

                if (nodo.DER != null)
                {
                    int hijoX = X + Desplazamiento;
                    int hijoY = Y + 60;
                    int hijoCentroX = hijoX + radio / 2;
                    int hijoCentroY = hijoY + radio / 2;

                    Point puntoInicio = CalcularPuntoEnBorde(centroX, centroY, hijoCentroX, hijoCentroY, radio / 2);
                    Point puntoFin = CalcularPuntoEnBorde(hijoCentroX, hijoCentroY, centroX, centroY, radio / 2);

                    g.DrawLine(Pens.Black, puntoInicio, puntoFin);
                    Dibujararbol(g, nodo.DER, hijoX, hijoY, Desplazamiento / 2);
                }
            }
         }
        private Point CalcularPuntoEnBorde(int x1, int y1, int x2, int y2, int radio)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            double dist = Math.Sqrt(dx * dx + dy * dy);
            if (dist == 0) return new Point(x1, y1); // Evitar división por cero

            double ratio = radio / dist;
            int nuevoX = x1 + (int)(dx * ratio);
            int nuevoY = y1 + (int)(dy * ratio);

            return new Point(nuevoX, nuevoY);
        }
        public bool Buscar(int valor)
        {
            return BuscarRecursivo(raiz, valor);
        }
        private bool BuscarRecursivo(NODO nodo, int valor)
        {
            if (nodo == null)
                return false;
            if (nodo.Valor == valor)
                return true;
            if (valor < nodo.Valor)
                return BuscarRecursivo(nodo.IZQ, valor);
            else
                return BuscarRecursivo(nodo.DER, valor);

        }
        public List<int> RecPreorden()
        {
            List<int> recorrido = new List<int>();
            RecPreorden(raiz, recorrido);
            return recorrido;
        }
        private void RecPreorden(NODO nodo, List<int> recorrido)
        {
            if(nodo != null)
            {
                recorrido.Add(nodo.Valor);
                RecPreorden(nodo.IZQ, recorrido);
                RecPreorden(nodo.DER, recorrido);
            }
        }
        public List<int> RecInorden()
        {
            List<int> recorrido = new List<int>();
            RecInorden(raiz, recorrido);
            return recorrido;
        }
        private void RecInorden(NODO nodo, List<int> recorrido)
        {
            if (nodo != null)
            {
                
                RecInorden(nodo.IZQ, recorrido);
                recorrido.Add(nodo.Valor);
                RecInorden(nodo.DER, recorrido);
            }

        }
        public List<int> RecPosorden()
        {
            List<int> recorrido = new List<int>();
            RecPosorden(raiz, recorrido);
            return recorrido;
        }

        private void RecPosorden(NODO nodo, List<int> recorrido)
        {
            if (nodo != null)
            {
                RecPosorden(nodo.IZQ, recorrido);
                RecPosorden(nodo.DER, recorrido);
                recorrido.Add(nodo.Valor);
            }
        }
    }

}
