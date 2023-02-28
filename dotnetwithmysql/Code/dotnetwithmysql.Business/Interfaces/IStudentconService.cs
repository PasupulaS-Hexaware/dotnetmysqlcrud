using dotnetwithmysql.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetwithmysql.Business.Interfaces
{
    public interface IStudentconService
    {      
        IEnumerable<Studentcon> GetAll();
        Studentcon Save(Studentcon classification);
        Studentcon Update(Studentcon classification);
        bool Delete(int id);
        Studentcon  GetById(int id);

    }
}
