using Microsoft.EntityFrameworkCore;
using ProductManagment.Data;
using ProductManagment.Repositories.Defination;
using ProductManagment.Repositories.Implemetation;
using ProductManagment.Service.Products;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//here Register the services

//IServiceCollection Contain Service Registration Methods Like AddScoped, AddSingleton, AddTransient
#region Service Registration For Service 
//builder.Services.AddScoped<IProductService, ProductService>();
#endregion

#region Service Registration For Repository
//generic Repiository 
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
#endregion


#region Service Registration For DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("myconnection")));
#endregion;


#region Helper Service Regitration 

#endregion

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
