using MonthyExpenseControl.Domain.Entities;

namespace MonthyExpenseControl.Domain.Interfaces
{
    public interface IWithdrawalOfInvestmentsRepository
    {
        Task<WithdrawalOfInvestments> GetWithDrawalByIdAsync(int id);
        Task<IEnumerable<WithdrawalOfInvestments>> GetWithDrawalsAsync();
        Task<WithdrawalOfInvestments> CreateWithDrawalAsync(WithdrawalOfInvestments withdrawal);
        Task<WithdrawalOfInvestments> UpdateWithDrawalAsync(WithdrawalOfInvestments withdrawal);
        Task<WithdrawalOfInvestments> RemoveWithDrawalAsync(WithdrawalOfInvestments withdrawal);

    }
}
