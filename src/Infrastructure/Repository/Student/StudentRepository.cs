using Domain.Entity.Student;
using Domain.IRepository.Student;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository.Student;
internal class StudentRepository(ApplicationDbContext dbContext) : IStudentRepository
{
    public ApplicationDbContext DbContext => dbContext;

    public async Task<Students> Add(Students student, CancellationToken cancellationToken)
    {
        await DbContext.AddAsync(student, cancellationToken);
        await DbContext.SaveChangesAsync(cancellationToken);
        return student;
    }

    public async Task<List<Students>> GetAll(CancellationToken cancellationToken)
    {
        var data = await DbContext.Students.ToListAsync();
        return data;
    }

    public async Task<Students?> GetById(int id, CancellationToken cancellationToken)
    {
        var data = await DbContext.Students.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        return data;
    }

    public Task<bool> Remove(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Students> Update(Students student, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
