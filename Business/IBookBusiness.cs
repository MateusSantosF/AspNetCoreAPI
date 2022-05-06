using Learn.Models;

namespace Learn.Business{
    public interface IBookBusiness{

        Book Create(Book book);
        List<Book> ListAll();
        Book ListById(long id);

        Book Update(Book book);

    }
}