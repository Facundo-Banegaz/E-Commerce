using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [StringLength(50, MinimumLength = 4)]
        public string Nombre { get; set; }

        [Range(1, 40)]
        public int Cantidad { get; set; }

        [StringLength(50, MinimumLength = 4)]
        public Proveedor Proveedor { get; set; }
    }
}
