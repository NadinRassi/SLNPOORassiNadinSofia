using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class Camion : Transporte
    {
        public Camion(string marca, string modelo, int anio, string tipoCargamento, float capacidadcarga) : base(marca, modelo)
        {

            CapacidadCarga = capacidadcarga;
            Anio = anio;
            TipoCargamento = tipoCargamento;
        } 

        public int Anio { get; set; }

        public string TipoCargamento { get; set; }

        public float CapacidadCarga { get; set; }
        public Remolque Remolque { get; set; }

        public override string Acelerar()
        {
            return $"Camion Acelerando con motor a nafta";
        }

        public override string Frenar()
        {
            return $"Camion Frenando con potencia";
        }

        public string QuitarRemolque()
        {
            Remolque = null;
            return "Remolque suelto";
        }

        public override string ToString()
        {
            return $"Marca: {Marca}\n" +
                   $"Modelo: {Modelo}\n" +
                   $"Año: {Año}\n" +
                   $"Tipo de Carga: {TipoCargamento}\n" +
                   $"Capacidad: {CapacidadCarga}\n";
        }
    }
}
