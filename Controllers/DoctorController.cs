using Microsoft.AspNetCore.Mvc;
using DoctorServiceAPI.DTOs;
using DoctorServiceAPI.Services;
using Microsoft.AspNetCore.Authorization;

namespace DoctorServiceAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class DoctorController : Controller
    {
        private readonly IDoctorService _doctorService;
        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }
        [HttpGet("GetAllDoctors")]
        [Authorize(Roles = "Admin,Doctor,Patient")]
        public async Task<IActionResult> GetAll() 
        {
            try
            {
                var doctors = await _doctorService.GetAllDoctorsAsync();
                return Ok(doctors);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("AddDoctor")]
        [Authorize(Roles = "Admin,Doctor")]
        public async Task<IActionResult> Add(CreateDoctorDto createDoctorDto)
        {
            try
            {
                await _doctorService.CreateDoctorAsync(createDoctorDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException.Message);
            }
        }
        [HttpDelete("DeleteDoctorById/{id}")]
        [Authorize(Roles = "Admin,Doctor")]
        public async Task<IActionResult> DeleteDoctor([FromRoute] int id)
        {
            try
            {
                await _doctorService.DeleteDoctorAsync(id);
                return Ok();
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.InnerException.Message);
            }
        }
        [HttpGet("GetDoctorById/{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var doctor = await _doctorService.GetDoctorByIdAsync(id);
                return Ok(doctor);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException.Message);
            }
        }
        [HttpPut("UpdateDoctorById/{id}")]
        [Authorize(Roles = "Admin,Doctor")]
        public async Task<IActionResult> Update(int id, UpdateDoctorDto updateDoctorDto)
        {
            try
            {
                await _doctorService.UpdateDoctorAsync(id, updateDoctorDto);
                return Ok(updateDoctorDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException.Message);
            }
        }

        [HttpGet("GetDoctorByName/{name}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByName(string name)
        {
            try
            {
                var doctor = await _doctorService.GetDoctorByNameAsync(name);
                return Ok(doctor);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException.Message);
            }
        }
    }
}
