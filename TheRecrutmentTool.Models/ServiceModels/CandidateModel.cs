using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRecrutmentTool.Models.ServiceModels
{
    public class CandidateModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }


        public string LastName { get; set; }

        public string Email { get; set; }


        public string Bio { get; set; }


        public DateTime BirthDate { get; set; }

        public RecruiterModel Recruiter { get; set; }

        public SkillModel Skill { get; set; }

        public InterviewModel Interview { get; set; }
    }
}
