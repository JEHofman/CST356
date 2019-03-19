using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
    [Table("employee")]
    public class Employees
    {

        [Column("First")]
        public string First {get; set;}


        [Column("Last")]
        public string Last {get; set;}

        public Services Services { get; set; }
    }
}