using dotnetmysqlbpcr.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetmysqlbpcr.Business.Interfaces
{
    public interface IEmployeeconService
    {      
        IEnumerable<Employeecon> GetAll();
        Employeecon Save(Employeecon classification);
        Employeecon Update(Employeecon classification);
        bool Delete(int id);
        Employeecon  GetById(int id);

    }
}
