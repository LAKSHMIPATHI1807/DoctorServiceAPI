using System.ComponentModel.DataAnnotations;

namespace DoctorServiceAPI.Entities
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Spcialization is required")]
        public string Speicalization { get; set; }

        public string AvailableTimeSlot { get; set; }

    }
}
