using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using dotnetwithmysql.Entities.Entities;

namespace dotnetwithmysql.Test.Business.StudentconServiceSpec
{
    public class When_getting_all_studentcon : UsingStudentconServiceSpec
    {
        private IEnumerable<Studentcon> _result;

        private IEnumerable<Studentcon> _all_studentcon;
        private Studentcon _studentcon;

        public override void Context()
        {
            base.Context();

            _studentcon = new Studentcon{
                sname = "sname"
            };

            _all_studentcon = new List<Studentcon> { _studentcon};
            _studentconRepository.GetAll().Returns(_all_studentcon);
        }
        public override void Because()
        {
            _result = subject.GetAll();
        }

        [Test]
        public void Request_is_routed_through_repository()
        {
            _studentconRepository.Received(1).GetAll();

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.ShouldBeOfType<List<Studentcon>>();

            List<Studentcon> resultList = _result as List<Studentcon>;

            resultList.Count.ShouldBe(1);

            resultList.ShouldBe(_all_studentcon);
        }
    }
}
