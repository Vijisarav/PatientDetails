using PateintDetail.Model;

namespace PateintDetail.Repository
{
   public interface IPatientServices
    {
        List<Patientdetails> ?GetAllPatientdetails();
        Patientdetails? GetByIdPatientdetails(Guid id);
        string TokenGenerations(TokenGeneration tokenGeneration);
       
    }
}
