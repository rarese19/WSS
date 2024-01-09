using PROIECT.Models.Base;

namespace PROIECT.Models
{
    public class Magazin : BaseEntity
    {
        public string NumarContact { get; set; } = null!;
        public string AdresaMail { get; set; } = null!;
        public Statiune Statiune { get; set; } = null!;
        public Guid StatiuneID { get; set; }
        public ICollection<Angajat>? Angajati { get; set; }
        public ICollection<MagazinProdus>? MagazinProduse { get; set; }

    }
}
