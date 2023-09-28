using Microsoft.EntityFrameworkCore;
using MonthyExpenseControl.Models;

namespace MonthyExpenseControl.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Earning> Earnings { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<InvestmentCapacity> InvestmentCapacities { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<MonthInvestment> MonthInvestments { get; set; }
        public DbSet<Months> MonthsDescription { get; set; }
        public DbSet<Sumary> Sumaries { get; set; }
        public DbSet<WithdrawalOfInvestments> WithdrawalOfInvestments { get; set; }
    }
}
