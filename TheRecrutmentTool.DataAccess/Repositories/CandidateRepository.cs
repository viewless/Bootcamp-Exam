using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TheRecrutmentTool.DataAccess.Entities;
using TheRecrutmentTool.DataAccess.Interfaces;
using TheRecrutmentTool.Models.ServiceModels;

namespace TheRecrutmentTool.DataAccess.Repositories
{
    public class CandidateRepository : ICandidateRepository
    {
        private readonly IMapper _mapper;
        private readonly TheRecrutmentToolContext _theRecruitmentToolContext;
        private readonly IRecruiterRepository _recruiterRepository;


        public CandidateRepository(IMapper mapper,
            TheRecrutmentToolContext theRecruitmentToolContext,
            IRecruiterRepository recruiterRepository)
        {
            _mapper = mapper;
            _theRecruitmentToolContext = theRecruitmentToolContext;
            _recruiterRepository = recruiterRepository;
        }

        public async Task<CandidateModel> CreateCandidateAsync(CandidateModel model)
        {

            var entity = _mapper.Map<CandidateEntity>(model);
            var recruiter = await _recruiterRepository.GetRecruiterAsync(entity.Recruiter);

            if (!(recruiter is null))
            {
                entity.Recruiter = recruiter;
            }

            await _theRecruitmentToolContext.AddAsync(entity);
            await _theRecruitmentToolContext.SaveChangesAsync();

            return _mapper.Map<CandidateModel>(entity);
        }

        public async Task<CandidateModel> GetACandidateAsync(int id)
        {
            var candidateEntity = await _theRecruitmentToolContext.Candidates
               .AsNoTracking()
               .Include(recruiter => recruiter.Recruiter)
               .Include(skill => skill.Skills)
               .FirstOrDefaultAsync(candidate => candidate.Id == id);

            return _mapper.Map<CandidateModel>(candidateEntity);
        }
    }
}
