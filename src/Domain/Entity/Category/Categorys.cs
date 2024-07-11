using Domain.Primitive;

namespace Domain.Entity.Category;
public class Categories : BaseEntity<int>
{
    public string? Name { get; set; }
    public string? ImageUrl { get; set; }
}
