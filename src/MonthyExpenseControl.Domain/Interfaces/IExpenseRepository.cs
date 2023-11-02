using MonthyExpenseControl.Domain.Entities;

namespace MonthyExpenseControl.Domain.Interfaces
{
    public interface IExpenseRepository
    {
        Task<Expense> GetExpenseByIdAsync(int id);
        Task<IEnumerable<Expense>> GetExpensesAsync();
        Task<Expense> CreateExpenseAsync(Expense expense);
        Task<Expense> UpdateExpenseAsync(Expense expense);
        Task<Expense> RemoveExpensesAsync(Expense expense);
    }
}
