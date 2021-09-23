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
        [Display(Name ="Nombres")]
        [Required(ErrorMessage = "El campo nombres es obligatorio")]
        public string Nombres { get; set; }

        [Column(TypeName = "varchar(75)")]        
        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "El campo apellidos es obligatorio")]
        public string Apellidos { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Departamento")]
        public string Departamento { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Pais")]
        public string Pais { get; set; }

        
        [Column(TypeName = "datetime")]
        [Display(Name = "Fecha de Ingreso")]
        [Required(ErrorMessage = "El campo fecha de ingreso es obligatorio")]
        public DateTime FechaIngreso { get; set; }        
    }
}
