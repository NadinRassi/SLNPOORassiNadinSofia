using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public abstract class Transporte
    {
        protected Transporte(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;

        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        public abstract string Acelerar();
        public abstract string Frenar();        
    }
}
