using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [Display(Name = "Nombre:")]
        [Required(ErrorMessage = "Por favor ingresar el Nombre del Cliente:")]
        [StringLength(150, MinimumLength = 4)]
        public string Nombre { get; set; }

        [Display(Name = "Apellido:")]
        [Required(ErrorMessage = "Por favor ingresar el Apellido del Cliente:")]
        [StringLength(150, MinimumLength = 4)]
        public string Apellido { get; set; }

        [Display(Name = "Telefono:")]
        [Required(ErrorMessage = "Por favor ingresar el Telefono del Cliente:")]
        public string Telefono { get; set; }
        [Display(Name = "Direccion:")]
        [Required(ErrorMessage = "Por favor ingresar la Direccion del Cliente:")]
        [StringLength(250, MinimumLength = 4)]
        public string Direccion { get; set; }
        public Sexo Sexo { get; set; }
        [Display(Name = "Ciudad:")]
        [Required(ErrorMessage = "Por favor ingresar la Ciudad del Cliente:")]
        public Ciudad Ciudad { get; set; }
        [Display(Name = "Activo:")]
        [Required(ErrorMessage = "Por favor ingresar si el Cliente se encuentra Activo:")]
        public bool Activo { get; set; }

        [Required(ErrorMessage = "Por favor selecciona una imagen.")]
        [Display(Name = "Imagen")]
        public IFormFile ImagenFile { get; set; }
        public List<Orden> Ordenes { get; set; }

    }
}
