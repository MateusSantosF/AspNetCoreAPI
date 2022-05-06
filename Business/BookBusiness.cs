using Learn.Models;
using Learn.Repository;

namespace Learn.Business{


    public class BookBusiness: IBookBusiness{

        private readonly IGenericRepository<Book> _repository;

        public BookBusiness(IGenericRepository<Book> repository){
            _repository = repository;
        }

        public Book Create(Book book){
            return _repository.Create(book);
        }

        public Book ListById(long id){
            return _repository.ListById(id);
        }

        public List<Book> ListAll(){
            return _repository.ListAll();
        }

        public Book Update(Book book)
        {
           return _repository.Update(book);
        }
    }
}