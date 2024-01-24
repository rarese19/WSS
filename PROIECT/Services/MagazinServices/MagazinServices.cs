using AutoMapper;
using PROIECT.Models;
using PROIECT.Repositories.GenericRepository;
using WSS.Models.DTOs.MagazinDTOs;
using WSS.Repositories.MagazinRepository;
using WSS.Repositories.PartieRepository;

namespace WSS.Services.MagazinServices
{
    public class MagazinServices: IMagazinServices
    {
        private readonly IMagazinRepository _magazinRepository;
        private readonly IMapper _mapper;

        public MagazinServices(IMagazinRepository magazinRepository, IMapper mapper)
        {
            _magazinRepository = magazinRepository;
            _mapper = mapper;
        }

        public bool Delete(Guid magazinId)
        {
            _magazinRepository.DeleteById(magazinId);
            _magazinRepository.Save();
            return true;
        }

        public async Task<List<MagazinDTO>> GetAllMagazin()
        {
            var magazine = await _magazinRepository.GetAllAsync();
            return _mapper.Map<List<MagazinDTO>>(magazine);
        }

        public MagazinDTO GetMagazinById(Guid Id)
        {
            var magazin = _magazinRepository.FindById(Id);
            return _mapper.Map<MagazinDTO>(magazin);
        }

        public async Task MagazinCreate(MagazinDTO magazin)
        {
            var vmagazin = _mapper.Map<Magazin>(magazin);
            await _magazinRepository.CreateAsync(vmagazin);
            await _magazinRepository.SaveAsync();
        }

        public List<MagazinDTO> MagazineDinRegiuni(string regiune)
        {
            return _mapper.Map<List<MagazinDTO>>(_magazinRepository.MagazineDinRegiuni(regiune));
        }

        public void Update(MagazinUpdateDTO magazin)
        {
            var vmagazin = _mapper.Map<Magazin>(magazin);
            _magazinRepository.Update(vmagazin);
            _magazinRepository.Save();
        }

  


    }
}
