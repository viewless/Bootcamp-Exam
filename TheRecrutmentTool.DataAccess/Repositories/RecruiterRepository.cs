using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheRecrutmentTool.DataAccess.Entities;
using TheRecrutmentTool.DataAccess.Interfaces;

namespace TheRecrutmentTool.DataAccess.Repositories
{
    public class RecruiterRepository : IRecruiterRepository
    {
        private readonly TheRecrutmentToolContext _theRecrutmentToolContext;

        public RecruiterRepository(TheRecrutmentToolContext theRecrutmentToolContext)
        {
            _theRecrutmentToolContext = theRecrutmentToolContext;
        }

        public async Task<RecruiterEntity> GetRecruiterAsync(RecruiterEntity recruiterEntity)
        {
            return await _theRecrutmentToolContext.Recruiters
                .Where(recruiter => recruiter.LastName.ToLower() == recruiterEntity.LastName.ToLower())
                .FirstOrDefaultAsync();
        }
    }
}
