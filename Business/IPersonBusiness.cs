using Learn.Models;

namespace Learn.Business{

    public interface IPersonBusiness{

        Person Create(Person person);

       List<Person> ListAll();

       Person ListById(long id);

       Person Update(Person person);

    }

}