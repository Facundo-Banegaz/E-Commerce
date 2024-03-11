using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Ciudad
    {
        public int CiudadId {  get; set; }

        [Display(Name = "Nombre:")]
        [Required(ErrorMessage = "Por favor ingresar el Nombre de la Categoria:")]
        [StringLength(150, MinimumLength = 4)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Por favor selecciona una imagen.")]
        [Display(Name = "Imagen")]
        public IFormFile ImagenFile { get; set; }

    }
}
