using MediatR;

namespace Application.Category.Command.Update;
public class CategoryUpdateCommand(
    int Id,
    string Name,
    string ImageUrl) : IRequest<bool>;