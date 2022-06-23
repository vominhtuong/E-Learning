using E_Learning.Models;
using E_Learning.Service;
using E_Learning.Data;
using E_Learning.ViewModels;

namespace E_Learning.Service
{
    public class TeacherImpl : ITeacher
    {
        private readonly AppDbContext _context;
        public TeacherImpl(AppDbContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var _teacher = _context.Teachers.FirstOrDefault(t => t.Id == id);
            if(_teacher != null)
            {
                _context.Remove(_teacher);
                _context.SaveChanges();
            }
        }

        

       

        public List<TeacherVM> GetAll()
        {
            var teachers = _context.Teachers.Select(x => new TeacherVM
            {
                Id = x.Id,
                Name = x.Name
            });
            return teachers.ToList();
        }

        public TeacherVM GetByID(int id)
        {
            var teachers = _context.Teachers.SingleOrDefault(x => x.Id == id);
            if(teachers != null)
            {
                return new TeacherVM
                {
                    Id=teachers.Id,
                    Name = teachers.Name
                };
            }
            return null;
        }

        public TeacherVM Post(TeacherVM teacher)
        {
            var _teacher = new Teacher
            {
                Name = teacher.Name
            };
            _context.Add(_teacher);
            _context.SaveChanges();
            return new TeacherVM
            {
                Id = _teacher.Id,
                Name = _teacher.Name
            };
        }

        public void Put(TeacherVM teacher)
        {
            var _teacher = _context.Teachers.SingleOrDefault(x=>x.Id == teacher.Id);
            _teacher.Name = teacher.Name;
            _context.SaveChanges();
        }
    }
}
