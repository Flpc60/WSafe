using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WSafe.Web.Data
{
    public class ImagenActo
    {
        public int ID { get; set; }
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        // TODO: Change the path when publish
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://wsafe.azurewebsites.net{ImageUrl.Substring(1)}";

        public Acontecimiento Acontecimiento { get; set; }

    }
}
