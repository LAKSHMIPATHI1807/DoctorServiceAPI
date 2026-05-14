namespace DoctorServiceAPI.DTOs
{
    public class ReadDoctorDto
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Speicalization { get; set; }
        public string AvailableTimeSlot { get; set; }
    }
}
