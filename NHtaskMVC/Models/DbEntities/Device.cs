using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NHtaskMVC.Models.DbEntities;

public class Device
{
    [Key]
    [Column(TypeName = "int")]
    public int? ID { get; set; }

    [Column(TypeName = "varchar(20)")]
    public string? BLD { get; set; }

    [Column(TypeName = "varchar(20)")]
    public string? UBG { get; set; }
}