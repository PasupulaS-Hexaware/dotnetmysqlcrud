using dotnetmysqlbpcr.Entities.Entities;


namespace dotnetmysqlbpcr.Data.Interfaces
{
    public interface IEmployeeconRepository : IGetById<Employeecon>, IGetAll<Employeecon>, ISave<Employeecon>, IUpdate<Employeecon>, IDelete<int>
    {
    }
}
