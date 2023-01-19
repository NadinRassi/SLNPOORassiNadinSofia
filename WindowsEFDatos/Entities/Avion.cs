using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFDatos.Entities
{
    [Table("Aviones")]
    public class Avion
    {
        [Key]//establezco la key
        public int IdAvion { get; set; }
        public int Capacidad { get; set; }


        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Denominacion { get; set; }
        public int LineaAereaId { get; set; }



        [ForeignKey("LineaAereaId")]
        public LineaAerea LineaAerea { get; set; }

        public override string ToString()//imprimo
        {
            return $"ID: {IdAvion}\n" +
                   $"Denominacion: {Denominacion}\n" +
                   $"Capacidad: {Capacidad}\n";
;                   
        }

    }
}
