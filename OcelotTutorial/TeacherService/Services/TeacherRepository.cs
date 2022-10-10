using TeacherService.Model;

namespace TeacherService.Services
{
    public class TeacherRepository : List<Model.Teacher>, ITeacherRepository
    {
        private static readonly List<Teacher> _teachers = SeedTeachers();

        private static List<Teacher> SeedTeachers()
        {
            var result = new List<Model.Teacher>()
            {
                new Teacher
                {
                    Id = 1,
                    Name = "Peter",
                    School = "Mount Fort"
                },
                new Teacher
                {
                    Id = 2,
                    Name = "Micheal",
                    School = "Secret Heart"
                },
                new Teacher {
                    Id = 3,
                    Name = "Steve",
                    School = "Bishop Memorial"
                }
            };

            return result;
        }

        public Teacher Get(int id)
        {
            return _teachers[id];
        }

        public List<Teacher> GetAll()
        {
            return _teachers.ToList();
        }
    }
}
