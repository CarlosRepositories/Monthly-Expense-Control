using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MonthyExpenseControl.Domain.Entities;

namespace MonthyExpenseControl.Infra.Data.EntitiesConfiguration
{
    public class EarningConfiguration : IEntityTypeConfiguration<Earning>
    {
        public void Configure(EntityTypeBuilder<Earning> builder)
        {
            builder.HasKey(x => x.EarningId);
            builder.Property(x => x.Description).HasMaxLength(40);

        }
    }
}
