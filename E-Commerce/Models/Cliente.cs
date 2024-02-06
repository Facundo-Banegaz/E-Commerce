namespace E_Commerce.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public Sexo Sexo { get; set; }
        public Ciudad Ciudad { get; set; }

        public bool Activo { get; set; }
        public List<Orden> Ordenes { get; set; }

    }
}
