using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MonthyExpenseControl.Domain.Entities;

namespace MonthyExpenseControl.Infra.Data.EntitiesConfiguration
{
    public class WithdrawalOfinvestmentsConfiguration : IEntityTypeConfiguration<WithdrawalOfInvestments>
    {
        public void Configure(EntityTypeBuilder<WithdrawalOfInvestments> builder)
        {
            builder.HasKey(x => x.WithdrawalOfInvestmentsId);
            builder.Property(x => x.Description).HasMaxLength(40);            
        }
    }
}
