
using StudentInfoWeb.Models;

namespace StudentInfoWeb.Repositories
{
    public interface IStudentRepositories
    {
        List<Student> getAllStudents();

        Student getById(int id);

        void Insert(Student stu);

        //List<Student>SearchByStatus(string status);

        void Update(Student stu);
        void Delete(int id);
        List<Student> SortStudents();


    }
}
