using GeroOlanda.API.AutoMapper;
using GeroOlanda.Domain.Repository;
using GeroOlanda.Domain.Repository.Impl;
using GeroOlanda.Domain.Services;
using GeroOlanda.Domain.Services.Impl;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//configs adicionais
builder.Services.AddAutoMapper(config => {
    config.AddProfile<GeroOlandaProfile>();

});
//mapeando a services
builder.Services.Add(new ServiceDescriptor(typeof(IHomeService), new HomeService()));

//mapeando a repository
builder.Services.Add(new ServiceDescriptor(typeof(IHomeRepository), new HomeRepository()));
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

