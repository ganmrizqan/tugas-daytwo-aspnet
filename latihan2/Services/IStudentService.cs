using latihan2.Models;

namespace latihan2.Services;

public interface IStudentService
{
    List<Student> GetAllStudents();
    Student GetStudentById(int id);
    void AddStudent(Student student);
    void UpdateStudent(Student student);
    void DeleteStudent(int id);
}