using AutoMapper;
using PROIECT.Models;
using WSS.Models.DTOs.StatiuneDTOs;
using WSS.Models.Responses;
using WSS.Repositories.StatiuneRepository;

namespace WSS.Services.StatiuneServices
{
    public class StatiuneServices : IStatiuneServices
    {
        private readonly IStatiuneRepository _statiuneRepository;
        private readonly IMapper _mapper;

        public StatiuneServices(IStatiuneRepository statiuneRepository, IMapper mapper)
        {
            _statiuneRepository = statiuneRepository;
            _mapper = mapper;
        }
    
        public bool Delete(Guid statiuneId)
        {
            _statiuneRepository.DeleteById(statiuneId);
            _statiuneRepository.Save();
            return true;
        }

        public async Task<List<StatiuneDTO>> GetAllStatiune()
        {
            var statiuni = await _statiuneRepository.GetAllAsync();
            return _mapper.Map<List<StatiuneDTO>>(statiuni);
        }

        public List<StatiunePartiiMagazineDTO> GetAllStatiuneInfo()
        {
            var statiuni = _statiuneRepository.StatiuniPartiiMagazine();
            return _mapper.Map<List<StatiunePartiiMagazineDTO>>(statiuni);
        }

        public List<StatiuneDTO> GetStatiuneByRegiune(string regiune)
        {
            var statiuni =  _statiuneRepository.StatiuneByRegiune(regiune);
            return  _mapper.Map<List<StatiuneDTO>>(statiuni);
        }

        public StatiuneDTO GetStatiuneById(Guid Id)
        {
            var statiune = _statiuneRepository.FindById(Id);
            return _mapper.Map<StatiuneDTO>(statiune);
        }

        public async Task StatiuneCreate(StatiuneDTO statiune)
        {
            var vstatiune = _mapper.Map<Statiune>(statiune);
            await _statiuneRepository.CreateAsync(vstatiune);
            await _statiuneRepository.SaveAsync();
        }

        public void Update(StatiuneUpdateDTO statiune)
        {
            var vstatiune = _mapper.Map<Statiune>(statiune);
            _statiuneRepository.Update(vstatiune);
            _statiuneRepository.Save();
        }
    }
}
