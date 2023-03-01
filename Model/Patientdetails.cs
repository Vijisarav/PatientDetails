using System.ComponentModel.DataAnnotations;
//using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace PateintDetail.Model
{
    public class Model
    {
        public List<Patientdetails>? patientdetails { get; set; }
    }
    public class Patientdetails
    {
        [Key]
        public Guid Patientid { get; set; }
        public string Firstname { get; set; } = "";
        public string? Lastname { get; set;}
        public string? Gender { get; set;}
        public DateTime Dateofbirth { get; set;}
        public string? AddressLine1 { get; set;}
        public string AddressLine2 { get; set;} = string.Empty;
        public string? City { get; set;}
        public string? State { get; set;}
        public string? Postalcode { get; set;}
    }
}

