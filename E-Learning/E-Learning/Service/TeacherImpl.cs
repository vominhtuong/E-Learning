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

        

       

        public List<TeacherMV> GetAll()
        {
            var teachers = _context.Teachers.Select(x => new TeacherMV
            {
                Id = x.Id,
                Name = x.Name
            });
            return teachers.ToList();
        }

        public TeacherMV GetByID(int id)
        {
            var teachers = _context.Teachers.SingleOrDefault(x => x.Id == id);
            if(teachers != null)
            {
                return new TeacherMV
                {
                    Id=teachers.Id,
                    Name = teachers.Name
                };
            }
            return null;
        }

        public TeacherMV Post(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public void Put(TeacherMV teacher)
        {
            var _teacher = _context.Teachers.SingleOrDefault(x=>x.Id == teacher.Id);
            _teacher.Name = teacher.Name;
            _context.SaveChanges();
        }
    }
}
