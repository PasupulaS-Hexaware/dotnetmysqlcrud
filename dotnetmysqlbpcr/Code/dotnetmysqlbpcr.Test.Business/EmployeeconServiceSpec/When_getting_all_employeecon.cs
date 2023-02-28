using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using dotnetmysqlbpcr.Entities.Entities;

namespace dotnetmysqlbpcr.Test.Business.EmployeeconServiceSpec
{
    public class When_getting_all_employeecon : UsingEmployeeconServiceSpec
    {
        private IEnumerable<Employeecon> _result;

        private IEnumerable<Employeecon> _all_employeecon;
        private Employeecon _employeecon;

        public override void Context()
        {
            base.Context();

            _employeecon = new Employeecon{
                ename = "ename"
            };

            _all_employeecon = new List<Employeecon> { _employeecon};
            _employeeconRepository.GetAll().Returns(_all_employeecon);
        }
        public override void Because()
        {
            _result = subject.GetAll();
        }

        [Test]
        public void Request_is_routed_through_repository()
        {
            _employeeconRepository.Received(1).GetAll();

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.ShouldBeOfType<List<Employeecon>>();

            List<Employeecon> resultList = _result as List<Employeecon>;

            resultList.Count.ShouldBe(1);

            resultList.ShouldBe(_all_employeecon);
        }
    }
}
