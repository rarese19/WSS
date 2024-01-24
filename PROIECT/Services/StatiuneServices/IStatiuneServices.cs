using PROIECT.Models;
using WSS.Models.DTOs.StatiuneDTOs;
using WSS.Models.Responses;

namespace WSS.Services.StatiuneServices
{
    public interface IStatiuneServices
    {
        StatiuneDTO GetStatiuneById(Guid Id);
        Task StatiuneCreate(StatiuneDTO statiune);
        bool Delete(Guid statiuneId);
        void Update(StatiuneUpdateDTO statiune);
        Task<List<StatiuneDTO>> GetAllStatiune();
        List<StatiunePartiiMagazineDTO> GetAllStatiuneInfo();
        List<StatiuneDTO> GetStatiuneByRegiune(string regiune);
    }
}
