using NSubstitute;
using dotnetmysql.Test.Framework;
using dotnetmysql.Business.Services;
using dotnetmysql.Data.Interfaces;

namespace dotnetmysql.Test.Business.EmployeeServiceSpec
{
    public abstract class UsingEmployeeServiceSpec : SpecFor<EmployeeService>
    {
        protected IEmployeeRepository _employeeRepository;

        public override void Context()
        {
            _employeeRepository = Substitute.For<IEmployeeRepository>();
            subject = new EmployeeService(_employeeRepository);

        }

    }
}
