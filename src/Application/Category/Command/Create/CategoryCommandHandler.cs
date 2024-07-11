using Domain.Entity.Category;
using Domain.IRepository.Category;
using MediatR;

namespace Application.Category.Command.Create;
internal class CategoryCommandHandler(ICategoryRepository category) : IRequestHandler<CategoryCreateCommand, int>
{
    public ICategoryRepository Category => category;

    public async Task<int> Handle(CategoryCreateCommand request, CancellationToken cancellationToken)
    {

        var category = new Categories
        {
            Name = request.Name,
            ImageUrl = request.ImageUrl,
        };
        var response = await Category.AddCategory(category, cancellationToken);
        return response;
    }
}
