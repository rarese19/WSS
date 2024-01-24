using AutoMapper;
using PROIECT.Models;
using WSS.Models.DTOs.PartieDTOs;
using WSS.Repositories.PartieRepository;
using WSS.Repositories.StatiuneRepository;

namespace WSS.Services.PartieServices
{
    public class PartieServices: IPartieServices
    {
        private readonly IPartieRepository _partieRepository;
        private readonly IMapper _mapper;

        public PartieServices(IPartieRepository partieRepository, IMapper mapper)
        {
            _partieRepository = partieRepository;
            _mapper = mapper;
        }

        public bool Delete(Guid partieId)
        {
            _partieRepository.DeleteById(partieId);
            _partieRepository.Save();
            return true;
        }

        public async Task<List<PartieDTO>> GetAllPartie()
        {
            var partii = await _partieRepository.GetAllAsync();
            return _mapper.Map<List<PartieDTO>>(partii);
        }

        public async Task<List<Partie>> GetAllPartieInfo()
        {
            var partii = await _partieRepository.GetAllAsync();
            return partii;
        }

        public List<PartieDTO> GetPartiiByStatiune(Guid statiuneId)
        {
            var partii = _partieRepository.PartiiDinStatiune(statiuneId);
            return _mapper.Map<List<PartieDTO>>(partii);
        }

        public PartieDTO GetPartieById(Guid id)
        {
            var partie = _partieRepository.FindById(id);
            return _mapper.Map<PartieDTO>(partie);
        }

        public async Task PartieCreate(PartieDTO partie)
        {
            var vpartie = _mapper.Map<Partie>(partie);
            await _partieRepository.CreateAsync(vpartie);
            await _partieRepository.SaveAsync();
        }

        public void Update(PartieUpdateDTO partie)
        {
            var vpartie = _mapper.Map<Partie>(partie);
            _partieRepository.Update(vpartie);
            _partieRepository.Save();
        }
    }
}
