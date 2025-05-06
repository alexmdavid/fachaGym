using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fachaGym.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required] 
        [MaxLength(100)] 
        public string Nombre { get; set; }

        [Required]
        [EmailAddress] 
        public string Correo { get; set; }

        [Required]
        [MinLength(8)] 
        public string Contraseña { get; set; }

        public DateTimeOffset FechaRegistro { get; set; }

          //joa por ejemplo 1 dia; 1 mes, serian 30 dias; 3 meses, 90 dias y asi nojoda
    }
}
