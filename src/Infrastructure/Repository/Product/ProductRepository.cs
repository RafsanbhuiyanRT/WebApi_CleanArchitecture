using Domain.Entity.Category;
using Domain.Entity.Product; 
using Domain.IRepository.Category;
using Domain.IRepository.Product;
using Infrastructure.Data;

namespace Infrastructure.Repository.Product;
public sealed class ProductRepository(ApplicationDbContext dbContext, ICategoryRepository repository) : IProductRepository
{
    public ApplicationDbContext DbContext => dbContext;
    public ICategoryRepository Repository => repository;

    public async Task<int> AddProduct(Products products, CancellationToken cancellationToken)
    {
        await DbContext.Products.AddAsync(products, cancellationToken);
        await DbContext.SaveChangesAsync(cancellationToken);

        return products.Id;
    }
}