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
    public class When_updating_employeecon : UsingEmployeeconControllerSpec
    {
        private ActionResult<Employeecon > _result;
        private Employeecon _employeecon;

        public override void Context()
        {
            base.Context();

            _employeecon = new Employeecon
            {
                ename = "ename"
            };

            _employeeconService.Update( _employeecon).Returns(_employeecon);
            
        }
        public override void Because()
        {
            _result = subject.Update( _employeecon);
        }

        [Test]
        public void Request_is_routed_through_service()
        {
            _employeeconService.Received(1).Update( _employeecon);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.Result.ShouldBeOfType<OkObjectResult>();

            var resultListObject = (_result.Result as OkObjectResult).Value;

            resultListObject.ShouldBeOfType<Employeecon>();

            var resultList = resultListObject as Employeecon;

            resultList.ShouldBe(_employeecon);
        }
    }
}
