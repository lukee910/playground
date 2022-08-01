using System.ComponentModel.DataAnnotations;

namespace BlazorTest.ServerSide.Models;

public class Kanji
{
    [Key]
    public Guid Id { get; set; }
    
    [Required]
    public string Char { get; set; }

    [Required]
    [MinLength(1)]
    public List<string> Meanings { get; set; }
    
    // [Required]
    // [MinLength(1)]
    public List<Reading> Readings { get; set; }
}
