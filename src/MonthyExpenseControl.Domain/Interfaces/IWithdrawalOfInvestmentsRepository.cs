using MonthyExpenseControl.Domain.Entities;

namespace MonthyExpenseControl.Domain.Interfaces
{
    public interface IWithdrawalOfInvestmentsRepository
    {
        Task<WithdrawalOfInvestments> GetEarningByIdAsync(int id);
        Task<IEnumerable<WithdrawalOfInvestments>> GetEarningsAsync();
        Task<WithdrawalOfInvestments> CreateEarningAsync(WithdrawalOfInvestments withdrawal);
        Task<WithdrawalOfInvestments> UpdateEarningAsync(WithdrawalOfInvestments withdrawal);

    }
}
