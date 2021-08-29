using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRecrutmentTool.DataAccess.Entities
{
    public class RecruiterEntity
    {
        public RecruiterEntity()
        {
            Candidates = new List<CandidateEntity>();
            Interviews = new List<InterviewEntity>();

        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(20)]
        public string Email { get; set; }
        [Required]
        [MaxLength(15)]
        public string Country { get; set; }

        public ICollection<CandidateEntity> Candidates { get; set; }

        public ICollection<InterviewEntity> Interviews { get; set; }

    }
}
