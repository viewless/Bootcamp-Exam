using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRecrutmentTool.DataAccess.Entities
{
    public class InterviewEntity
    {
        public InterviewEntity()
        {
            Candidates = new List<CandidateEntity>();
            Jobs = new List<JobEntity>();
            Recruiters = new List<RecruiterEntity>();
        }

        [Key]
        public int Id { get; set; }

        public ICollection<CandidateEntity> Candidates { get; set; }
        public ICollection<JobEntity> Jobs { get; set; }
        public ICollection<RecruiterEntity> Recruiters { get; set; }
    }
}
