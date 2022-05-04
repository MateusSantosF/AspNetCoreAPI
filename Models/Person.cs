using System.ComponentModel.DataAnnotations.Schema;

namespace Learn.Models{

    [Table("PERSON")]
    public class Person{

        [Column("ID")]
        public long id { get; set; }
        [Column("FULLNAME")]
        public string fullName {get;set;}
        [Column("AGE")]
        public int age {get;set;}
    }
}