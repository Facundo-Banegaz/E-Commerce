using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        [Display(Name = "Descripción:")]
        public string Descripcion { get; set; }

        [Display(Name = "Cantidad:")]
        public int Cantidad { get; set; }

        [Display(Name = "Precio Unitario:")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal PrecioUnitario { get; set; }
        public  List<Orden> Ordenes {  get; set; }
        public decimal Importe
        {
            get
            {
                return this.PrecioUnitario * this.Cantidad;
            }
        }

    }
}
