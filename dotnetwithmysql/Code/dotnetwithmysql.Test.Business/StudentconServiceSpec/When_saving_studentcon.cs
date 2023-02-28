using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using dotnetwithmysql.Entities.Entities;

namespace dotnetwithmysql.Test.Business.StudentconServiceSpec
{
    public class When_saving_studentcon : UsingStudentconServiceSpec
    {
        private Studentcon _result;

        private Studentcon _studentcon;

        public override void Context()
        {
            base.Context();

            _studentcon = new Studentcon
            {
                sname = "sname"
            };

            _studentconRepository.Save(_studentcon).Returns(true);
        }
        public override void Because()
        {
            _result = subject.Save(_studentcon);
        }

        [Test]
        public void Request_is_routed_through_repository()
        {
            _studentconRepository.Received(1).Save(_studentcon);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.ShouldBeOfType<Studentcon>();

            _result.ShouldBe(_studentcon);
        }
    }
}
