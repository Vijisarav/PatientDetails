using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PateintDetail.Model;
using PateintDetail.Repository;

namespace PateintDetail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientServices _patientServices;
        public PatientController(IPatientServices patientServices)
        {
            _patientServices = patientServices;
        }
        [HttpGet("Patient")]
        public IActionResult GetAllPatientdetails()
        {
            var getalldetails = _patientServices.GetAllPatientdetails();
            return Ok(getalldetails);
        }
        [HttpGet("PatientId")]
        public IActionResult GetByIdPatientdetails(Guid id)
        {
            var getbyiddetails = _patientServices.GetByIdPatientdetails(id);
           // var getById = _patientServices
            return Ok(getbyiddetails);
        }
        [AllowAnonymous]
        [HttpPost("get token")]
        public string GetJwtToken(TokenGeneration tokenGeneration)
        {
            //var user = new TokenGeneration { Email = tokenGeneration.Email, Password = tokenGeneration.Password };
           // string user = null;
            if(tokenGeneration.Email=="viji@gmail.com" && tokenGeneration.Password == "monkey")
            {
                var token = Authenticate.TokenGenerations();
                return token;
                
            }
            
            return "Invalid EmailId";
           
           
           
        }


    }
}






