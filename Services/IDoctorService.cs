using DoctorServiceAPI.DTOs;

namespace DoctorServiceAPI.Services
{
    public interface IDoctorService
    {
        Task CreateDoctorAsync(CreateDoctorDto doctor);
        Task<List<ReadDoctorDto>> GetAllDoctorsAsync();
        Task<ReadDoctorDto> GetDoctorByIdAsync(int id);
        Task UpdateDoctorAsync(int id, UpdateDoctorDto doctor);
        Task DeleteDoctorAsync(int id);

        Task<ReadDoctorDto> GetDoctorByNameAsync(string name);
    }
}
