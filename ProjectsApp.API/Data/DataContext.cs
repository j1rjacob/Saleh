using Microsoft.EntityFrameworkCore;
using ProjectsApp.API.Models;

namespace ProjectsApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        
        public DbSet<User> Users { get; set; }
    }
}