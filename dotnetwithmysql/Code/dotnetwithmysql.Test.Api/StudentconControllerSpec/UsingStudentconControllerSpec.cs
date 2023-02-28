using NSubstitute;
using dotnetwithmysql.Test.Framework;
using dotnetwithmysql.Api.Controllers;
using dotnetwithmysql.Business.Interfaces;


namespace dotnetwithmysql.Test.Api.StudentconControllerSpec
{
    public abstract class UsingStudentconControllerSpec : SpecFor<StudentconController>
    {
        protected IStudentconService _studentconService;

        public override void Context()
        {
            _studentconService = Substitute.For<IStudentconService>();
            subject = new StudentconController(_studentconService);

        }

    }
}
