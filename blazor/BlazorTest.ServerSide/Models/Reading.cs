using System.ComponentModel.DataAnnotations;
using BlazorTest.ServerSide.Models.Enums;

namespace BlazorTest.ServerSide.Models;

public class Reading
{
    [Key]
    public Guid Id { get; set; }
    
    [Required]
    public Kanji Kanji { get; set; }
    
    [Required]
    public string Kana { get; set; }

    [Required]
    public ReadingType Type { get; set; }
}
