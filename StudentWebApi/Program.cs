using Microsoft.EntityFrameworkCore;
using StudentWebApi.Data;
using StudentWebApi.Repository.Definition;
using StudentWebApi.Repository.implementation;
using StudentWebApi.service.Definition;
using StudentWebApi.service.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//here register dbconetxt
builder.Services.AddDbContext<ApplicationDbContext>(db =>
  db.UseSqlServer(builder.Configuration.GetConnectionString("mycon"))
);

builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IStudentservice, StudentService>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();
