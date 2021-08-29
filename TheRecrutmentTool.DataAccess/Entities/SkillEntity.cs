using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRecrutmentTool.DataAccess.Entities
{
    public class SkillEntity
    {
        public SkillEntity()
        {
            Candidates = new List<CandidateEntity>();
            Jobs = new List<JobEntity>();

        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        public ICollection<CandidateEntity> Candidates { get; set; }

        public ICollection<JobEntity> Jobs { get; set; }
    }
}
