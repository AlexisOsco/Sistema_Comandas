namespace Sistema_Comandas.Models
{
    public class Clave
    {
        public int ID_Clave { get; set; }
        public string T_Clave { get; set; }
        public string T_EstadoRegistro { get; set; }

        // Relación con Tbl_Usuarios
        public int ID_Usuario { get; set; }
        public Usuario Usuario { get; set; }
    }

}
