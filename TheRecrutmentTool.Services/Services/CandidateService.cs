using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheRecrutmentTool.DataAccess.Interfaces;
using TheRecrutmentTool.Models.ServiceModels;
using TheRecrutmentTool.Services.Interfaces;

namespace TheRecrutmentTool.Services.Services
{
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateRepository _candidateRepository;
        private readonly IMapper _mapper;

        public CandidateService(ICandidateRepository candidateRepository,
            IMapper mapper)
        {
            _candidateRepository = candidateRepository;
            _mapper = mapper;
        }

        public async Task<CandidateModel> GetACandidateByIdAsync(int id)
        {
            return await _candidateRepository.GetACandidateAsync(id);
        }

        public async Task<CandidateModel> CreateCandidateAsync(CandidateModel candidateModel)
        {
           
            return await _candidateRepository.CreateCandidateAsync(candidateModel);
        }
    }
}
