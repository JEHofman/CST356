using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("student")]
public class Students
{
    [Column("student_id")]
    [Key]
    public long StudentId {get; set;}

    [Column("StudentID")]
    public long StudentID {get; set;}

    [Column("Email")]
    public string Email {get; set;}

    public Persons Persons { get; set; }
}