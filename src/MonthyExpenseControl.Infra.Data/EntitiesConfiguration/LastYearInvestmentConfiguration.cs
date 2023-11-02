using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MonthyExpenseControl.Domain.Entities;

namespace MonthyExpenseControl.Infra.Data.EntitiesConfiguration
{
    public class LastYearInvestmentConfiguration : IEntityTypeConfiguration<LastYearInvestment>
    {
        public void Configure(EntityTypeBuilder<LastYearInvestment> builder)
        {
            builder.HasKey(x => x.LatestYearId);
            builder.HasData(new LastYearInvestment(1, 1535.00, 2022));
        }
    }
}
