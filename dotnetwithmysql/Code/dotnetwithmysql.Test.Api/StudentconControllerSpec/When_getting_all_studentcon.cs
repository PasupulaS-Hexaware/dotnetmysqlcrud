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
    public class When_getting_all_studentcon : UsingStudentconControllerSpec
    {
        private ActionResult<IEnumerable<Studentcon>> _result;

        private IEnumerable<Studentcon> _all_studentcon;
        private Studentcon _studentcon;

        public override void Context()
        {
            base.Context();

            _studentcon = new Studentcon{
                sname = "sname"
            };

            _all_studentcon = new List<Studentcon> { _studentcon};
            _studentconService.GetAll().Returns(_all_studentcon);
        }
        public override void Because()
        {
            _result = subject.Get();
        }

        [Test]
        public void Request_is_routed_through_service()
        {
            _studentconService.Received(1).GetAll();

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.Result.ShouldBeOfType<OkObjectResult>();

            var resultListObject = (_result.Result as OkObjectResult).Value;

            resultListObject.ShouldBeOfType<List<Studentcon>>();

            List<Studentcon> resultList = resultListObject as List<Studentcon>;

            resultList.Count.ShouldBe(1);

            resultList.ShouldBe(_all_studentcon);
        }
    }
}
