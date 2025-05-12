using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase4MariaJCabrera
{
    class NODO
    {
        public int Valor { get; set; }
        public NODO DER;
        public NODO IZQ;
        
        public NODO(int valor)
        {
            Valor = valor;
            DER = null;
            IZQ = null;
        }
    }
}
