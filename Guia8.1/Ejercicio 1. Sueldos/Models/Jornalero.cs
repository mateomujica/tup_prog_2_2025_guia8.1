using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1._Sueldos.Models
{
    internal class Jornalero : Empleado, IExportable 
    {
        public int Horas { get; private set; }
        public double Importe { get; set; }
        public double Retencion { get; private set; }


        public Jornalero(int dni, string nombre,int horas,double valorPorHora, double retencion) : base (dni,nombre)
        {
            this.Horas = horas;
            this.Importe= valorPorHora;
            this.Retencion= retencion;
            
        }

        public override double CalcularImporteAPagar()
        {
            return Horas * Importe - Retencion;
        }

        public override string[] GenerarRecibo()
        {
            List<string> recibo = new List<string>();

            recibo.Add($" Nombre {Nombre} DNI {DNI}");
            recibo.Add($" Importe en Horas {Horas}");
            recibo.Add($" Retenciones Impositivas {Retencion}");
            recibo.Add($" Importe a Percibir {Importe}");
            recibo.Add($" Total: ${CalcularImporteAPagar()}");

            return recibo.ToArray();
        }

        public override string ToString()
        {
            return $" Nombre : {Nombre} DNI : {DNI}";
        }

        public string Exportar()
        {
            return $"Jornelero {DNI} {Nombre} / Horas {Horas}, Retenciones {Retencion}";
        }
    }
}
