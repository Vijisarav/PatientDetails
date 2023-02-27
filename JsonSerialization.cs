using Newtonsoft.Json;
using PateintDetail.Model;
using System.Text.Json.Serialization;

namespace PateintDetail
{
    public class JsonSerialization : IJsonSerialization
    {
        public List<Patientdetails> JsonSerialize()
        {
            var json = File.ReadAllText(@"D:\OneDrive - Flyers Soft Pvt Ltd\PateintDetail\PateintDetail\Patient.json");
            var detail = JsonConvert.DeserializeObject<List<Patientdetails>>(json);
            return detail;

        }
    }
}




           




    
