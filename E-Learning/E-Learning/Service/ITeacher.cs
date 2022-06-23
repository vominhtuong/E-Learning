using E_Learning.Models;
using E_Learning.ViewModels;

namespace E_Learning.Service
{
    public interface ITeacher
    {
        List<TeacherVM> GetAll();
        TeacherVM GetByID(int id);
        TeacherVM Post(TeacherVM teacher);
        void Put(TeacherVM teacher);
        void Delete(int id);
    }
}
