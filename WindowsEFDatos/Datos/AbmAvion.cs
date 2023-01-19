using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Data;
using WindowsEFDatos.Entities;

namespace WindowsEFDatos.Datos
{
    public static class AbmAvion
    {
        private static readonly DbLineaAereaContext context = new DbLineaAereaContext();
        
        public static List<Avion> Listar()
        {
            return context.Aviones.ToList();
        }

        public static int Insertar(Avion a)
        {
            context.Aviones.Add(a);//add: agregar a la lista context
            return context.SaveChanges();
        }

        public static int Editar(Avion a)
        {
            Avion nuevoAvion = context.Aviones.Find(a.IdAvion);//find: buscar por id

            nuevoAvion.LineaAerea = a.LineaAerea;
            nuevoAvion.Capacidad = a.Capacidad;
            nuevoAvion.Denominacion = a.Denominacion;            

            if (nuevoAvion != null)//si ha puesto algo en el avion
            {
                return context.SaveChanges();//guarda cambios
            }
            return 0;
        }

        public static Avion TraerUno(int id)
        {
            return context.Aviones.Find(id);//si lo encontró, mostralo
        }

        public static int Eliminar(int id)
        {
            Avion avionDelete = context.Aviones.Find(id);//si lo encontró
            context.Aviones.Remove(avionDelete);//lo borro

            return context.SaveChanges();//y guardo
        }
    }
}
