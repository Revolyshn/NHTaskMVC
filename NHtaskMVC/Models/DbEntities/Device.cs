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

    [Column(TypeName = "varchar(20)")]
    public string? BIL { get; set; } 
    
    [Column(TypeName = "varchar(20)")]
    public string? PRO { get; set; }
    
    [Column(TypeName = "varchar(20)")]
    public string? NIT { get; set; }
    
    [Column(TypeName = "varchar(20)")]
    public string? KET { get; set; }
    
    [Column(TypeName = "varchar(20)")]
    public string? GLU { get; set; }
    
    [Column(TypeName = "varchar(20)")]
    public string? PH { get; set; }
    
    [Column(TypeName = "varchar(20)")]
    public string? SG { get; set; }
    
    [Column(TypeName = "varchar(20)")]
    public string? LEU { get; set; }
    
}