using System.Collections.Generic;
using dotnetwithmysql.Business.Interfaces;
using dotnetwithmysql.Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace dotnetwithmysql.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentconController : ControllerBase
    {
        IStudentconService _StudentconService;
        public StudentconController(IStudentconService StudentconService)
        {
            _StudentconService = StudentconService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Studentcon>> Get()
        {
            return Ok(_StudentconService.GetAll());
        }

        [HttpPost]
        public ActionResult<Studentcon> Save(Studentcon Studentcon)
        {
            return Ok(_StudentconService.Save(Studentcon));

        }

        [HttpPut]
        public ActionResult<Studentcon> Update( Studentcon Studentcon)
        {
            return Ok(_StudentconService.Update(Studentcon));

        }

        [HttpDelete]
        public ActionResult<bool> Delete(int id)
        {
            return Ok(_StudentconService.Delete(id));

        }
        [HttpGet("{id:int}")]
        public ActionResult<Studentcon> GetById(int id)
        {
            return Ok(_StudentconService.GetById(id));
        }

    }
}
