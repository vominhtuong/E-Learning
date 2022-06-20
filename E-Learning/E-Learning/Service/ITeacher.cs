using E_Learning.Models;
using E_Learning.ViewModels;

namespace E_Learning.Service
{
    public interface ITeacher
    {
        List<TeacherMV> GetAll();
        TeacherMV GetByID(int id);
        TeacherMV Post(Teacher teacher);
        void Put(TeacherMV teacher);
        void Delete(int id);
    }
}
