using Microsoft.EntityFrameworkCore;
using MonthyExpenseControl.Domain.Entities;
using MonthyExpenseControl.Domain.Interfaces;
using MonthyExpenseControl.Infra.Data.Context;

namespace MonthyExpenseControl.Infra.Data.Repositories
{
    public class LastYearInvestmentRepository : ILastYearInvestmentRepository
    {
        private readonly ApplicationDbContext Context;

        public LastYearInvestmentRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public async Task<LastYearInvestment> CreateLastYearInvestmentAsync(LastYearInvestment lastYearInvestment)
        {
            Context.LastYearInvestment.Add(lastYearInvestment);
            await Context.SaveChangesAsync();
            return lastYearInvestment;
        }

        public async Task<IEnumerable<LastYearInvestment>> GetAllAnnualInvestment()
        {
            return await Context.LastYearInvestment.ToListAsync();
        }

        public async Task<LastYearInvestment> GetLastYearInvestmentAsync()
        {
            return await Context.LastYearInvestment.FirstAsync();
        }

        public async Task<LastYearInvestment> RemoveExpensesAsync(LastYearInvestment lastYearInvestment)
        {
            Context.LastYearInvestment.Remove(lastYearInvestment);
            await Context.SaveChangesAsync();
            return lastYearInvestment;
        }

        public async Task<LastYearInvestment> UpdateLastYearInvestmentAsync(LastYearInvestment lastYearInvestment)
        {
            Context.LastYearInvestment.Update(lastYearInvestment);
            await Context.SaveChangesAsync();
            return lastYearInvestment;
        }
    }
}
