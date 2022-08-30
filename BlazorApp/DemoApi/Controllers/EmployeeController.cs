using BusinessLogic;
using DemoModels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;
        public EmployeeController(IEmployeeService _employeeService)
        {
            this.employeeService = _employeeService;
        }

        [HttpGet]
        [Route("GetEmployees")]
        public IActionResult GetEmployees()
        {
            var data = employeeService.GetEmployees();
            return Ok(data);
        }

        [HttpGet]
        [Route("DeleteEmployee")]
        public IActionResult DeleteEmployees(int employeeId)
        {
            var data = employeeService.DeleteEmployee(employeeId);
            return Ok(data);
        }

        [HttpPost]
        [Route("AddNewEmployee")]
        public IActionResult AddNewEmployee(EmployeeInfo info)
        {
            var data = employeeService.AddNewEmployee(info);
            return Ok(data);
        }

        [HttpPost]
        [Route("UpdateEmployee")]
        public IActionResult UpdateEmployee(EmployeeInfo info)
        {
            var data = employeeService.UpdateEmployee(info);
            return Ok(data);
        }
    }
}
