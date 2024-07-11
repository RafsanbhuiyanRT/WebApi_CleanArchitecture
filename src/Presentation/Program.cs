using Application;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Presentation.Endpoints.Category;
using Presentation.Endpoints.Product;

var builder = WebApplication.CreateBuilder(args);

builder.Services.TryAddTransient<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddServices(builder.Configuration);

builder.Services.AddMediatR(config =>
    config.RegisterServicesFromAssembly(AssemblyReference.Assembly));


builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
builder.Services.AddControllers();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

//app.UseCors();
//Access Capability
app.UseAuthentication();

//Check User Identity, Role, Access Permission
app.UseAuthorization();
//Custom middleware
//app.UseMiddleware<>();

app.MapControllers();

app.AddProductEndpoints();
app.AddCategoriesEndpoints();

app.Run();
