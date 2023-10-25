
using Application.Interfaces;
using Infrastructure.Repositories;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddTransient<IProductRepository, ProductRepository>(provider => new ProductRepository(connectionString));
            builder.Services.AddTransient<ICategoryRepository, CategoryRepository>(provider => new CategoryRepository(connectionString));

            builder.Services.AddTransient<IApplicationDbContext, ApplicationDbContext>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}