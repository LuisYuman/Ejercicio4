using Ejercicio4.Clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Interface
{
    public interface IPersona
    {
        String Nombre { get; }
        int Edad { get; }


        public void saludar(String Nombre)
        {
            Nombre = "Luis";
        }
        
        public void CumplirAños(int Edad)
        {
            Edad = 25;
        }
    }
}
