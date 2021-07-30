using System.ComponentModel.DataAnnotations;

namespace WSafe.Web.Models
{
    public class ChangePasswordView
    {
        [Display(Name = "Actual password")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El campo {0} debe contener entre {2} y {1} caracteres.")]
        public string OldPassword { get; set; }

        [Display(Name = "Nuevo password")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El campo {0} debe contener entre {2} y {1} caracteres.")]
        public string NewPassword { get; set; }

        [Display(Name = "Confirmar Password confirm")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El campo {0} debe contener entre {2} y {1} caracteres.")]
        [Compare("NewPassword")]
        public string Confirm { get; set; }
    }
}
