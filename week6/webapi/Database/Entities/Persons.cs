using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("student")]
public class Persons
{
    [Column("person_id")]
    [Key]
    public long StudentId {get; set;}

    [Column("First")]
    public string First {get; set;}

    [Column("Middle I")]
    public string MiddleI {get; set;}

    [Column("Last")]
    public string Last {get; set;}

    public Students Students { get; set; }
}