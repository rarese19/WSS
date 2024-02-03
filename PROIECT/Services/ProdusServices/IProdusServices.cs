using PROIECT.Models;
using WSS.Models.DTOs.ProdusDTOs;

namespace WSS.Services.ProdusServices
{
    public interface IProdusServices
    {
        bool Delete(Guid produsId);
        Task<List<ProdusDTO>> GetAllProduse();
        Task<List<Produs>> GetAllProduseInfo(); 
        ProdusDTO GetProdusById (Guid produsId);
        Task ProdusCreate(ProdusDTO produs);
        void Update(ProdusUpdateDTO produs);
    }
}
