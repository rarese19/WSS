using PROIECT.Models;
using WSS.Models.DTOs.PartieDTOs;

namespace WSS.Services.PartieServices
{
    public interface IPartieServices
    {
        PartieDTO GetPartieById(Guid Id);
        Task PartieCreate(PartieDTO partie);
        bool Delete(Guid partieId);
        void Update(PartieUpdateDTO partie);
        Task<List<PartieDTO>> GetAllPartie();
        Task<List<Partie>> GetAllPartieInfo();
        List<PartieDTO> GetPartiiByStatiune(Guid statiuneId);

    }
}
