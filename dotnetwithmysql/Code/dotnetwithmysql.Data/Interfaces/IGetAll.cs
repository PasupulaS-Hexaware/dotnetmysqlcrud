using System.Collections.Generic;

namespace dotnetwithmysql.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
