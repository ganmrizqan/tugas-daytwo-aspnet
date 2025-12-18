using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace latihan2.Models;
public class Student
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Nama wajib diisi.")]
    [StringLength(100, ErrorMessage = "Nama tidak boleh lebih dari 100 karakter.")]
    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Nama tidak boleh mengandung angka atau karakter khusus.")]
    public string? Name { get; set; }
        
    [Required(ErrorMessage = "Email wajib diisi.")]
    [EmailAddress(ErrorMessage = "Format email tidak valid.")]
    public string? Email { get; set; }
        
    [Range(18, 60, ErrorMessage = "Usia harus antara 18 hingga 60.")]
    public int Age { get; set; }

    public ICollection<Course>? Courses { get; set; }
}
