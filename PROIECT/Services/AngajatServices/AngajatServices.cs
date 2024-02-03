using AutoMapper;
using Microsoft.Identity.Client;
using PROIECT.Models;
using WSS.Models.DTOs.AngajatDTOs;
using WSS.Repositories.AngajatRepository;

namespace WSS.Services.AngajatServices
{
    public class AngajatServices: IAngajatServices
    {
        private readonly IAngajatRepository _angajatRepository;
        private readonly IMapper _mapper;

        public AngajatServices(IAngajatRepository angajatRepository, IMapper mapper)
        {
            _angajatRepository = angajatRepository;
            _mapper = mapper;
        }

        public bool Delete(Guid id)
        {
            _angajatRepository.DeleteById(id);
            _angajatRepository.SaveAsync();
            return true;
        }

        public async Task<List<AngajatDTO>> GetAllAngajati()
        {
            return _mapper.Map<List<AngajatDTO>>(await _angajatRepository.GetAllAsync());
        }

        public async Task<List<Angajat>> GetAllAngajatInfo()
        {
            return _mapper.Map<List<Angajat>>(await _angajatRepository.GetAllAsync());
        } 

        public List<AngajatDTO> GetAngajatiByMagazin(Guid magazinId)
        {
            return _mapper.Map<List<AngajatDTO>>(_angajatRepository.AngajatiByMagazin(magazinId));
        }

        public AngajatDTO GetAngajatById(Guid id)
        {
            return _mapper.Map<AngajatDTO>(_angajatRepository.FindById(id));
        }

        public async Task AngajatCreate(AngajatCreateDTO angajat)
        {
            var vangajat = _mapper.Map<Angajat>(angajat);
            await _angajatRepository.CreateAsync(vangajat);
            await _angajatRepository.SaveAsync();
        }

        public void Update(AngajatUpdateDTO angajat)
        {
            var vangajat = _mapper.Map<Angajat>(angajat);
            _angajatRepository.Update(vangajat);
            _angajatRepository.Save();
        }

    }
    
}
