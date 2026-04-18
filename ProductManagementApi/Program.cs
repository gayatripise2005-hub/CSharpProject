//using ProductManagementApi.Service.Definition;
//using ProductManagementApi.Service.Implementation;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();




//using ProductManagementApi.Data;
//using ProductManagementApi.Service.Definition;
//using ProductManagementApi.Service.Implementation;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();

//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();


//builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
//// SERVICE REGISTRATION (DI)

//builder.Services.AddScoped<IProductService, ProductService>();
//builder.Services.AddScoped<ICategoryService, CategoryService>();
//builder.Services.AddScoped<IBrandService, BrandService>();
//builder.Services.AddScoped<ISupplierService, SupplierService>();


//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();




using ProductManagementApi.Data;
using ProductManagementApi.Repository;
using ProductManagementApi.Service.Definition;
using ProductManagementApi.Service.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



// DB CONTEXT REGISTRATION
builder.Services.AddDbContext<AppDbContext>();


// GENERIC REPOSITORY REGISTRATION

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));



//  SERVICE REGISTRATION (DI)

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<ISupplierService, SupplierService>();


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