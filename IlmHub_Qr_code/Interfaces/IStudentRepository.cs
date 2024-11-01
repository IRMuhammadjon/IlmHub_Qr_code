using IlmHub_Qr_code.Data.Models;

namespace IlmHub_Qr_code.Interfaces
{
    public interface IStudentRepository
    {
        Task<Student> GetById(Guid id);
        Task DeleteById(Guid id);
        Task<Student> Create(Student student);
        Task<Student> Update(Student student);
        Task<int> Count();
    }
}
