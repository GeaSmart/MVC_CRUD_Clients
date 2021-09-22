using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD_Clients.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(75)")]
        [Required]
        public string Nombres { get; set; }

        [Column(TypeName = "varchar(75)")]
        [Required]
        public string Apellidos { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Departamento { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Pais { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime FechaIngreso { get; set; }        
    }
}
