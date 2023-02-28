using NSubstitute;
using dotnetmysqlbpcr.Test.Framework;
using dotnetmysqlbpcr.Business.Services;
using dotnetmysqlbpcr.Data.Interfaces;

namespace dotnetmysqlbpcr.Test.Business.EmployeeconServiceSpec
{
    public abstract class UsingEmployeeconServiceSpec : SpecFor<EmployeeconService>
    {
        protected IEmployeeconRepository _employeeconRepository;

        public override void Context()
        {
            _employeeconRepository = Substitute.For<IEmployeeconRepository>();
            subject = new EmployeeconService(_employeeconRepository);

        }

    }
}
