using doctorWebApp.exceptions;
using doctorWebApp.interfaces;
using doctorWebApp.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace doctorWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        
            private readonly IDoctorService _doctorService;

            public DoctorController(IDoctorService doctorService)
            {
                _doctorService = doctorService;
            }
            [HttpGet]
            [ProducesResponseType(typeof(IList<Doctor>), StatusCodes.Status200OK)]
            [ProducesErrorResponseType(typeof(ErrorModel))]
            public async Task<IList<Doctor>> Get()
            {
                var doctors = await _doctorService.GetDoctors();
                return doctors.ToList();
            }

            [Route("GetDoctorBySpecialization")]
            [HttpPost]
            public async Task<ActionResult<Doctor>> Get( string specialization)
            {
                try
                {
                    var doctor = await _doctorService.GetDoctorBySpecialization(specialization);
                    return Ok(doctor);
                }
                catch (NoDoctorException nsee)
                {
                    return NotFound(nsee.Message);
                }
            }

            [HttpPut]
            public async Task<ActionResult<Doctor>> Put( int id, int exp)
            {
                try
                {
                    var doctor = await _doctorService.UpdateDoctorExperience(id,exp);
                    return Ok(doctor);
                }
                catch (NoDoctorException nefe)
                {
                    return NotFound(nefe.Message);
                }
            }
        
        }
    }
