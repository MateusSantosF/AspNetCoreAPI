using Learn.Context;
using Learn.Models;
using Microsoft.EntityFrameworkCore;

namespace Learn.Repository{

    public class GenericRepository<T> : IGenericRepository<T>  where T:BaseEntity
    {

        private readonly MySqlContext _context;
        private DbSet<T> dataset; 

        public GenericRepository(MySqlContext context){
            _context = context;
             dataset = context.Set<T>();
        }
        public T Create(T item)
        {
            dataset.Add(item);
            _context.SaveChanges();
            return item;
        }

        public List<T> ListAll()
        {
            return dataset.ToList();
        }

        public T ListById(long id)
        {
           return dataset.SingleOrDefault(t => t.id.Equals(id));
        }

        public T Update(T item)
        {
           var result = dataset.SingleOrDefault( p => p.id.Equals(item.id));
            if(result != null){
                _context.Entry(result).CurrentValues.SetValues(item);
                _context.SaveChanges();
                return result;
            }
            return item;
        }
    }
}