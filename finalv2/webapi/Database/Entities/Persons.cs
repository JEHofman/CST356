using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
    [Table("project")]
    public class Projects
    {

        [Column("Name")]
        public string Name {get; set;}

        [Column("Address")]
        public string Address {get; set;}

        public Services Services { get; set; }
    }
}