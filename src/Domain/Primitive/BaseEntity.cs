using Domain.Primitive.Abstraction;
using System.ComponentModel.DataAnnotations;

namespace Domain.Primitive;
public abstract class BaseEntity<TKey> : IHasKey<TKey>
{
    [Key]
    public TKey? Id { get; set; }
}