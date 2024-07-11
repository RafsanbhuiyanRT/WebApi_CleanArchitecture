using Domain.Entity.Category;
using MediatR;

namespace Application.Category.Query.Get;
public record CategoryGetQuery(int Id) : IRequest<CategoryGetResponse>;

public record CategoryGetResponse(Categories Category);
