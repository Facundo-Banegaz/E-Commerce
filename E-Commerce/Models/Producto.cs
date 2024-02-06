using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Producto
    {
        public int ProductoId {  get; set; }

        [Display(Name = "Nombre:")]
        [Required(ErrorMessage = "Por favor ingresar el nombre del producto:")]
        public string Nombre { get; set; }
        public string Descripcion {  get; set; }
        [Range(1, 15)]
        [Required(ErrorMessage = "Por favor ingrese el precio del producto:")]
        [DataType(DataType.Currency)]
        [Display(Name = "Precio:")]
        public double Precio {  get; set; }
        public string UrlImagen {  get; set; }

        [Required(ErrorMessage = "Por favor seleccionar una categoría")]
        public virtual Categoria Categoria { get; set; }
    }
}
