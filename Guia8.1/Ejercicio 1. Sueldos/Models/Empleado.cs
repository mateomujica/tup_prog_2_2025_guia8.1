using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1._Sueldos.Models
{
    abstract class Empleado : IComparable<Empleado>
    {
        public int DNI { get; private set; }
        public string Nombre { get; private set; }

        public Empleado (int dni, string nombre)
        {
            DNI = dni;
            Nombre= nombre;
        }

        public abstract double CalcularImporteAPagar();

        public abstract string[] GenerarRecibo();
        

        public int CompareTo(Empleado? otro)
        {
            if (otro !=null)
            {
                return this.DNI.CompareTo(otro.DNI);
            }
            return -1;
        }
    }
}
