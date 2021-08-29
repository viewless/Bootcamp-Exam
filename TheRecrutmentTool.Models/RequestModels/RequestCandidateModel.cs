using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRecrutmentTool.Models.RequestModels
{
    public class RequestCandidateModel
    {
        [Display(Name = "First name")]
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(15, MinimumLength = 2,
       ErrorMessage = "First Name should be minimum 2 characters and maximum of 15 characters.")]
        [RegularExpression("^[A-Z][a-zA-Z]*$", ErrorMessage = "Invalid first name format.")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(15, MinimumLength = 2,
        ErrorMessage = "Last Name should be minimum 2 characters and maximum of 15 characters.")]
        [RegularExpression("^[A-Z][a-zA-Z]*$", ErrorMessage = "Invalid last name format.")]
        public string LastName { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(250, MinimumLength = 10,
        ErrorMessage = "Bio should be minimum 10 characters and maximum of 250 characters.")]
        public string Bio { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public DateTime BirthDate { get; set; }

        public RequestRecruiterModel Recruiter { get; set; }

        public RequestSkillModel Skill { get; set; }

        public RequestInterviewModel Interview { get; set; }

    }
}
