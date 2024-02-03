namespace WSS.Models.DTOs.AngajatDTOs
{
    public class AngajatUpdateDTO
    {
        public Guid Id { get; set; }
        public string Nume { get; set; } = null!;
        public string Prenume { get; set; } = null!;
        public string CNP { get; set; } = null!;
        public int Salariu { get; set; }
        public string? NumarTelefon { get; set; }
        public Guid MagazinID { get; set; }

    }
}
