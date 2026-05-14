using DoctorServiceAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace DoctorServiceAPI.Data
{
    public class DoctorDbContext : DbContext
    {
        public DoctorDbContext(DbContextOptions<DoctorDbContext> options) : base(options)
        {

        }

        public DbSet<Doctor> Doctors { get; set; }
    }
}
