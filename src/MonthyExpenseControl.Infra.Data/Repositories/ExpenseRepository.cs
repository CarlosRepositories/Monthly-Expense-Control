using Microsoft.EntityFrameworkCore;
using MonthyExpenseControl.Domain.Entities;
using MonthyExpenseControl.Domain.Interfaces;
using MonthyExpenseControl.Infra.Data.Context;

namespace MonthyExpenseControl.Infra.Data.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly ApplicationDbContext Context;

        public ExpenseRepository(ApplicationDbContext context)
        {
            Context = context;
        }
        public async Task<Expense> CreateExpenseAsync(Expense expense)
        {
            Context.Expenses.Add(expense);
            await Context.SaveChangesAsync();
            return expense;
        }

        public async Task<Expense> GetExpenseByIdAsync(int id)
        {
            return await Context.Expenses.FindAsync(id);
        }

        public async Task<IEnumerable<Expense>> GetExpensesAsync()
        {
            return await Context.Expenses.ToListAsync();
        }

        public async Task<Expense> RemoveExpensesAsync(Expense expense)
        {
            Context.Expenses.Remove(expense);
            await Context.SaveChangesAsync();
            return expense;
        }

        public async Task<Expense> UpdateExpenseAsync(Expense expense)
        {
            Context.Expenses.Update(expense);
            await Context.SaveChangesAsync();
            return expense;
        }
    }
}