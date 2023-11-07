using MonthyExpenseControl.Domain.Entities;

namespace MonthyExpenseControl.Domain.Interfaces
{
    public interface IEarningRepository
    {
        Task<Earning> GetEarningByIdAsync(int id);
        Task<IEnumerable<Earning>> GetEarningsAsync();
        Task<Earning> CreateEarningAsync(Earning earning);        
        Task<Earning> UpdateEarningAsync(Earning earning);
        Task<Earning> RemoveEarningAsync(Earning earning);
    }
}
