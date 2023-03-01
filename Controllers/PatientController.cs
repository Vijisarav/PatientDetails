using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PateintDetail.Repository;

namespace PateintDetail.Controllers
{
    [Route("api")]
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
            return Ok(getbyiddetails);
        }
        [AllowAnonymous]
        [HttpPost("get token")]
        public IActionResult TokenGenerations(TokenGeneration tokenGeneration)
        {
            if (tokenGeneration.Email == "viji@gmail.com" && tokenGeneration.Password == "monkey")
            {
                var gettoken = _patientServices.TokenGenerations(tokenGeneration);
                return Ok(gettoken);
            }
            return Unauthorized("Invalid user");
            //return StatusCode(401, "Unauthorized");
        }
    }
}






