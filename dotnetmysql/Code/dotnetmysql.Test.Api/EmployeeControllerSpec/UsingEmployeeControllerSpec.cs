using NSubstitute;
using dotnetmysql.Test.Framework;
using dotnetmysql.Api.Controllers;
using dotnetmysql.Business.Interfaces;


namespace dotnetmysql.Test.Api.EmployeeControllerSpec
{
    public abstract class UsingEmployeeControllerSpec : SpecFor<EmployeeController>
    {
        protected IEmployeeService _employeeService;

        public override void Context()
        {
            _employeeService = Substitute.For<IEmployeeService>();
            subject = new EmployeeController(_employeeService);

        }

    }
}
