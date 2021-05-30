using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Algebra
{
    class Alumno
    {
        string carrera;
        string año;
        string nombre;
        string codigo = "202014006";
        public string Carrera { get => carrera; set => carrera = value; }
        public string Año { get => año; set => año = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    }
}
