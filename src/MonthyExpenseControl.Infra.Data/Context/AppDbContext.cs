using Microsoft.EntityFrameworkCore;
using MonthyExpenseControl.Domain.Entities;

namespace MonthyExpenseControl.Infra.Data.Migrations;

/// <summary>
/// Represents the context responsible for
/// creating database entities and some configurations
/// </summary>
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Earning> Earnings { get; set; }
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<InvestmentCapacity> InvestmentCapacities { get; set; }
    public DbSet<MonthSummary> Months { get; set; }
    public DbSet<MonthInvestment> MonthInvestments { get; set; }
    public DbSet<Months> MonthsDescription { get; set; }
    public DbSet<Summary> Summaries { get; set; }
    public DbSet<WithdrawalOfInvestments> WithdrawalOfInvestments { get; set; }
    public DbSet<WithdrawalSummary> WithdrawalSumaries { get; set; }
}