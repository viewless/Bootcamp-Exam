using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheRecrutmentTool.DataAccess.Entities;
using TheRecrutmentTool.Models.RequestModels;
using TheRecrutmentTool.Models.ResponseModels;
using TheRecrutmentTool.Models.ServiceModels;

namespace TheRecrutmentTool.API.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
          

            CreateMap<CandidateEntity, CandidateModel>();
           

            CreateMap<CandidateModel, CandidateEntity>();
           

            CreateMap<RequestCandidateModel, CandidateModel>();
            

      
        
           
           

            CreateMap<CandidateModel, CandidateResponse>();
        }
    }
}
