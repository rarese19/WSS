using PROIECT.Models;

namespace WSS.Models.DTOs.MagazinDTOs
{
    public class MagazinAngajatiDTO
    {
        public string NumarContact { get; set; } = null!;
        public string AdresaMail { get; set; } = null!;
        public Guid StatiuneId { get; set; }

        public List<Angajat> Angajati { get; set; }
    }
}
