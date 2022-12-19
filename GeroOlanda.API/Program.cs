using GeroOlanda.API.AutoMapper;
using GeroOlanda.Domain.Repository;
using GeroOlanda.Domain.Repository.Impl;
using GeroOlanda.Domain.Repository.Impl.GeroDbContext;
using GeroOlanda.Domain.Services;
using GeroOlanda.Domain.Services.Impl;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

//mapeando a repository
builder.Services.Add(new ServiceDescriptor(typeof(IHomeService), new HomeService()));
builder.Services.AddScoped<IHomeRepository, HomeRepository>();
builder.Services.AddScoped<ILoginUserRepository, LoginUserRepository>();

//mapeando a services
builder.Services.AddScoped<IHomeService, HomeService>();
builder.Services.AddScoped<ILoginUserService, LoginUserService>();
builder.Services.AddScoped<IGraficoService, GraficoService>();

//conectando a nossa connection string
IConfigurationRoot configuration = new ConfigurationBuilder()
      .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
      .AddJsonFile("appsettings.json")
      .Build();
//conectando a nossa connection string

builder.Services.AddDbContext<GeroOlandaDbContext>(
 options => options.UseSqlServer(configuration.GetConnectionString("SQLServerDBContext"))

);


// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//configs adicionais
builder.Services.AddAutoMapper(config =>
{
    config.AddProfile<GeroOlandaProfile>();

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

