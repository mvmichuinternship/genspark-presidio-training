using day24WebApp.exceptions;
using day24WebApp.interfaces;
using day24WebApp.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace day24WebApp.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly ILogger<UserController> _logger;

        public EmployeeController(IEmployeeService employeeService, ILogger<UserController> logger)
        {
            _employeeService = employeeService;
            _logger = logger;
        }
        [Authorize(Roles = "Admin")]
        [EnableCors]
        [HttpGet]
        public async Task<IList<Employee>> Get()
        {
            var employees = await _employeeService.GetEmployees();
            return employees.ToList();
        }
        [Authorize(Roles ="Admin")]
        [EnableCors]
        [HttpPut]
        public async Task<ActionResult<Employee>> Put(int id, string phone)
        {
            try
            {
                var employee = await _employeeService.UpdateEmployeePhone(id, phone);
                return Ok(employee);
            }
            catch (Exception nsee)
            {
                return NotFound(nsee.Message);
            }
        }

        [Authorize]
        [Route("GetEmployeeByPhone")]
        [HttpPost]
        public async Task<ActionResult<Employee>> Get([FromBody] string phone)
        {
            try
            {
                var employee = await _employeeService.GetEmployeeByPhone(phone);
                return Ok(employee);
            }
            catch (Exception nefe)
            {
                return NotFound(nefe.Message);
            }
        }

    }
}
