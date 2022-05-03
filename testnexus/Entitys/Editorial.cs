using System.ComponentModel.DataAnnotations;

namespace testnexus.Entitys
{
    public class Editorial
    {    
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Name { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Address { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Phone { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int MaxBookReg { get; set; }
    }
}
