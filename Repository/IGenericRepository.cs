using Learn.Models;

namespace Learn.Repository{


    public interface IGenericRepository<T> where T:  BaseEntity {
        T Create(T item);
       List<T> ListAll();

       T ListById(long id);

       T Update(T item);
    }
}