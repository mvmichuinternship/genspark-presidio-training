﻿using day24WebApp.exceptions;
using day24WebApp.interfaces;
using day24WebApp.models;
using day24WebApp.models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace day24WebApp.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IUserActivationService _activationService;
        public UserController(IUserService userService, IUserActivationService activationService)
        {
            _userService = userService;
            _activationService = activationService;
        }
        [HttpPost("Login")]
        [ProducesResponseType(typeof(LoginReturnDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<LoginReturnDTO>> Login(UserLoginDTO userLoginDTO)
        {
            try
            {
                var result = await _userService.Login(userLoginDTO);
                return Ok(result);
            }
            catch (UnauthorizedUserException ex)
            {
                return Unauthorized(new ErrorModel(401, ex.Message));
            }
        }

        [HttpPut("Activation")]
        [Authorize (Roles ="Admin")]
        [ProducesResponseType(typeof(LoginReturnDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<LoginReturnDTO>> ActivateUser(ActivateUserDTO activateUser)
        {
            try
            {
                var result = await _activationService.Activate(activateUser);
                return Ok(result);
            }
            catch (UnauthorizedUserException ex)
            {
                return Unauthorized(new ErrorModel(401, ex.Message));
            }
        }

        [HttpPost("Register")]
        [ProducesResponseType(typeof(Employee), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Employee>> Register(EmployeeUserDTO userDTO)
        {
            try
            {
                Employee result = await _userService.Register(userDTO);
                return Ok(result);
            }
            catch (UnableToRegisterException ex)
            {
                return BadRequest(new ErrorModel(501, ex.Message));
            }
        }
    }
}
