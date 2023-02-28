using System.Collections.Generic;

namespace dotnetmysqlbpcr.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
