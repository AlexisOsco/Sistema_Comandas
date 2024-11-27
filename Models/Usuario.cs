namespace Sistema_Comandas.Models
{
    public class Usuario
    {
        public int ID_Usuario { get; set; }
        public string T_Usuario { get; set; }
        public string T_EstadoRegistro { get; set; }

        // Relación con la tabla Tbl_Clave
        public ICollection<Clave> Claves { get; set; }
    }

}
