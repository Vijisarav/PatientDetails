using PateintDetail.Model;

namespace PateintDetail
{
    public interface IJsonSerialization
    {
        List<Patientdetails>? JsonSerialize();
    }
}
