using PROIECT.Models;
using WSS.Models.DTOs.AngajatDTOs;

namespace WSS.Services.AngajatServices
{
    public interface IAngajatServices
    {
        Task AngajatCreate(AngajatCreateDTO angajat);
        void Update(AngajatUpdateDTO angajat);
        bool Delete(Guid angajatId);
        Task<List<AngajatDTO>> GetAllAngajati();
        Task<List<Angajat>> GetAllAngajatInfo();
        List<AngajatDTO> GetAngajatiByMagazin(Guid magazinId);
        AngajatDTO GetAngajatById(Guid id);

    }
}
