using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheRecrutmentTool.DataAccess.Entities
{
    public class CandidateEntity
    {
        public CandidateEntity()
        {
            Skills = new List<SkillEntity>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(15)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(20)]
        public string Email { get; set; }

        [Required]
        [MaxLength(250)]
        public string Bio { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public ICollection<SkillEntity> Skills { get; set; }

        public int RecruiterId { get; set; }
        public RecruiterEntity Recruiter { get; set; }

        public int InterviewId { get; set; }
        public InterviewEntity Interview { get; set; }

    }
}
