using PROIECT.Models;

namespace WSS.Models.DTOs.MagazinDTOs
{
    public class StatiuneAddDTO
    {
        public Guid Id { get; set; }
        public ICollection<Magazin>? Magazine { get; set; }
        public ICollection<Partie>? Partii { get; set; }
    }
}
