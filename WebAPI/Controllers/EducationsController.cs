using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationsController : ControllerBase
    {
        IEducationService _educationService;

        //IoC 
        public EducationsController(IEducationService educationService)
        {
            _educationService = educationService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _educationService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet]
        public List<Education> Get()
        {
            return new List<Education>
            {
                new Education{Name="njndgndjn"},
            };
        }
    }
}
