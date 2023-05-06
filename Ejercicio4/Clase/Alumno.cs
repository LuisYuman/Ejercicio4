using Ejercicio4.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Clase
{
    internal class Alumno : IPersona
    {
        public string Nombre { get; }

        public int Edad { get ; }

        public void CumplirAños(int Edad)
        {
            Console.WriteLine($"Cumpliste años{Edad}");
            
        }

        public void saludar(String Nombre)
        {
            Console.WriteLine($"Hola!!!!{Nombre}");
        }
    }
}
