using System.Collections.Generic;
using dotnetmysql.Business.Interfaces;
using dotnetmysql.Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace dotnetmysql.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeService _EmployeeService;
        public EmployeeController(IEmployeeService EmployeeService)
        {
            _EmployeeService = EmployeeService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return Ok(_EmployeeService.GetAll());
        }

        [HttpPost]
        public ActionResult<Employee> Save(Employee Employee)
        {
            return Ok(_EmployeeService.Save(Employee));

        }

        [HttpPut]
        public ActionResult<Employee> Update( Employee Employee)
        {
            return Ok(_EmployeeService.Update(Employee));

        }

        [HttpDelete]
        public ActionResult<bool> Delete(int id)
        {
            return Ok(_EmployeeService.Delete(id));

        }
        [HttpGet("{id:int}")]
        public ActionResult<Employee> GetById(int id)
        {
            return Ok(_EmployeeService.GetById(id));
        }

    }
}
