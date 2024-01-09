using PROIECT.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROIECT.Models
{
    public class Angajat: BaseEntity
    {
        public string Nume { get; set; } = null!;
        public string Prenume { get; set; } = null!;
        public string CNP { get; set; } = null!;
        public int Salariu { get; set; }
        public string? NumarTelefon { get; set; }
        [ForeignKey("Magazin")]
        public Guid MagazinID { get; set; }

        public Magazin Magazin { get; set; } = null!;
    }
}
