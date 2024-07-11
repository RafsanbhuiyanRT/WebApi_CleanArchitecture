using Domain.Entity.Student;

namespace Domain.IRepository.Student;
public interface IStudentRepository
{
    Task<Students> Add(Students student, CancellationToken cancellationToken);
    Task<Students> Update(Students student, CancellationToken cancellationToken);
    Task<bool> Remove(int id, CancellationToken cancellationToken);
    Task<Students?> GetById(int id, CancellationToken cancellationToken);
    Task<List<Students>> GetAll(CancellationToken cancellationToken);
}
