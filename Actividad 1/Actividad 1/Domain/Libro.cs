using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1.Domain
{
    public class Libro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; } 
        public override string ToString()
        {
            return $"{ISBN} : {Titulo} - {Autor}";
        }

    }


}


