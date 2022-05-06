using System.ComponentModel.DataAnnotations.Schema;

namespace Learn.Models{


    public class BaseEntity{

       
        [Column("ID")]
        public long id { get; set; }
    }
}