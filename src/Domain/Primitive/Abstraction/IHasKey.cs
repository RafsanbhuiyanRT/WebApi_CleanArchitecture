namespace Domain.Primitive.Abstraction;
internal interface IHasKey<TKey>
{
    TKey? Id { get; set; }
}
