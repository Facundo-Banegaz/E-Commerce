namespace E_Commerce.Models
{
    public class Orden
    {
        public int  OrdenId{ get; set; }
        public Producto Producto { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Precio { get; set; }

        public List<Item> Detalle { get; set; }
        public decimal Total
        {
            get
            {
                decimal _Total = 0;
                foreach (Item obj in Detalle)
                {
                    _Total = _Total + obj.Importe;
                }
                return _Total;
            }
        }

    }
}
