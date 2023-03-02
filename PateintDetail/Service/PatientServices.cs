using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using PateintDetail.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using PateintDetail.Controllers;
using PateintDetail.Repository.IPatientservices;

namespace PateintDetail.Repository.Patientservices
{
    public class PatientServices : IPatientServices
    {
        private readonly IJsonSerialization _json;
        private readonly IConfiguration _configuration;
        private readonly ILogger<PatientController> _logger;

        public PatientServices(IConfiguration configuration, IJsonSerialization jsonSerialization, ILogger<PatientController> logger)
        {
            _configuration = configuration;
            _json = jsonSerialization;
            _logger = (ILogger<PatientController>)logger;
            _logger = logger;
        }

        public List <Patientdetails> GetAllPatientdetails()
        {
            var getallpatientdetails = _json.Jsondeserialize<Patientdetails>();
            return getallpatientdetails;
        }
        public Patientdetails GetByIdPatientdetails(Guid id)
        {
            var response = _json.Jsondeserialize<Patientdetails>();
            var getbyidpatientdetails = response.FirstOrDefault(x => x.Patientid == id);
            return getbyidpatientdetails;
        }
        public string TokenGenerations(TokenGeneration tokenGeneration)
        {
            var tokenkey = Encoding.UTF8.GetBytes(_configuration["Token:SecretKey"]);
            SigningCredentials signingCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenkey),
                    SecurityAlgorithms.HmacSha256);
            JwtHeader header = new JwtHeader(signingCredentials);
            DateTime expiryTime = DateTime.UtcNow.AddMinutes(5);
           // int totalSeconds = (int)(expiryTime - new DateTime()).TotalSeconds;
            JwtPayload payload = new JwtPayload()
            {
                { "Name","patient" },
                { "email","patient" }
            };
            JwtSecurityToken jwtSecurityTokenjwtSecurityToken = new JwtSecurityToken(header, payload);
            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var jsonToken = jwtSecurityTokenHandler.WriteToken(jwtSecurityTokenjwtSecurityToken);
            Console.WriteLine(jsonToken);
            return jsonToken;
        }




    }
}


