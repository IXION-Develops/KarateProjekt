using System;
using System.Collections.Generic;
using System.Text;

namespace Manager_Turnieju.Data
{
    public interface IRepository<T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Add(T model);
        void Edit(T moddel);
        void Delete(int id);

    }
}
