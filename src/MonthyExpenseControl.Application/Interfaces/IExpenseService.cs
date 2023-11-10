using MonthyExpenseControl.Application.DTOs;

namespace MonthyExpenseControl.Application.Interfaces;

public interface IExpenseService
{
    Task AddExpenseAsync(ExpenseDTO expenseDto);
    Task<ExpenseDTO> GetExpenseByIdAsync(int id);
    Task<IEnumerable<ExpenseDTO>> GetExpensesByMonthAsync(int monthId);
    Task UpdateExpenseAsync(ExpenseDTO expenseDto);
    Task RemoveExpenseAsync(ExpenseDTO expenseDto);

}
