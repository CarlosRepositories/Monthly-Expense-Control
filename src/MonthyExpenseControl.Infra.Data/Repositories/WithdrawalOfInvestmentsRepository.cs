using Microsoft.EntityFrameworkCore;
using MonthyExpenseControl.Domain.Entities;
using MonthyExpenseControl.Domain.Interfaces;
using MonthyExpenseControl.Infra.Data.Context;
using System.Runtime.CompilerServices;

namespace MonthyExpenseControl.Infra.Data.Repositories
{
    public  class WithdrawalOfInvestmentsRepository : IWithdrawalOfInvestmentsRepository
    {
        private readonly ApplicationDbContext Context;

        public WithdrawalOfInvestmentsRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public async Task<WithdrawalOfInvestments> RemoveWithDrawalAsync(WithdrawalOfInvestments withdrawal)
        {
            Context.WithdrawalOfInvestments.Remove(withdrawal);
            await Context.SaveChangesAsync();
            return withdrawal;
        }

        public async Task<WithdrawalOfInvestments> GetWithDrawalByIdAsync(int id)
        {
            return await Context.WithdrawalOfInvestments.FindAsync(id);
        }

        public async Task<IEnumerable<WithdrawalOfInvestments>> GetWithDrawalsAsync()
        {
            return await Context.WithdrawalOfInvestments.ToListAsync();
        }

        public async Task<WithdrawalOfInvestments> CreateWithDrawalAsync(WithdrawalOfInvestments withdrawal)
        {
            Context.WithdrawalOfInvestments.Add(withdrawal);
            await Context.SaveChangesAsync();
            return withdrawal;
        }

        public async Task<WithdrawalOfInvestments> UpdateWithDrawalAsync(WithdrawalOfInvestments withdrawal)
        {
            Context.WithdrawalOfInvestments.Update(withdrawal);
            await Context.SaveChangesAsync();
            return withdrawal;
        }        
    }
}
