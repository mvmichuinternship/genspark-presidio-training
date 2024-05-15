using doctorWebApp.context;
using doctorWebApp.interfaces;
using doctorWebApp.models;
using doctorWebApp.repositories;
using doctorWebApp.services;
using Microsoft.EntityFrameworkCore;

namespace doctorWebApp
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
            #region Context
            builder.Services.AddDbContext<doctorAppContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection"))
                );
            #endregion
            #region Repository
            builder.Services.AddScoped<IRepository<int, Doctor>, DoctorRepository>();
            #endregion
            #region Services
            builder.Services.AddScoped<IDoctorService, DoctorService>();
            #endregion
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
