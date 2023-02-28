using dotnetmysqlbpcr.Data.Interfaces;
using dotnetmysqlbpcr.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace dotnetmysqlbpcr.Data.Repositories
{
    public class EmployeeconRepository : IEmployeeconRepository
    {
        private readonly DataContext _context;        

        public EmployeeconRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Employeecon> GetAll()
        {            
            return _context.Employeecon.ToList();
        }

        public bool Save(Employeecon entity)
        {
            if (entity == null)
            return false;
            _context.Employeecon.Add(entity);
            var created= _context.SaveChanges();
            return created>0;
        }

        public Employeecon Update(Employeecon entity)
        {     
             _context.Employeecon.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public bool Delete(int id)
        {          

            int deleted = 0;
            var entity = _context.Employeecon.FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                _context.Remove(entity);
                deleted = _context.SaveChanges();
            }
            return deleted > 0;
        }
        public Employeecon GetById(int id)
        {
            return _context.Employeecon.FirstOrDefault(x => x.Id == id);            
             
        }
    }
}
