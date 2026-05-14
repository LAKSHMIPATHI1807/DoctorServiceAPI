using System.ComponentModel.DataAnnotations;

namespace DoctorServiceAPI.DTOs
{
    public class CreateDoctorDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Spcialization is required")]
        public string Speicalization { get; set; }

        public string AvailableTimeSlot { get; set; }
    }
}
