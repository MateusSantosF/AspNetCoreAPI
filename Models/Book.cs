using System.ComponentModel.DataAnnotations.Schema;

namespace Learn.Models{

    [Table("BOOK")]
    public class Book : BaseEntity{

        [Column("FULLNAME")]
        public string fullName {get;set;}

        [Column("AUTHOR")]
        public string author {get;set;}
    }
}