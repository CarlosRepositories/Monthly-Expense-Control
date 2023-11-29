using MonthyExpenseControl.Application.DTOs;

namespace MonthyExpenseControl.Application.Interfaces;

public interface ISummaryService
{
    SummaryDTO GetMonthSummary(int monthId);
}
