using MonthyExpenseControl.Application.DTOs;
using MonthyExpenseControl.Domain.Entities;

namespace MonthyExpenseControl.Application.Interfaces
{
    public interface IEarningService
    {
        Task<EarningDTO> CreateEarningAsync(Earning earning);
        Task<EarningDTO> GetEarningByIdAsync(int id);
        Task<IEnumerable<EarningDTO>> GetEarningsAsync();
        Task<EarningDTO> RemoveEarningsAsync(Earning earning);
        Task<EarningDTO> UpdateEarningAsync(Earning earning);
    }
}
