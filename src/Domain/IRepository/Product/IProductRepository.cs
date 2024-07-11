using Domain.Entity.Product;

namespace Domain.IRepository.Product;
public interface IProductRepository
{
    Task<int> AddProduct(Products products, CancellationToken cancellationToken);
}
