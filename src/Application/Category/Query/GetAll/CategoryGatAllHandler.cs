using MediatR;

namespace Application.Category.Query.GetAll;
internal class CategoryGatAllHandler : IRequestHandler<CategoryGetAllQuery, CategoryGetAllResponse>
{
    public Task<CategoryGetAllResponse> Handle(CategoryGetAllQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
