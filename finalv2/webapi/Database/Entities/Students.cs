using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Database.Entities;

[Table("service")]
public class Services
{
    [Column("Item")]
    [Key]
    public string Item {get; set;}

    [Column("Type")]
    public string Type {get; set;}

    public Employees Employees { get; set; }
}