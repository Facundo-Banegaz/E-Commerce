using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [Display(Name = "Nombre:")]
        [Required(ErrorMessage = "Por favor ingresar el Nombre del producto:")]
        [StringLength(150, MinimumLength = 4)]
        public string Nombre { get; set; }

        [Display(Name = "Apellido:")]
        [Required(ErrorMessage = "Por favor ingresar el Apellido del producto:")]
        [StringLength(150, MinimumLength = 4)]
        public string Apellido { get; set; }

        [Display(Name = "Telefono:")]
        [Required(ErrorMessage = "Por favor ingresar el Telefono del producto:")]
        public string Telefono { get; set; }
        [Display(Name = "Direccion:")]
        [Required(ErrorMessage = "Por favor ingresar la Direccion del producto:")]
        [StringLength(250, MinimumLength = 4)]
        public string Direccion { get; set; }
        public Sexo Sexo { get; set; }
        [Display(Name = "Ciudad:")]
        [Required(ErrorMessage = "Por favor ingresar la Ciudad del producto:")]
        public Ciudad Ciudad { get; set; }
        [Display(Name = "Activo:")]
        [Required(ErrorMessage = "Por favor ingresar si el producto se encuentra Activo:")]
        public bool Activo { get; set; }
        public List<Orden> Ordenes { get; set; }

    }
}
