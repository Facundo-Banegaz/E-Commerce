using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [Display(Name = "Nombre:")]
        [Required(ErrorMessage = "Por favor ingresar el Nombre de la Categoria:")]
        [StringLength(150, MinimumLength = 4)]
        public string Nombre { get; set; }

        [Display(Name = "Cantidad:")]
        [Required(ErrorMessage = "Por favor ingresar el Cantidad de la Categoria:")]
        [Range(1, 40)]
        public int Cantidad { get; set; }

        [Display(Name = "Proveedor:")]
        [Required(ErrorMessage = "Por favor ingresar el Proveedor de la Categoria:")]
        [StringLength(150, MinimumLength = 4)]

        public Proveedor Proveedor { get; set; }
    }
}
