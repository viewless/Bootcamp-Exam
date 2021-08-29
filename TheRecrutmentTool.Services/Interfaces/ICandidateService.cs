using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheRecrutmentTool.Models.ServiceModels;

namespace TheRecrutmentTool.Services.Interfaces
{
    public interface ICandidateService
    {
        Task<CandidateModel> CreateCandidateAsync(CandidateModel candidateModel);
        Task<CandidateModel> GetACandidateByIdAsync(int id);

    }
}
