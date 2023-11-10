using MonthyExpenseControl.Application.DTOs;

namespace MonthyExpenseControl.Application.Interfaces;

public interface IEarningService
{
    Task AddEarningAsync(EarningDTO earningDto);
    Task<EarningDTO> GetEarningByIdAsync(int id);
    Task<IEnumerable<EarningDTO>> GetEarningsByMonthAsync(int monthId);
    Task RemoveEarningsAsync(EarningDTO earningDto);
    Task UpdateEarningAsync(EarningDTO earningDto);
}
