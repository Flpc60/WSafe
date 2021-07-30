using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using WSafe.Web.Data;

namespace WSafe.Web.Models
{
    public class ImagenActoView : ImagenActo
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }

    }
}
