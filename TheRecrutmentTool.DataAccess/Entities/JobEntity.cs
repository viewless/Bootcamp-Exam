using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRecrutmentTool.DataAccess.Entities
{
    public class JobEntity
    {
        public JobEntity()
        {
            Skills = new List<SkillEntity>();
            Interviews = new List<InterviewEntity>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        public string Title { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        public decimal Salary { get; set; }

        public ICollection<SkillEntity> Skills { get; set; }

        public ICollection<InterviewEntity> Interviews { get; set; }
    }
}
