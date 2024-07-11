using Application.Category.Command.Create;
using Application.Category.Command.Update;
using Application.Category.Query.Get;
using Application.Category.Query.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Endpoints.Category;

public static class CategoriesEndpoints
{
    public static IEndpointRouteBuilder AddCategoriesEndpoints(this IEndpointRouteBuilder builder)
    {
        var group = builder.MapGroup("api/Categories").WithTags("Categories");

        group.MapGet("/get", async (int id, ISender sender, CancellationToken cancellationToken) =>
        {
            var res = await sender.Send(new CategoryGetQuery(id));
            return TypedResults.Ok(res);
        });
        group.MapGet("/getAll", async (ISender sender, CancellationToken cancellationToken) =>
        {
            var response = await sender.Send(new CategoryGetAllQuery(), cancellationToken);
            return TypedResults.Ok(response);
        });
        group.MapPost("/Create", async ([FromBody] CategoryCreateCommand products, ISender sender, CancellationToken cancellationToken) =>
        {
            var response = await sender.Send(products);
            return TypedResults.Ok(response);
        });
        group.MapPut("/Update", ([FromBody] CategoryUpdateCommand products, IHttpContextAccessor accessor) =>
        {

            return TypedResults.Ok();
        });
        return builder;
    }
}
