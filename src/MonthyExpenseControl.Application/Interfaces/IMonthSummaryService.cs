using MonthyExpenseControl.Application.DTOs;

namespace MonthyExpenseControl.Application.Interfaces;

public interface IMonthSummaryService
{
    MonthSummaryDTO GetMonthSummary(int monthId);

    Task<MonthSummaryDTO> UpdateMonthSummary(MonthSummaryDTO monthSummaryDTO);
}