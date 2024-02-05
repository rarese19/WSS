namespace WSS.Models.DTOs.UserProdusDTOs
{
    public class UserProdusUpdateDTO
    {
        public Guid Id { get; set; }
        public Guid userId { get; set; }
        public Guid produsId { get; set; }
        public int Cantitate { get; set; }
    }
}
