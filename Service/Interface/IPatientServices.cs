using PateintDetail.Model;

namespace PateintDetail.Repository
{
   public interface IPatientServices
    {
        //Task<string> Addlogin(TokenGeneration tokenGeneration);
        //List<TokenGeneration> Addlogin(TokenGeneration tokenGeneration);

        // Task<Patientdetails> GetAllPatientdetails();
        // Patientdetails GetAllPatientdetails();
        List<Patientdetails> GetAllPatientdetails();
       // List<Patientdetails> GetByIdPatientdetails(int id);
        Patientdetails GetByIdPatientdetails(Guid id);
    }
}
