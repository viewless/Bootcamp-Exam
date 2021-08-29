using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheRecrutmentTool.DataAccess.Entities;

namespace TheRecrutmentTool.DataAccess.Interfaces
{
    public interface IRecruiterRepository
    {
        Task<RecruiterEntity> GetRecruiterAsync(RecruiterEntity recruiterEntity);
    }
}
