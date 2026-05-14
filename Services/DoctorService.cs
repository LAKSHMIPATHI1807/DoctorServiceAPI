using DoctorServiceAPI.DTOs;
using DoctorServiceAPI.Entities;
using DoctorServiceAPI.Repositories;
using AutoMapper;

namespace DoctorServiceAPI.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _repository;
        private readonly IMapper _mapper;
        public DoctorService(IDoctorRepository doctorRepository, IMapper mapper)
        {
            _repository = doctorRepository;
            _mapper = mapper;
        }

        public async Task CreateDoctorAsync(CreateDoctorDto doctorDto)
        {
            var doctor = _mapper.Map<Doctor>(doctorDto);
            await _repository.CreateDoctorAsync(doctor);
        }

        public async Task DeleteDoctorAsync(int id)
        {
            await _repository.DeleteDoctorAsync(id);
        }

        public async Task<List<ReadDoctorDto>> GetAllDoctorsAsync()
        {
            var doctors = await _repository.GetAllDoctorsAsync();
            var dtos = _mapper.Map<List<ReadDoctorDto>>(doctors);
            return dtos;
        }

        public async Task<ReadDoctorDto> GetDoctorByIdAsync(int id)
        {
            var doctor = await _repository.GetDoctorByIdAsync(id);
            return _mapper.Map<ReadDoctorDto>(doctor);
        }

        public async Task<ReadDoctorDto> GetDoctorByNameAsync(string name)
        {
            var doctor = await _repository.GetDoctorByNameAsync(name);
            return _mapper.Map<ReadDoctorDto>(doctor);
        }

        public async Task UpdateDoctorAsync(int id, UpdateDoctorDto doctorDto)
        {
            var doctor = await _repository.GetDoctorByIdAsync(id);
            if (doctor == null)
            {
                return;
            }
            _mapper.Map(doctorDto, doctor);
            await _repository.UpdateDoctorAsync(doctor);
        }
    }
}
