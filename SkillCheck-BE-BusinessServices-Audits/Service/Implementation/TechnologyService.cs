using AutoMapper;
using SkillCheck_BE_BusinessServices_Audits.Service.Interface;
using SkillCheck_BE_DataRepository_Audits.DataRepository.Interface;
using SkillCheck_BE_DTOs_Audits.MasterDto;

namespace SkillCheck_BE_BusinessServices_Audits.Service.Implementation
{
    public class TechnologyService : ITechnologyService
    {
        private readonly ITechnologyRepository _technologyRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TechnologyService(ITechnologyRepository technologyRepository, IUnitOfWork unitOfWork ,IMapper mapper)
        {
            _technologyRepository = technologyRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        /// 
        public async Task<IEnumerable<TechnologyDto>> GetAllTechnologiesByUserService(Guid userId)
        {
            var technologies = await  _technologyRepository.GetAllTechnologiesByUserAsync(userId);
            var technologiesdto = _mapper.Map<IEnumerable<TechnologyDto>>(technologies);
            return technologiesdto;
        }

        public async Task<IEnumerable<TechnologyDto>> GetAllTechnologiesSevice()
        {
            var technologies = await _technologyRepository.GetAllTechnologiesAsync();
            var technologiesdto = _mapper.Map<IEnumerable<TechnologyDto>>(technologies);    
            return technologiesdto;
        }
    }
}
