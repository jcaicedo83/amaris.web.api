using amaris.web.api.core.dto;
using amaris.web.api.core.interfaces.services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace amaris.web.api.Controllers
{
    [Route("api/[controller]")]
    
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _service;
        public EmployeesController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() {
            Response _response = _service.Get();

            if (_response.Ok)
                return Ok(_response);
            else
                return BadRequest(_response.Message);
        }

        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            Response _response = _service.Get(id);

            if (_response.Ok)
                return Ok(_response);
            else
                return BadRequest(_response.Message);
        }
    }
}
