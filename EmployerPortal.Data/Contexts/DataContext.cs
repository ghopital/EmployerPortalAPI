
using EmployerPortal.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployerPortal.Data.Contexts;

public class DataContext:DbContext
{
    public DbSet<User> Users { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }    
}
