using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MonthyExpenseControl.Domain.Entities;

namespace MonthyExpenseControl.Infra.Data.EntitiesConfiguration
{
    public class ExpenseConfiguration : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.HasKey(x => x.ExpenseId);
            builder.Property(x => x.Description).HasMaxLength(40);
        }
    }
}
