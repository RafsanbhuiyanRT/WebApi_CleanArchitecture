using Domain.Entity.Category;

namespace Domain.IRepository.Category;
public interface ICategoryRepository
{
    Task<int> AddCategory(Categories categories, CancellationToken cancellationToken);
}
