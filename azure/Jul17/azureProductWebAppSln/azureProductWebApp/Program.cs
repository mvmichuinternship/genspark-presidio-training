using azureProductWebApp.context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using azureProductWebApp.interfaces;
using azureProductWebApp.models;
using azureProductWebApp.repository;
using azureProductWebApp.services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.OpenApi.Models;


namespace azureProductWebApp
{
    public class Program
    {
        private static async Task<string> GetCs()
        {
            const string secretName = "mv-web-app-cs";
            var keyVaultName = "mv-connection-string";
            var kvUri = $"https://{keyVaultName}.vault.azure.net";
            var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());
            var secret = await client.GetSecretAsync(secretName);
            return secret.Value.Value;
        }
        
        private static async Task<string> GetBlobCs()
        {
            const string secretName = "mv-blob-cs";
            var keyVaultName = "mv-connection-string";
            var kvUri = $"https://{keyVaultName}.vault.azure.net";
            var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());
            var secret = await client.GetSecretAsync(secretName);
            return secret.Value.Value;
        }
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API", Version = "v1" });
            });

            #region context

            var defaultConnection = await GetCs();

            builder.Services.AddDbContext<AzureAppContext>(
                options => options.UseSqlServer(defaultConnection)
                );

            #endregion

            #region repositories
            builder.Services.AddScoped<IRepository<int, Product>, ProductRepository>();

            #endregion
            #region services
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IBlobService, BlobStorageService>();

            var blobcs = await GetBlobCs();
            builder.Services.AddSingleton(x => new BlobServiceClient(blobcs));
            #endregion

            //#region cors
            //builder.Services.AddCors(options =>
            //{
            //    options.AddPolicy("AllowAll", policy =>
            //    {
            //        policy.AllowAnyOrigin()
            //              .AllowAnyMethod()
            //              .AllowAnyHeader();
            //    });
            //});
            //#endregion


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //app.UseCors("AllowAll");
            app.UseRouting();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
