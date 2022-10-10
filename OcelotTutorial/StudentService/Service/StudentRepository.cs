using StudentService.Model;
using System.Reflection;

namespace StudentService.Service
{
    public class StudentRepository : List<Model.Student>, IStudentRepository
    {
        private readonly static List<Model.Student> _students = StudentsSeed();

        private static List<Student> StudentsSeed()
        {
            var result = new List<Model.Student>()
            {
                new Student
                {
                    Id = 1,
                    Name = "Prasad",
                    School = "Mount Fort"                    
                },
                new Student
                {
                    Id = 2,
                    Name = "Praveen",
                    School = "Secret Heart"
                },
                new Student {
                    Id = 3, 
                    Name = "Pramod", 
                    School = "Bishop Memorial"
                }
            };

            return result;
        }

        public Student Get(int id)
        {
            return _students[id];
        }

        public List<Student> GetAll()
        {
            return _students;
        }
    }
}
