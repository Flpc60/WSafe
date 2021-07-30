using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WSafe.Web.Data;

namespace WSafe.Web.Models
{
    public class AddUserView : EditUserView
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede contener más de {1} caracteres.")]
        [EmailAddress]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El campo {0} debe contener entre {2} y {1} caracteres.")]
        public string Password { get; set; }

        [Display(Name = "Confirmar Password")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El campo {0} debe contener entre {2} y {1} caracteres.")]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Registrar como")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un rol.")]
        public int RoleId { get; set; }

        public IEnumerable<SelectListItem> Roles { get; set; }
        public string Rolename { get; set; }
    }
}
