using Microsoft.EntityFrameworkCore;

namespace Expense.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Expense.Models.Expense> Expenses { get; set; }
    }
}
