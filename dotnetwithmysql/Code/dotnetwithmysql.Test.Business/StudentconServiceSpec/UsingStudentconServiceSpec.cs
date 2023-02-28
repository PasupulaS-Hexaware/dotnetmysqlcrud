using NSubstitute;
using dotnetwithmysql.Test.Framework;
using dotnetwithmysql.Business.Services;
using dotnetwithmysql.Data.Interfaces;

namespace dotnetwithmysql.Test.Business.StudentconServiceSpec
{
    public abstract class UsingStudentconServiceSpec : SpecFor<StudentconService>
    {
        protected IStudentconRepository _studentconRepository;

        public override void Context()
        {
            _studentconRepository = Substitute.For<IStudentconRepository>();
            subject = new StudentconService(_studentconRepository);

        }

    }
}
