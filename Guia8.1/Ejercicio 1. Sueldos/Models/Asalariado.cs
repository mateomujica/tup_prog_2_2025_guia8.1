using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1._Sueldos.Models
{
    internal class Asalariado : Empleado, IExportable
    {
        public double Basico { get; set; }
        public double Aportes { get; private set; }

        public Asalariado (int dni, string nombre,double basico, double aportes) : base (dni,nombre)
        {
            this.Basico = basico;
            this.Aportes = aportes;
        }

        public override double CalcularImporteAPagar()
        {
            return Basico - Aportes;
        }

        public override string[] GenerarRecibo()
        {
            List<string> recibo = new List<string>();

            recibo.Add($" Nombre {Nombre} DNI {DNI}");
            recibo.Add($" Basico ${Basico}");
            recibo.Add($" Aportes ${Aportes}");
            recibo.Add($" Total: ${CalcularImporteAPagar()}");

            return recibo.ToArray();
        }

        public override string ToString()
        {
            return $" Nombre : {Nombre} DNI : {DNI}";
        }

        public string Exportar()
        {
            return $"Asalariado {DNI} {Nombre} / Basico {Basico}, Aportes {Aportes}";
        }

    }
}
