using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Proveedor
    {
        public int ProveedorId { get; set; }

        [Display(Name = "Nombre:")]
        [Required(ErrorMessage = "Por favor ingresar el Nombre del Proveedor:")]
        [StringLength(150, MinimumLength = 4)]
        public string Nombre { get; set; }

        [Display(Name = "Apellido:")]
        [Required(ErrorMessage = "Por favor ingresar el Apellido del Proveedor:")]
        [StringLength(150, MinimumLength = 4)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Por favor selecciona una imagen.")]
        [Display(Name = "Imagen")]
        public IFormFile ImagenFile { get; set; }

        [Display(Name = "Telefono:")]
        [Required(ErrorMessage = "Por favor ingresar el Telefono del Proveedor:")]
        public string Telefono { get; set; }
        [Display(Name = "Direccion:")]
        [Required(ErrorMessage = "Por favor ingresar la Direccion del Proveedor:")]
        [StringLength(250, MinimumLength = 4)]
        public string Direccion { get; set; }

        [Display(Name = "Sexo:")]
        [Required(ErrorMessage = "Por favor Selecciona un Sexo:")]
        public Sexo Sexo { get; set; }

        [Display(Name = "Ciudad:")]
        [Required(ErrorMessage = "Por favor ingresar la Ciudad del Proveedor:")]
        public Ciudad Ciudad { get; set; }

        [Display(Name = "Activo:")]
        [Required(ErrorMessage = "Por favor ingresar si el Proveedor se encuentra Activo:")]
        public bool Activo { get; set; }
    }
}
