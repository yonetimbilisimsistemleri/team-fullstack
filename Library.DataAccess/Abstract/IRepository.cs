using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Abstract
{
    public interface IRepository<T>
    {
        List<T> Get();
        T Get(int id);
        T Create(T entity);
        T Update(T entity);
        void Delete(int id);
    }
}
