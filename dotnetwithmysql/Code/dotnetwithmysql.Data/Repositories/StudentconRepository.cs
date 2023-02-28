using dotnetwithmysql.Data.Interfaces;
using dotnetwithmysql.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace dotnetwithmysql.Data.Repositories
{
    public class StudentconRepository : IStudentconRepository
    {
        private readonly DataContext _context;        

        public StudentconRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Studentcon> GetAll()
        {            
            return _context.Studentcon.ToList();
        }

        public bool Save(Studentcon entity)
        {
            if (entity == null)
            return false;
            _context.Studentcon.Add(entity);
            var created= _context.SaveChanges();
            return created>0;
        }

        public Studentcon Update(Studentcon entity)
        {     
             _context.Studentcon.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public bool Delete(int id)
        {          

            int deleted = 0;
            var entity = _context.Studentcon.FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                _context.Remove(entity);
                deleted = _context.SaveChanges();
            }
            return deleted > 0;
        }
        public Studentcon GetById(int id)
        {
            return _context.Studentcon.FirstOrDefault(x => x.Id == id);            
             
        }
    }
}
