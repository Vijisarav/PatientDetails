using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using PateintDetail.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PateintDetail.Repository
{
    public class PatientServices : IPatientServices
    {
        private readonly IJsonSerialization _json;

        public PatientServices(IJsonSerialization jsonSerialization)
        {
            _json = jsonSerialization;

        }
        public List<Patientdetails> GetAllPatientdetails()
        {
            var response = _json.JsonSerialize();
            return response;
        }
        public Patientdetails GetByIdPatientdetails(Guid id)
        {
            var response = _json.JsonSerialize();
            var res = response.FirstOrDefault(x => x.Patientid == id);
            return res;
        }
       



    }
}


