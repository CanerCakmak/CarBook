using CarBook.Application.Interfaces.Repositories;
using CarBook.Application.Interfaces.UnitOfWorks;

using CarBook.Application;
using CarBook.Persistence;
using CarBook.CustomMapper;

using CarBook.Persistence.Context;
using CarBook.Persistence.Repositories;
using CarBook.Persistence.UnitOfWorks;
using CarBook.Application.Exceptions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>();

//builder.Services.AddPersistence();
builder.Services.AddApplication();
builder.Services.AddCustomMapper();

builder.Services.AddScoped(typeof(IReadRepository<>),typeof(ReadRepository<>));
builder.Services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));

builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureExceptionHandlingMiddleware();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
