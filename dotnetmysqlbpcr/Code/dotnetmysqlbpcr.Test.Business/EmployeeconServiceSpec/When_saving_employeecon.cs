using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using dotnetmysqlbpcr.Entities.Entities;

namespace dotnetmysqlbpcr.Test.Business.EmployeeconServiceSpec
{
    public class When_saving_employeecon : UsingEmployeeconServiceSpec
    {
        private Employeecon _result;

        private Employeecon _employeecon;

        public override void Context()
        {
            base.Context();

            _employeecon = new Employeecon
            {
                ename = "ename"
            };

            _employeeconRepository.Save(_employeecon).Returns(true);
        }
        public override void Because()
        {
            _result = subject.Save(_employeecon);
        }

        [Test]
        public void Request_is_routed_through_repository()
        {
            _employeeconRepository.Received(1).Save(_employeecon);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.ShouldBeOfType<Employeecon>();

            _result.ShouldBe(_employeecon);
        }
    }
}
