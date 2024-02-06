namespace E_Commerce.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
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
