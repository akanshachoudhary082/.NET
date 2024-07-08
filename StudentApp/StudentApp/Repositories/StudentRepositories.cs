using StudentInfoWeb.Models;

namespace StudentInfoWeb.Repositories
{
    public class StudentRepositories :IStudentRepositories
    {
        public void Delete(int id)
        {
            using (var context = new CollectionContext())
            {
                context.Students.Remove(context.Students.
                    Find(id));
                context.SaveChanges();
            }
        }

        public List<Student> getAllStudents()
        {
            using (var context = new CollectionContext())
            {
                /*var students = from stu
                               in context.Students
                               select stu;
                return students.ToList<Student>();*/
                return context.Students.ToList();
            }
        }

        public Student getById(int id)
        {
            using (var context = new CollectionContext())
            {
                /*var students = context.Students.Find(id);
                return students;*/

                return context.Students.Find(id);
            }
        }
        public void Insert(Student stu)
        {
            using (var context = new CollectionContext())
            {
                context.Students.Add(stu);
                context.SaveChanges();
            }
        }

       
        
        public void Update(Student stu)
        {
            using (var context = new CollectionContext())
            {
                var theStu = context.Students.Find(stu.Student_Id);
                theStu.Student_Name = stu.Student_Name;
                theStu.Student_Email = stu.Student_Email;
                theStu.Mobile_number = stu.Mobile_number;
                theStu.Student_Address = stu.Student_Address;
                theStu.Admission_Date = stu.Admission_Date;
                theStu.Fees = stu.Fees;
                theStu.Status = stu.Status;
                context.SaveChanges();
            }
        }

        public List<Student> SortStudents()
        {
            using (var context = new CollectionContext())
            {
                return context.Students.OrderByDescending(s => s.Status).ToList();
            }
        }
    }
}
