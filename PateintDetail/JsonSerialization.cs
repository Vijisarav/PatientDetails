using Newtonsoft.Json;
using PateintDetail.Model;


namespace PateintDetail
{
    public class JsonSerialization : IJsonSerialization

    {
        private readonly IConfiguration configuration;
        public JsonSerialization(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public List<Patientdetails>? JsonSerialize()
        {
            var json = File.ReadAllText(configuration["Json:C"]);
            var getallpatientdetails = JsonConvert.DeserializeObject<List<Patientdetails>>(json);
            return getallpatientdetails;

        }
    }
}










