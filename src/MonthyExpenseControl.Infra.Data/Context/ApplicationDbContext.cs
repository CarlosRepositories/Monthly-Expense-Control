using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MonthyExpenseControl.Domain.Entities;
using MonthyExpenseControl.Infra.Data.Identity;

namespace MonthyExpenseControl.Infra.Data.Context;

/// <summary>
/// Represents the context responsible for
/// creating database entities and some configurations
/// </summary>
public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Earning> Earnings { get; set; }
    public DbSet<Expense> Expenses { get; set; }        
    public DbSet<MonthInvestment> MonthInvestments { get; set; }
    public DbSet<Months> MonthsDescription { get; set; }
    public DbSet<WithdrawalOfInvestments> WithdrawalOfInvestments { get; set; }
    public DbSet<LastYearInvestment> LastYearInvestment { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}