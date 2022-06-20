using E_Learning.Models;
using E_Learning.ViewModels;

namespace E_Learning.Service
{
    public interface ISubject
    {
        List<SubjectVM> GetAll();
        SubjectVM GetById(int id);
        SubjectVM Post(Subject subject);
        void Put(SubjectVM subject);
        void Delete(int id);
        
    }
}
