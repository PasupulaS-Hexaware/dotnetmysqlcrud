using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using Microsoft.AspNetCore.Mvc;
using dotnetwithmysql.Entities.Entities;

namespace dotnetwithmysql.Test.Api.StudentconControllerSpec
{
    public class When_updating_studentcon : UsingStudentconControllerSpec
    {
        private ActionResult<Studentcon > _result;
        private Studentcon _studentcon;

        public override void Context()
        {
            base.Context();

            _studentcon = new Studentcon
            {
                sname = "sname"
            };

            _studentconService.Update( _studentcon).Returns(_studentcon);
            
        }
        public override void Because()
        {
            _result = subject.Update( _studentcon);
        }

        [Test]
        public void Request_is_routed_through_service()
        {
            _studentconService.Received(1).Update( _studentcon);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.Result.ShouldBeOfType<OkObjectResult>();

            var resultListObject = (_result.Result as OkObjectResult).Value;

            resultListObject.ShouldBeOfType<Studentcon>();

            var resultList = resultListObject as Studentcon;

            resultList.ShouldBe(_studentcon);
        }
    }
}
