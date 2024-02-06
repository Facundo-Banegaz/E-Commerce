namespace E_Commerce.Models
{
    public class Comprobante
    {
        public int ComprobanteId { get; set; }
        public DateTime Fecha { get; set; }

        public Producto Producto { get; set; }

        public int TotalCantidad { get; set; }
        public double TotalPrecio { get; set; }

    }
}
