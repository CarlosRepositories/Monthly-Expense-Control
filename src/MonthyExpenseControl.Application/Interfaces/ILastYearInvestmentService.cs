using MonthyExpenseControl.Application.DTOs;

namespace MonthyExpenseControl.Application.Interfaces;

public  interface ILastYearInvestmentService
{
    Task AddLastYearInvestmentAsync(LastYearInvestmentDTO investmentDto);
    Task<LastYearInvestmentDTO> GetLastYearInvestmentAsync();
    Task UpdateLastYearInvestmentAsync(LastYearInvestmentDTO investmentDto);
    Task RemoveLastYearInvestmentAsync(LastYearInvestmentDTO investmentDto);
}
