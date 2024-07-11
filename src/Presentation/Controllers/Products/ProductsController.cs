using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers.Products;
[Route("api/[controller]")]
[ApiController] //Dependency Injection
public class ProductsController(IHttpContextAccessor accessor) : Controller
{
    [HttpGet("GetAll")]
    public ActionResult GetAll()
    {
        var tt = HttpContext.User;
        return Ok();
    }
}
