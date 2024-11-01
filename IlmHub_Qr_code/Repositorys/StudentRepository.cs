using IlmHub_Qr_code.Data;
using IlmHub_Qr_code.Data.Models;
using IlmHub_Qr_code.Interfaces;

namespace IlmHub_Qr_code.Repositorys
{
    public class StudentRepository(AppDbContext _context) : IStudentRepository
    {
        private readonly AppDbContext context = _context;
        
        public async Task<int> Count()
        {
           return context.student.Count();
        }

        public async Task<Student> Create(Student student)
        {
            context.student.Add(student);
            context.SaveChanges();
            return student;
        }

        public async Task DeleteById(Guid id)
        {
            
        }

        public async Task<Student> GetById(Guid id)
        {
            
            var student = context.student.FirstOrDefault(x => x.Id == id);
            return student ?? new Student ();
        }

        public Task<Student> Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
