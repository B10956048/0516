using System.Collections.Generic; //list
using WebApplication1.Models;
namespace WebApplication1.Service
{
    public interface IStudentService
    {
        public List<Student> GetStudents();

        public (int total, List<Student>) GetStudents(int offset , int count);

        public Student GetStudentByNo(string studentNo);

        public bool UpdateStudent(Student  student);
    }
}
