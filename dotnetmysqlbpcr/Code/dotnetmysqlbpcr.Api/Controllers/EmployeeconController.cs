using System.Collections.Generic;
using dotnetmysqlbpcr.Business.Interfaces;
using dotnetmysqlbpcr.Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace dotnetmysqlbpcr.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeconController : ControllerBase
    {
        IEmployeeconService _EmployeeconService;
        public EmployeeconController(IEmployeeconService EmployeeconService)
        {
            _EmployeeconService = EmployeeconService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employeecon>> Get()
        {
            return Ok(_EmployeeconService.GetAll());
        }

        [HttpPost]
        public ActionResult<Employeecon> Save(Employeecon Employeecon)
        {
            return Ok(_EmployeeconService.Save(Employeecon));

        }

        [HttpPut]
        public ActionResult<Employeecon> Update( Employeecon Employeecon)
        {
            return Ok(_EmployeeconService.Update(Employeecon));

        }

        [HttpDelete]
        public ActionResult<bool> Delete(int id)
        {
            return Ok(_EmployeeconService.Delete(id));

        }
        [HttpGet("{id:int}")]
        public ActionResult<Employeecon> GetById(int id)
        {
            return Ok(_EmployeeconService.GetById(id));
        }

    }
}
