namespace Biblioteca1.Models

{
    public class Aula
    {
        public int ID { get; set; }
        public string Codigo { get; set; } = "";
        public string Edificio { get; set; } = "";
        public int Piso { get; set; }
        public int Capacidad { get; set; }
    }
}
