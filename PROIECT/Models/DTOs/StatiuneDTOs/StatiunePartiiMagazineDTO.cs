using PROIECT.Models;
using WSS.Models.DTOs.MagazinDTOs;
using WSS.Models.DTOs.PartieDTOs;

namespace WSS.Models.DTOs.StatiuneDTOs
{
    public class StatiunePartiiMagazineDTO
    {
        public Guid Id { get; set; }
        public string Regiune { get; set; } = null!;
        public string Stat { get; set; } = null!;
        public string Nume { get; set; } = null!;
        public ICollection<MagazinDTO>? Magazine { get; set; }
        public ICollection<PartieDTO>? Partii { get; set; }
    }
}
