using MediatR;

namespace Application.Category.Command.Create;
public record CategoryCreateCommand(
    string Name, 
    string ImageUrl
    ) : IRequest<int>;
