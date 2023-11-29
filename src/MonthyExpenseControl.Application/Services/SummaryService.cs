using MonthyExpenseControl.Application.DTOs;
using MonthyExpenseControl.Application.Interfaces;

namespace MonthyExpenseControl.Application.Services;

public class SummaryService : ISummaryService
{
    private readonly IEarningService EarningService;
    private readonly IExpenseService ExpenseService;

    public SummaryService(IEarningService earningService, IExpenseService expenseService)
    {
        EarningService = earningService;
        ExpenseService = expenseService;
    }
    public SummaryDTO GetMonthSummary(int monthId) 
    {
        var earningsSummary = EarningService
            .GetEarningsByMonthAsync(monthId).Result;

        var expensesSummary = ExpenseService
            .GetExpensesByMonthAsync(monthId).Result;

        var totalProjectedEarnings = earningsSummary
            .Sum(e => e.ProjectedEarning);
        var totalProjectedExpenses = expensesSummary
            .Sum(e => e.ProjectedExpense);
        var totalRealizedEarnings = earningsSummary
            .Sum(e => e.RealizedEarning);
        var totalRealizedExpenses = expensesSummary
            .Sum(e => e.RealizedExpense);

        return new SummaryDTO
        {
            MonthId = monthId,
            TotalProjectedEarnings = totalProjectedEarnings,
            TotalProjectedExpenses = totalProjectedExpenses,
            TotalRealizedEarnings = totalRealizedEarnings,
            TotalRealizedExpenses = totalRealizedExpenses,
            TotalProjectedInvestmentCapacity = totalProjectedEarnings - totalProjectedExpenses,
            TotalRealizedInvestmentCapacity = totalRealizedEarnings - totalRealizedExpenses
        };            
    }
}
