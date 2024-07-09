using StudentInfoWeb.Models;
using StudentInfoWeb.Services;
using System.Collections.Generic;

using StudentInfoWeb.Repositories;

namespace StudentInfoWeb.Services
{
    public class StudentService:IStudentService
    {
        private readonly IStudentRepositories _studentRepositories;
        
        public StudentService(IStudentRepositories studentRepositories)
        {
            _studentRepositories = studentRepositories;
        }

        public void Delete(int id)
        {
            _studentRepositories.Delete(id);

        }

        public List<Student> getAllStudents()
        {
            return _studentRepositories.getAllStudents().ToList();


        }

        public Student getById(int id)
        {
            return _studentRepositories.getById(id);

        }

        public void Insert(Student stu)
        {
            _studentRepositories.Insert(stu);

        }

        public List<Student> SortStudents()
        {
            return _studentRepositories.SortStudents();

        }

        public void Update(Student stu)
        {
             _studentRepositories.Update(stu);

        }
    }
}
