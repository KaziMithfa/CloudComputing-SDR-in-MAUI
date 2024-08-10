using System.ComponentModel.DataAnnotations;

namespace MauiApp1.Models
{
    public class ConfigurationModel
    {
        [Required(ErrorMessage = "Connection string is required.")]
        public string ConnectionString { get; set; }

        [Required(ErrorMessage = "File container name is required.")]
        public string FileContainer { get; set; }

        [Required(ErrorMessage = "Image container name is required.")]
        public string ImageContainer { get; set; }
    }
}
