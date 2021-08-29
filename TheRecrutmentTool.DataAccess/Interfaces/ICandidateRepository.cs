using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheRecrutmentTool.Models.ServiceModels;

namespace TheRecrutmentTool.DataAccess.Interfaces
{
    public interface ICandidateRepository
    {
        Task<CandidateModel> CreateCandidateAsync(CandidateModel candidateModel);
        Task<CandidateModel> GetACandidateAsync(int id);
        
    }
}
