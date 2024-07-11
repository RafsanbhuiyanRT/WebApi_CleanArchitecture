using MediatR;

namespace Application.Category.Query.Get;
internal class CategoryGetHandler : IRequestHandler<CategoryGetQuery, CategoryGetResponse>
{
    public Task<CategoryGetResponse> Handle(CategoryGetQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
