using DoctorServiceAPI.Data;
using DoctorServiceAPI.Entities;
using DoctorServiceAPI.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DoctorServiceAPI.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly DoctorDbContext _dbContext;
        public DoctorRepository(DoctorDbContext doctorDbContext)
        {
            _dbContext = doctorDbContext;
        }

        public async Task CreateDoctorAsync(Doctor doctor)
        {
            _dbContext.Doctors.Add(doctor);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteDoctorAsync(int id)
        {
            var doctor = _dbContext.Doctors.FirstOrDefault(p => p.DoctorId == id);
            if (doctor != null)
            {
                _dbContext.Remove(doctor);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Doctor>> GetAllDoctorsAsync()
        {
            return await _dbContext.Doctors.ToListAsync();
        }

        public async Task<Doctor> GetDoctorByIdAsync(int id)
        {
            var doctor = await _dbContext.Doctors.FindAsync(id);
            return doctor;
        }

        public async Task<Doctor> GetDoctorByNameAsync(string name)
        {
            var doctor = await _dbContext.Doctors.FirstOrDefaultAsync(d => d.Name == name);
            return doctor;
        }

        public async Task UpdateDoctorAsync(Doctor doctor)
        {
            _dbContext.Doctors.Update(doctor);
            await _dbContext.SaveChangesAsync();
        }
    }
}
