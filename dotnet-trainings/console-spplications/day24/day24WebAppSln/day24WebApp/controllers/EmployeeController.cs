﻿using day24WebApp.exceptions;
using day24WebApp.interfaces;
using day24WebApp.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace day24WebApp.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        public async Task<IList<Employee>> Get()
        {
            var employees = await _employeeService.GetEmployees();
            return employees.ToList();
        }

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
