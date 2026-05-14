using DoctorServiceAPI.Entities;

namespace DoctorServiceAPI.Repositories
{
    public interface IDoctorRepository
    {
        Task CreateDoctorAsync(Doctor doctor);
        Task<List<Doctor>> GetAllDoctorsAsync();
        Task<Doctor> GetDoctorByIdAsync(int id);
        Task UpdateDoctorAsync(Doctor doctor);
        Task DeleteDoctorAsync(int id);
        Task<Doctor> GetDoctorByNameAsync(string name);
    }
}
