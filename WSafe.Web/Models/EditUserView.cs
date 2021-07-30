using System.ComponentModel.DataAnnotations;

namespace WSafe.Web.Models
{
    public class EditUserView
    {
        public int ID { get; set; }

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede contener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Document { get; set; }

        [Display(Name = "Nombres")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede contener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede contener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string LastName { get; set; }
        [Display(Name = "Dirección")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede contener más de {1} caracteres.")]
        public string Address { get; set; }

        [Display(Name = "Telefonos")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede contener más de {1} caracteres.")]
        public string PhoneNumber { get; set; }
    }
}
