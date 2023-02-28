using dotnetmysql.Entities.Entities;


namespace dotnetmysql.Data.Interfaces
{
    public interface IEmployeeRepository : IGetById<Employee>, IGetAll<Employee>, ISave<Employee>, IUpdate<Employee>, IDelete<int>
    {
    }
}
