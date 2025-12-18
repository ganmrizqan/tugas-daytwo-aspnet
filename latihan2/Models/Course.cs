using System.ComponentModel.DataAnnotations;

namespace latihan2.Models;

public class Course
{
    [Key]
    public int Id { get; set; }
    public string? Title { get; set; }

    public int StudentId { get; set; }

    public Student? Student { get; set; }
}
