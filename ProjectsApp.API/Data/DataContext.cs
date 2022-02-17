using Microsoft.EntityFrameworkCore;
using ProjectsApp.API.Models;

namespace ProjectsApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        
        public DbSet<User> Users { get; set; }
        public DbSet<Execution> Executions { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Risk> Risks { get; set; }
    }
}