using System.ComponentModel.DataAnnotations;

namespace Avalonia.ValidationTest.Models;

public sealed class Project
{
    public int Id { get; set; }
        
    [Required]
    [StringLength(20)]
    public string? Name { get; set; }
        
    [Required]
    [StringLength(20)]
    public string? Number { get; set; }
        
    [Required]
    [StringLength(50)]
    public string? Remark { get; set; }
}