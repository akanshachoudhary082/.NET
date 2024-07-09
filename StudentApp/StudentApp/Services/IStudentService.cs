using StudentInfoWeb.Models;
using System.Collections.Generic;
namespace StudentInfoWeb.Services
{
    public interface IStudentService
    {
        List<Student> getAllStudents();
        Student getById(int id);

        void Insert(Student stu);

   
        void Update(Student stu);

        void Delete(int id);

        List<Student> SortStudents();
    }
}
