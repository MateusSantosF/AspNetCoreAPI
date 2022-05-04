using Learn.Models;

namespace Learn.Repository{
    public interface IPersonRepository{


       Person Create(Person person);

       List<Person> ListAll();

       Person ListById(long id);

       Person Update(Person person);

    }
}