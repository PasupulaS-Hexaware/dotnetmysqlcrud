using NSubstitute;
using dotnetmysqlbpcr.Test.Framework;
using dotnetmysqlbpcr.Api.Controllers;
using dotnetmysqlbpcr.Business.Interfaces;


namespace dotnetmysqlbpcr.Test.Api.EmployeeconControllerSpec
{
    public abstract class UsingEmployeeconControllerSpec : SpecFor<EmployeeconController>
    {
        protected IEmployeeconService _employeeconService;

        public override void Context()
        {
            _employeeconService = Substitute.For<IEmployeeconService>();
            subject = new EmployeeconController(_employeeconService);

        }

    }
}
