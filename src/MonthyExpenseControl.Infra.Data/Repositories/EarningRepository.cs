using Microsoft.EntityFrameworkCore;
using MonthyExpenseControl.Domain.Entities;
using MonthyExpenseControl.Domain.Interfaces;
using MonthyExpenseControl.Infra.Data.Context;

namespace MonthyExpenseControl.Infra.Data.Repositories
{
    public class EarningRepository : IEarningRepository
    {
        private readonly ApplicationDbContext Context;

        public EarningRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public async Task<Earning> CreateEarningAsync(Earning earning)
        {
            Context.Earnings.Add(earning);
            await Context.SaveChangesAsync();
            return earning;
        }

        public async Task<Earning> GetEarningByIdAsync(int id)
        {
            return await Context.Earnings.FindAsync(id);
        }

        public async Task<IEnumerable<Earning>> GetEarningsAsync()
        {
            return await Context.Earnings.ToListAsync();
        }

        public async Task<Earning> RemoveEarningAsync(Earning earning)
        {

            Context.Earnings.Remove(earning);
            await Context.SaveChangesAsync();
            return earning;
        }

        public async Task<Earning> UpdateEarningAsync(Earning earning)
        {
            Context.Earnings.Update(earning);
            await Context.SaveChangesAsync();
            return earning;
        }
    }
}
