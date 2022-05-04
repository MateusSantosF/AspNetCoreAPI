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
            var result = _context.Persons.SingleOrDefault( p => p.id.Equals(person.id));
            if(result != null){
                _context.Entry(result).CurrentValues.SetValues(person);
                _context.SaveChanges();
                return result;
            }
            return new Person();
          
        }
    }
}