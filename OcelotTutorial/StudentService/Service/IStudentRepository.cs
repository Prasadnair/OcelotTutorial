namespace StudentService.Service
{
    public interface IStudentRepository
    {
        List<Model.Student> GetAll();
        Model.Student Get(int id);
    }
}
