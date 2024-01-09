using PROIECT.Models.Base;

namespace PROIECT.Models
{
    public class Partie: BaseEntity
    {
        public string Nume { get; set; } = null!;
        public int? Inaltime { get; set; }
        public int Lungime { get; set; } = 0!;
        public string? GradDificultate { get; set; }
        public Statiune Statiune { get; set; } = null!;
        public Guid StatiuneID { get; set; }
    }
}
