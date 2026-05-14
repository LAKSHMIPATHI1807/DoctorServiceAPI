using AutoMapper;
using DoctorServiceAPI.Entities;
using DoctorServiceAPI.DTOs;

namespace DoctorServiceAPI.Profiles
{
    public class DoctorProfile : Profile
    {
        public DoctorProfile()
        {
            CreateMap<CreateDoctorDto, Doctor>();
            CreateMap<UpdateDoctorDto, Doctor>();
            CreateMap<Doctor, ReadDoctorDto>();
        }
    }
}
