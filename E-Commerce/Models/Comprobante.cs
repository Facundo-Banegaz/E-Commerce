using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Comprobante
    {
        public int ComprobanteId { get; set; }

        [Display(Name = "Fecha:")]
        [Required(ErrorMessage = "Por favor ingresar el nombre del producto:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime Fecha { get; set; }

        [Display(Name = "Nombre:")]
        [Required(ErrorMessage = "Por favor ingresar el nombre del producto:")]

        public Producto Producto { get; set; }

        [Display(Name = "Nombre:")]
        [Required(ErrorMessage = "Por favor ingresar la cantidad del producto:")]
        [StringLength(150, MinimumLength = 4)]
        public int TotalCantidad { get; set; }
        [Display(Name = "Nombre:")]
        [Required(ErrorMessage = "Por favor ingresar el total del precio del producto:")]
        public double TotalPrecio { get; set; }


    }
}
