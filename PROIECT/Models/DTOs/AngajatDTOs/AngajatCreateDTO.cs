namespace WSS.Models.DTOs.AngajatDTOs
{
    public class AngajatCreateDTO
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        public int Salariu { get; set; }
        public string? NumarTelefon { get; set; }
        public Guid MagazinId { get; set; }
    }
}
