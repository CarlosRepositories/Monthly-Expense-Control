using MonthyExpenseControl.Domain.Entities;

namespace MonthyExpenseControl.Domain.Interfaces
{
    public interface ILastYearInvestmentRepository
    {
        Task<LastYearInvestment> GetLastYearInvestmentAsync();
        Task<IEnumerable<LastYearInvestment>> GetAllAnnualInvestment();
        Task<LastYearInvestment> CreateLastYearInvestmentAsync(LastYearInvestment lastYearInvestment);
        Task<LastYearInvestment> UpdateLastYearInvestmentAsync(LastYearInvestment lastYearInvestment);
        Task<LastYearInvestment> RemoveExpensesAsync(LastYearInvestment lastYearInvestment);
    }
}
