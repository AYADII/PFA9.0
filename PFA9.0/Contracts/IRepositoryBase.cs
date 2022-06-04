using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFA9._0.Contracts
{
    interface IRepositoryBase<T> where T : class
    {
        ICollection<T> FindAll();
        T FindById(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
    }
}
