namespace WSS.Models.DTOs.ProdusDTOs
{
    public class ProdusUpdateDTO
    {
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public int Pret {  get; set; }
        public string Brand { get; set; }
    }
}
