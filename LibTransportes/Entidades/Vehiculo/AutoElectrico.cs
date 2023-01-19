using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class AutoElectrico : Transporte
    {
        public AutoElectrico(string marca, string modelo,string duracionbateria, string voltaje, int anio) : base(marca, modelo)
        {
            DuracionBateria = duracionbateria;
            Voltaje = voltaje;
            Anio = anio;
        }

        public string DuracionBateria { get; set; }     
        public string Voltaje { get; set; }

        public int Anio { get; set; }

        public override string Acelerar()
        {
            return "Acelerando el vehiculo electrico 10km por hora";
        }

        public override string Frenar()
        {
            return "El vehiculo frena lentamente";
        }

        public override string ToString()
        {
            return $"Marca: {Marca}\n" +
                   $"Modelo: {Modelo}\n" +
                   $"Año: {Año}\n" +
                   $"Duracion de bateria: {DuracionBateria}\n" +
                   $"Voltaje: {Voltaje}";
        }
    }
}
