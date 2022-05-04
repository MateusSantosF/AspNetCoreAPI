using Learn.Context;
using Learn.Models;

namespace Learn.Repository{

    public class PersonRepository:IPersonRepository{


        private readonly MySqlContext _context;
        public PersonRepository(MySqlContext context){
            _context = context;
        }

        public Person Create(Person person)
        {
           _context.Add(person);
           _context.SaveChanges();

           return person;
        }

        public List<Person> ListAll()
        {
            return _context.Persons.ToList();
        }

        public Person ListById(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.id.Equals(id));
        }

        public Person Update(Person person)
        {
            _context.Update(person);
            _context.SaveChanges();
            return person;
        }
    }
}