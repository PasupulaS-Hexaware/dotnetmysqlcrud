using dotnetwithmysql.Business.Interfaces;
using dotnetwithmysql.Data.Interfaces;
using dotnetwithmysql.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetwithmysql.Business.Services
{
    public class StudentconService : IStudentconService
    {
        IStudentconRepository _StudentconRepository;

        public StudentconService(IStudentconRepository StudentconRepository)
        {
           this._StudentconRepository = StudentconRepository;
        }
        public IEnumerable<Studentcon> GetAll()
        {
            return _StudentconRepository.GetAll();
        }

        public Studentcon Save(Studentcon Studentcon)
        {
            _StudentconRepository.Save(Studentcon);
            return Studentcon;
        }

        public Studentcon Update(Studentcon Studentcon)
        {
            return _StudentconRepository.Update( Studentcon);
        }

        public bool Delete(int id)
        {
            return _StudentconRepository.Delete(id);
        }
        public Studentcon GetById(int id)
        {
            return _StudentconRepository.GetById(id);
        }
    }
}
