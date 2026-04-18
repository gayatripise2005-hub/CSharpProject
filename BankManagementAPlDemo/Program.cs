using BankManagementAPlDemo.Repository.Definiation;
using BankManagementAPlDemo.Repository.Implementation;
using BankManagementAPlDemo.Service.Definiation;
using BankManagementAPlDemo.Service.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IATMService, ATMService>();
builder.Services.AddScoped<IBranchService, BranchService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<ITransactionService, TransactionService>();

builder.Services.AddScoped<IAccountRepo, AccountRepo>();
builder.Services.AddScoped<IATMRepo, ATMRepo>();
builder.Services.AddScoped<IBranchRepo, BranchRepo>();
builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();
builder.Services.AddScoped<IEmployeeRepo, EmployeeRepo>();
builder.Services.AddScoped<ITransactionRepo, TransactionRepo>();


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



