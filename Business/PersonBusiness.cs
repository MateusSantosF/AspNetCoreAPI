using Learn.Models;
using Learn.Repository;

namespace Learn.Business{
    
    public class PersonBusiness:IPersonBusiness{


        private readonly IGenericRepository<Person> _repository;
        public PersonBusiness(IGenericRepository<Person> personRepository){

            _repository = personRepository;
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public List<Person> ListAll()
        {
            return _repository.ListAll();
        }

        public Person ListById(long id)
        {
            return _repository.ListById(id);
        }

        public Person Update(Person person)
        {
           return _repository.Update(person);
        }
    }
}