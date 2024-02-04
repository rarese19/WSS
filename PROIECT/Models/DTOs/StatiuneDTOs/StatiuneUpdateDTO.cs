namespace WSS.Models.DTOs.StatiuneDTOs
{
    public class StatiuneUpdateDTO
    {
        public Guid Id { get; set; }
        public string Regiune { get; set; } = null!;
        public string Stat { get; set; } = null!;
        public string Nume { get; set; } = null!;
    }
}
