using System.Collections.Generic;

namespace testesFacul.Interfaces
{
    public interface IRepositorioGenerico<T>
    {
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        ICollection<T> GetAll();
    }
}
