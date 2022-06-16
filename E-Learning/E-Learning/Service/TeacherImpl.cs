using E_Learning.Models;
using E_Learning.Service;
using E_Learning.Data;

namespace E_Learning.Service
{
    public class TeacherImpl : ITeacher
    {
        private readonly AppDbContext _context;
        public TeacherImpl(AppDbContext context)
        {
            _context = context;
        }

        public List<Teacher> GetAll()
        {
            return _context.Teachers.ToList();
        }

        public Teacher GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
