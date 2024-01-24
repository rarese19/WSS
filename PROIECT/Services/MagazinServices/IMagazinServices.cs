using PROIECT.Models;
using PROIECT.Repositories.GenericRepository;
using WSS.Models.DTOs.MagazinDTOs;
using WSS.Models.DTOs.PartieDTOs;

namespace WSS.Services.MagazinServices
{
    public interface IMagazinServices
    {
        MagazinDTO GetMagazinById(Guid Id);
        Task MagazinCreate(MagazinDTO magazin);
        bool Delete(Guid magazinId);
        void Update(MagazinUpdateDTO magazin);
        Task<List<MagazinDTO>> GetAllMagazin();
        List<MagazinDTO> MagazineDinRegiuni(string regiune);
    }
}
