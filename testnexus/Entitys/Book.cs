using System.ComponentModel.DataAnnotations;

namespace testnexus.Entitys
{
    public class Book
    {
        public int Id{ get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int IdAutor { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int IdEditorial { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Title { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int year { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string gender { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int NumPage { get; set; }
        public Autor Autor { get; set; }
        public Editorial Editorial { get; set; }

    }
}
