using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TheRecrutmentTool.Models.RequestModels;
using TheRecrutmentTool.Models.ResponseModels;
using TheRecrutmentTool.Models.ServiceModels;
using TheRecrutmentTool.Services.Interfaces;

namespace TheRecrutmentTool.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CandidatesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICandidateService _candidateService;
    

        public CandidatesController(IMapper mapper,
        ICandidateService candidateService)
        {
            _candidateService = candidateService;
            _mapper = mapper;
          
        }


        // POST: CandidatesController/Create
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RequestCandidateModel requestCandidateModel)
        {
            var candidateToCreate = await _candidateService.CreateCandidateAsync(_mapper.Map<CandidateModel>(requestCandidateModel));

            if (!(candidateToCreate is null))
            {
                return StatusCode(201, _mapper.Map<CandidateResponse>(candidateToCreate));
            }

            return BadRequest("Something occured. Please try again.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var candidate = await _candidateService.GetACandidateByIdAsync(id);

            if (candidate is null)
            {
                return NotFound($"Candidate with id {id} could not be found in the database.");
            }

            return Ok(_mapper.Map<CandidateResponse>(candidate));
        }

    }
}
