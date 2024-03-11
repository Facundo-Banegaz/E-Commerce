using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Producto
    {
        public int ProductoId {  get; set; }

        [Display(Name = "Nombre:")]
        [Required(ErrorMessage = "Por favor ingresar el nombre del Producto:")]
        public string Nombre { get; set; }
        [Display(Name = "Descripción:")]
        [Required(ErrorMessage = "Por favor ingresar la Descripción del Producto:")]
        public string Descripcion {  get; set; }

        [Range(1, 15)]
        [Required(ErrorMessage = "Por favor ingrese el precio del Producto:")]
        [DataType(DataType.Currency)]
        [Display(Name = "Precio:")]
        public double Precio {  get; set; }

        [Required(ErrorMessage = "Por favor selecciona una imagen.")]
        [Display(Name = "Imagen")]
        public IFormFile ImagenFile { get; set; }

        [Required(ErrorMessage = "Por favor seleccionar una Categoría")]
        public virtual Categoria Categoria { get; set; }
    }
}
