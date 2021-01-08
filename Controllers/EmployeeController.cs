using MasGlobal.Business;
using MasGlobal.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasGlobal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeBusiness _employeeBusiness;
        public EmployeeController(IEmployeeBusiness employeeBusiness)
        {
            _employeeBusiness = employeeBusiness ?? throw new ArgumentNullException(nameof(employeeBusiness));
        }
        [HttpGet("{id?}")]
        public async Task<ActionResult<IEnumerable<IEmployeeDto>>> GetEmployeeAsync(int id)
        {
            var employeeResult = await _employeeBusiness.GetEmployee();
            if(id == 0)
            {
                return Ok(employeeResult);
            }
            if(employeeResult == null)
            {
                return NotFound();
            }
            
            return Ok(employeeResult.Where(e => e.Id == id));
        }
    }
}
