using Domain.Entity.Category;
using MediatR;

namespace Application.Category.Query.GetAll;
public record CategoryGetAllQuery() : IRequest<CategoryGetAllResponse>;

public record CategoryGetAllResponse(List<Categories> Category);