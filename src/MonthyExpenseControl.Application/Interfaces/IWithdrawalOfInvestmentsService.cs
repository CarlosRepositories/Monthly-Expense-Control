using MonthyExpenseControl.Application.DTOs;

namespace MonthyExpenseControl.Application.Interfaces;

public interface IWithdrawalOfInvestmentsService
{
    Task AddWithdrawalOfInvestmentAsync(WithdrawalOfInvestmentsDTO withdrawalDto);
    Task<WithdrawalOfInvestmentsDTO> GetWithdrawalOfInvestmentByIdAsync(int id);
    Task<IEnumerable<WithdrawalOfInvestmentsDTO>> GetWithdrawalOfInvestmentAsync();
    Task UpdateWithdrawalOfInvestmentAsync(WithdrawalOfInvestmentsDTO withdrawalDto);
    Task RemoveWithdrawalOfInvestmentAsync(WithdrawalOfInvestmentsDTO withdrawalDto);
}
