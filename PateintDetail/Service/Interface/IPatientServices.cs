using PateintDetail.Model;

namespace PateintDetail.Repository.IPatientservices
{
    public interface IPatientServices
    {
        List<Patientdetails>? GetAllPatientdetails();
        Patientdetails? GetByIdPatientdetails(Guid id);
        string TokenGenerations(TokenGeneration tokenGeneration);
    }
}
