//using OrderManagementApi.Repository;
//using OrderManagementApi.Service.Definition;
//using OrderManagementApi.Service.Implementation;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();



//builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

//builder.Services.AddScoped<ICustomerSerivce, CustomerService>();
//builder.Services.AddScoped<IOrderService, OrederService>();
//builder.Services.AddScoped<IInvoiceService, InvoiceService>();

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


////----------------------------------------------------------------------------------

using OrderManagementApi.Repository;
using OrderManagementApi.Service.Definition;
using OrderManagementApi.Service.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register dependencies BEFORE building
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddScoped<ICustomerSerivce, CustomerService>();
builder.Services.AddScoped<IOrderService, OrederService>();
builder.Services.AddScoped<IInvoiceService, InvoiceService>();

// Build the app once
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
