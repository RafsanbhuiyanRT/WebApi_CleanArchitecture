using Domain.Entity.Category;
using Domain.Primitive;

namespace Domain.Entity.Product;
public class Products : BaseEntity<int>
{
    public string? Name { get; set; }
    public int CategoryId { get; set; }
    public Categories? Category { get; set; }
}
