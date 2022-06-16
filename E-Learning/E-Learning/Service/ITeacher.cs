using E_Learning.Models;

namespace E_Learning.Service
{
    public interface ITeacher
    {
        List<Teacher> GetAll();
        Teacher GetByID(int id);
    }
}
