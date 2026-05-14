using System.ComponentModel.DataAnnotations;

namespace DoctorServiceAPI.DTOs
{
    public class UpdateDoctorDto
    {
        [Required(ErrorMessage = "Available time slot is required!")]
        public string AvailableTimeSlot { get; set; }
    }
}
