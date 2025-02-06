using EmployerPortal.Data;
using EmployerPortal.Data.Abstractions;
using EmployerPortal.Data.Contexts;
using EmployerPortal.Exceptions.Handler;
using EmployerPortal.Service.Abstractions;
using EmployerPortal.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("Database"));
});

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddExceptionHandler<CustomExceptionHandler>();
builder.Services.AddCors();
builder.Services.AddControllers();


var app = builder.Build();
app.UseRouting();

app.MapControllers();
app.Run();
