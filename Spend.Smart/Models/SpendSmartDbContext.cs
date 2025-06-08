using Microsoft.EntityFrameworkCore;

namespace Spend.Smart.Models
{
    public class SpendSmartDbContext: DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public SpendSmartDbContext(DbContextOptions<SpendSmartDbContext> options) : base(options)
        {
            
        }
    }
}
