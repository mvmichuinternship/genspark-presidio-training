using day24WebApp.interfaces;
using day24WebApp.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace day24WebApp.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly IRequestService _requestService;

        public RequestController(IRequestService requestService)
        {
            _requestService = requestService;
        }
        [Route("RaiseRequest")]
        [HttpPost]
        public async Task<ActionResult<Request>> RaiseRequest(Request request)
        {
            try
            {
                var requestRaise = await _requestService.RaiseRequest(request);
                return Ok(requestRaise);
            }
            catch (Exception nefe)
            {
                return NotFound(nefe.Message);
            }
        }

        [Route("GetRequestUser")]
        [Authorize (Roles="User")]
        [HttpPost]
        public async Task<ActionResult<Request>> ViewRequestUser(int request)
        {
            try
            {
                var requestRaise = await _requestService.ViewRequestById(request);
                return Ok(requestRaise);
            }
            catch (Exception nefe)
            {
                return NotFound(nefe.Message);
            }
        }

        [Route("GetRequestAdmin")]
        [Authorize (Roles ="Admin")]
        [HttpGet]
        public async Task<IEnumerable<Request>> ViewRequestAdmin()
        {
            
                var requestRaise = await _requestService.ViewRequest();
                return requestRaise.ToList();
            
            
        }

    }
}
