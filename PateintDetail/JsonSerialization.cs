using Newtonsoft.Json;

namespace PateintDetail
{
    public class JsonSerialization : IJsonSerialization

    {
        private readonly IConfiguration configuration;
        public JsonSerialization(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public List<JObject> ?Jsondeserialize<JObject>()
        {
            var json = File.ReadAllText(configuration["Json:C"]);
            var getallpatientdetails = JsonConvert.DeserializeObject<List<JObject>>(json);
            return getallpatientdetails;

        }

    }
}











