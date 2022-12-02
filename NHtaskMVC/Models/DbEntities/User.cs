using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NHtaskMVC.Models.DbEntities;

public class User
{
    [Key]
    [Column(TypeName = "varchar(20)")]
    public string Phone { get; set; }
    [Column(TypeName = "varchar(250)")]
    public string Name { get; set; }
    [Column(TypeName = "varchar(250)")]
    public string Password { get; set; }
}