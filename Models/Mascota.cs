namespace web_veterinaria.Models
{
    public class Mascota
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Especie { get; set; } = string.Empty;

        public int Edad { get; set; }

        public string NombreDueño { get; set; } = string.Empty;
    }
}
