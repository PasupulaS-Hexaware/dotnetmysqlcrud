using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using Microsoft.AspNetCore.Mvc;
using dotnetmysqlbpcr.Entities.Entities;

namespace dotnetmysqlbpcr.Test.Api.EmployeeconControllerSpec
{
    public class When_getting_all_employeecon : UsingEmployeeconControllerSpec
    {
        private ActionResult<IEnumerable<Employeecon>> _result;

        private IEnumerable<Employeecon> _all_employeecon;
        private Employeecon _employeecon;

        public override void Context()
        {
            base.Context();

            _employeecon = new Employeecon{
                ename = "ename"
            };

            _all_employeecon = new List<Employeecon> { _employeecon};
            _employeeconService.GetAll().Returns(_all_employeecon);
        }
        public override void Because()
        {
            _result = subject.Get();
        }

        [Test]
        public void Request_is_routed_through_service()
        {
            _employeeconService.Received(1).GetAll();

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.Result.ShouldBeOfType<OkObjectResult>();

            var resultListObject = (_result.Result as OkObjectResult).Value;

            resultListObject.ShouldBeOfType<List<Employeecon>>();

            List<Employeecon> resultList = resultListObject as List<Employeecon>;

            resultList.Count.ShouldBe(1);

            resultList.ShouldBe(_all_employeecon);
        }
    }
}
