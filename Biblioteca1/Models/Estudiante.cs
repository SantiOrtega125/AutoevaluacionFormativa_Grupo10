namespace Biblioteca1.Models
{
    public class Estudiante
    {
        public int ID { get; set; }
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public string Carrera { get; set; } = "";
        public int Semestre { get; set; }
    }
}
