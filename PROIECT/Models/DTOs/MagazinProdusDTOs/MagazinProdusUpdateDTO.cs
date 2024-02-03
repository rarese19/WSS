namespace WSS.Models.DTOs.MagazinProdusDTOs
{
    public class MagazinProdusUpdateDTO
    {
        public Guid Id { get; set; }
        public Guid MagazinId { get; set; }
        public Guid ProdusId { get; set; }
        public int Cantitate { get; set; }
    }
}
