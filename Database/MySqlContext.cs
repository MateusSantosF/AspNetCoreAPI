
using Learn.Models;
using Microsoft.EntityFrameworkCore;

namespace Learn.Context{
    public class MySqlContext: DbContext{

        public MySqlContext(DbContextOptions options): base(options){}

        public DbSet<Person> Persons{get;set;}
        public DbSet<Book> Books{get;set;}

    }
}