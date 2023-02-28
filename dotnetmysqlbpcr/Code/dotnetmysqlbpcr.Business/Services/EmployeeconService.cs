using dotnetmysqlbpcr.Business.Interfaces;
using dotnetmysqlbpcr.Data.Interfaces;
using dotnetmysqlbpcr.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetmysqlbpcr.Business.Services
{
    public class EmployeeconService : IEmployeeconService
    {
        IEmployeeconRepository _EmployeeconRepository;

        public EmployeeconService(IEmployeeconRepository EmployeeconRepository)
        {
           this._EmployeeconRepository = EmployeeconRepository;
        }
        public IEnumerable<Employeecon> GetAll()
        {
            return _EmployeeconRepository.GetAll();
        }

        public Employeecon Save(Employeecon Employeecon)
        {
            _EmployeeconRepository.Save(Employeecon);
            return Employeecon;
        }

        public Employeecon Update(Employeecon Employeecon)
        {
            return _EmployeeconRepository.Update( Employeecon);
        }

        public bool Delete(int id)
        {
            return _EmployeeconRepository.Delete(id);
        }
        public Employeecon GetById(int id)
        {
            return _EmployeeconRepository.GetById(id);
        }
    }
}
