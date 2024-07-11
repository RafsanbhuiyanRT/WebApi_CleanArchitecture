using Domain.Entity.Category;
using Domain.IRepository.Category;
using Infrastructure.Data;

namespace Infrastructure.Repository.Category;
internal class CategoryRepository(ApplicationDbContext dbContext) : ICategoryRepository
{
    public ApplicationDbContext DbContext => dbContext;

    public async Task<int> AddCategory(Categories categories, CancellationToken cancellationToken)
    {
        await DbContext.AddAsync(categories, cancellationToken);
        await DbContext.SaveChangesAsync(cancellationToken);
        return categories.Id;
    }
}
    