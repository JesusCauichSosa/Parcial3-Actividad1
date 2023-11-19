using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1.Domain
{
    public class NodoArbol
    {
        public Libro Libro { get; set; }
        public NodoArbol Izquierdo { get; set; }
        public NodoArbol Derecho { get; set; }

    }
}
