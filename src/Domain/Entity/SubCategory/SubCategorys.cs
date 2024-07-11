using Domain.Entity.Category;
using Domain.Primitive;

namespace Domain.Entity.SubCategory;
public class SubCategories : BaseEntity<int>
{
    public string? Name { get; set; }
    public string? ImageUrl { get; set; }
    public int CategoryId { get; set; }
    public Categories? Category { get; set; }
}
