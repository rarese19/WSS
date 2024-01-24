namespace WSS.Models.DTOs.MagazinDTOs
{
    public class MagazinUpdateDTO
    {
        public Guid Id { get; set; }
        public string NumarContact { get; set; } = null!;
        public string AdresaMail { get; set; } = null!;
        public Guid StatiuneId { get; set; }
    }
}
