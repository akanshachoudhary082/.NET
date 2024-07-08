
using StudentInfoWeb.Models;

namespace StudentInfoWeb.Repositories
{
    public interface IStudentRepositories
    {
        List<Student> getAllStudents();

        Student getById(int id);

        void Insert(Student stu);

        void Search(int id);

        void Update(Student stu);
        void Delete(int id);
        void Sort(Student stu);


    }
}
