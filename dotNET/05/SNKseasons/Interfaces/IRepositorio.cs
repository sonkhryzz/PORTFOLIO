using System.Collections.Generic;

namespace SNKseasons.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> List();
        T ReturnId (int id);
        void Insert(T entidade);
        void Erase(int id);
        void Change(int id, T entidade);
        int NextId();
    }
}