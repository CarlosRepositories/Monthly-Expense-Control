using AutoMapper;
using MonthyExpenseControl.Application.DTOs;
using MonthyExpenseControl.Application.Interfaces;
using MonthyExpenseControl.Domain.Entities;
using MonthyExpenseControl.Domain.Interfaces;

namespace MonthyExpenseControl.Application.Services;

public class ExpenseDataAccessSevice : IExpenseService
{
    private readonly IExpenseRepository Repository;
    private readonly IMapper Mapper;
    public ExpenseDataAccessSevice(IExpenseRepository repository, IMapper mapper)
    {
        Repository = repository;
        Mapper = mapper;
    }

    public async Task AddExpenseAsync(ExpenseDTO expenseDto)
    {
        var expense = Mapper.Map<Expense>(expenseDto);
        await Repository.CreateExpenseAsync(expense);        
    }

    public async Task<ExpenseDTO> GetExpenseByIdAsync(int id)
    {
        var expense = await Repository.GetExpenseByIdAsync(id);
        return Mapper.Map<ExpenseDTO>(expense);
    }

    public async Task<IEnumerable<ExpenseDTO>> GetExpensesByMonthAsync(int monthId)
    {
        var expenses = await Repository.GetExpensesAsync();
        var expensesByMonth = expenses
            .Where(e => e.MonthsId == monthId);
        return Mapper.Map<IEnumerable<ExpenseDTO>>(expenses);
    }

    public async Task UpdateExpenseAsync(ExpenseDTO expenseDto)
    {
        var expense = Mapper.Map<Expense>(expenseDto);
        await Repository.UpdateExpenseAsync(expense);
    }

    public async Task RemoveExpenseAsync(ExpenseDTO expenseDto)
    {
        var expense = Mapper.Map<Expense>(expenseDto);
        await Repository.RemoveExpensesAsync(expense);
    }
}
