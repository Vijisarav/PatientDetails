using Newtonsoft.Json.Linq;
using PateintDetail.Model;

namespace PateintDetail
{
    public interface IJsonSerialization
    {
        List<JObject> Jsondeserialize<JObject>();
    }
}
