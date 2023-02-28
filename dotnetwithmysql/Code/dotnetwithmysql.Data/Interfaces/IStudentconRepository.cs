using dotnetwithmysql.Entities.Entities;


namespace dotnetwithmysql.Data.Interfaces
{
    public interface IStudentconRepository : IGetById<Studentcon>, IGetAll<Studentcon>, ISave<Studentcon>, IUpdate<Studentcon>, IDelete<int>
    {
    }
}
