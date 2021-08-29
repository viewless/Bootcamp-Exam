using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRecrutmentTool.Models.ResponseModels
{
    public class CandidateResponse
    {
     
        public int Id { get; set; }

        public string FirstName { get; set; }
  
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Bio { get; set; }

        public DateTime BirthDate { get; set; }

        public ResponseRecruiterModel Recruiter { get; set; }
             
        public ResponseSkillModel Skill { get; set; }
               
        public ResponseInterviewModel Interview { get; set; }

    }
}
