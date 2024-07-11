using Domain.IRepository.Category;
using Domain.IRepository.Product;
using Domain.IRepository.Student;
using Infrastructure.Data;
using Infrastructure.Repository.Category;
using Infrastructure.Repository.Product;
using Infrastructure.Repository.Student;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;
//CQRS - Command -- Query Responsibility Segregation
public static class DependencyInjection
{
    public static IServiceCollection AddServices(this IServiceCollection service, IConfiguration configuration)
    {
        service.AddDbContext<ApplicationDbContext>((o) =>
        {
            var connectionString = configuration.GetConnectionString("ConnectionString");
            o.UseSqlServer(connectionString,
                m => m.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
        });

        service.AddScoped<IProductRepository, ProductRepository>();
        service.AddScoped<ICategoryRepository, CategoryRepository>();
        service.AddScoped<IStudentRepository, StudentRepository>();

        return service;
    }
}
