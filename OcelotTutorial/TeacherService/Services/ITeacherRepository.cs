namespace TeacherService.Services
{
    public interface ITeacherRepository
    {
        List<Model.Teacher> GetAll();
        Model.Teacher Get(int id);
    }
}
