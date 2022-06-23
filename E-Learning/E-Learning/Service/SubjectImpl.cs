using E_Learning.Data;
using E_Learning.Models;
using E_Learning.ViewModels;

namespace E_Learning.Service
{
    public class SubjectImpl : ISubject
    {
        private readonly AppDbContext _context;
        public SubjectImpl(AppDbContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var _subject = _context.Subjects.FirstOrDefault(x => x.Id == id);
            if(_subject != null)
            {
                _context.Remove(_subject);
                _context.SaveChanges();
            }
        }

        public List<SubjectVM> GetAll()
        {
            var subjects = _context.Subjects.Select(x => new SubjectVM
            { 
                Id = x.Id,
                Name = x.Name
                
            });
            return subjects.ToList();
        }

        public SubjectVM GetById(int id)
        {
            var subjects = _context.Subjects.SingleOrDefault(x => x.Id == id);
            if (subjects != null)
            {
                return new SubjectVM
                {
                    Id = subjects.Id,
                    Name = subjects.Name
                };
            }
            return null;
        }

        public SubjectVM Post(SubjectVM subject)
        {
            var _subject = new Subject
            {
               Name= subject.Name
            };
            _context.Add(_subject);
            _context.SaveChanges();
            return new SubjectVM
            {
                Id=_subject.Id,
                Name=_subject.Name
            };
        }

        public void Put(SubjectVM subject)
        {
            var _subject = _context.Subjects.SingleOrDefault(x=>x.Id == subject.Id);
            _subject.Name = subject.Name;
            _context.SaveChanges();
        }

    }
}
