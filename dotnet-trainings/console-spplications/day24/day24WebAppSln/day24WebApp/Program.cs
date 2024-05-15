using day24WebApp.contexts;
using day24WebApp.interfaces;
using day24WebApp.models;
using day24WebApp.repositories;
using day24WebApp.services;
using Microsoft.EntityFrameworkCore;

namespace day24WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<RequestTrackerContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection"))
                );

            builder.Services.AddScoped<IRepository<int, Employee>, EmployeeRepository>();

            builder.Services.AddScoped<IEmployeeService, EmployeeBasicService>();

            
            builder.Services.AddScoped<IRepository<int, User>, UserRepository>();

            builder.Services.AddScoped<IUserService, UserService>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
