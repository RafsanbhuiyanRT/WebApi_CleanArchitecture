using Domain.Entity.Product;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Endpoints.Product;

//Minimal Api
public static class ProductsEndpoints
{
    public static IEndpointRouteBuilder AddProductEndpoints(this IEndpointRouteBuilder builder)
    {
        var group = builder.MapGroup("api/products");

        group.MapGet("/get", (int id, IHttpContextAccessor accessor) =>
        {
            var user = accessor.HttpContext.User;
            return TypedResults.Ok();
        });
        group.MapPost("/Create", ([FromBody] Products products, IHttpContextAccessor accessor) =>
        {
            var user = accessor.HttpContext.User;
            return TypedResults.Ok();
        });
        group.MapPut("/Update", ([FromBody] Products products, IHttpContextAccessor accessor) =>
        {
            var user = accessor.HttpContext.User;
            return TypedResults.Ok();
        });
        return builder;
    }
}
