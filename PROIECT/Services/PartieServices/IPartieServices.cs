using PROIECT.Models;
using WSS.Models.DTOs.PartieDTOs;

namespace WSS.Services.PartieServices
{
    public interface IPartieServices
    {
        bool Delete(Guid partieId);
        Task<List<PartieDTO>> GetAllPartie();
        Task<List<Partie>> GetAllPartieInfo();
        List<PartieDTO> GetPartiiByStatiune(Guid statiuneId);
        PartieDTO GetPartieById(Guid id);
        Task PartieCreate(PartieDTO partie);
        void Update(PartieUpdateDTO partie);
    }
}
