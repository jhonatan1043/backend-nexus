using System;
using System.ComponentModel.DataAnnotations;

namespace testnexus.Entitys
{
    public class Autor
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Name { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime birthdate { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string City { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Email { get; set; }

    }
}
