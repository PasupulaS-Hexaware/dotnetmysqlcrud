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
    public class When_deleting_employeecon : UsingEmployeeconControllerSpec
    {
        private ActionResult<bool> _result;

        private int Id = 1;

        public override void Context()
        {
            base.Context();

            _employeeconService.Delete(Id).Returns(true);
        }
        public override void Because()
        {
            _result = subject.Delete(Id);
        }

        [Test]
        public void Request_is_routed_through_service()
        {
            _employeeconService.Received(1).Delete(Id);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.Result.ShouldBeOfType<OkObjectResult>();

            var resultListObject = (_result.Result as OkObjectResult).Value;

            resultListObject.ShouldBeOfType<bool>();

            var resultList = (bool)resultListObject;

            resultList.ShouldBe(true);
        }
    }
}
