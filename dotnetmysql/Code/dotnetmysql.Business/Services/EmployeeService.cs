using dotnetmysql.Business.Interfaces;
using dotnetmysql.Data.Interfaces;
using dotnetmysql.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetmysql.Business.Services
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeRepository _EmployeeRepository;

        public EmployeeService(IEmployeeRepository EmployeeRepository)
        {
           this._EmployeeRepository = EmployeeRepository;
        }
        public IEnumerable<Employee> GetAll()
        {
            return _EmployeeRepository.GetAll();
        }

        public Employee Save(Employee Employee)
        {
            _EmployeeRepository.Save(Employee);
            return Employee;
        }

        public Employee Update(Employee Employee)
        {
            return _EmployeeRepository.Update( Employee);
        }

        public bool Delete(int id)
        {
            return _EmployeeRepository.Delete(id);
        }
        public Employee GetById(int id)
        {
            return _EmployeeRepository.GetById(id);
        }
    }
}
