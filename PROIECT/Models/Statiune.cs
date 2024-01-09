using Microsoft.EntityFrameworkCore;
using PROIECT.Models.Base;

namespace PROIECT.Models
{
    public class Statiune: BaseEntity
    {
        public string Regiune { get; set; } = null!;
        public string Stat { get; set; } = null!;
        public string Nume { get; set; } = null!;
        public ICollection<Magazin>? Magazine { get; set; }
        public ICollection<Partie>? Partii { get; set; }


    }
}
