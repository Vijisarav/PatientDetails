using Microsoft.EntityFrameworkCore;
using PateintDetail.Model;


namespace PateintDetail.Context
{
    public class PatientdetailsDbContext : DbContext
    {
        public PatientdetailsDbContext(DbContextOptions<PatientdetailsDbContext> Options) : base(Options)
        {

        }
        public DbSet<Patientdetails>Patient { get; set; }
    }
}
