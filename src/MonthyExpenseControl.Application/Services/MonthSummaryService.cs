using AutoMapper;
using MonthyExpenseControl.Application.DTOs;
using MonthyExpenseControl.Application.Interfaces;

namespace MonthyExpenseControl.Application.Services;

public class MonthSummaryService : IMonthSummaryService
{
    private readonly IEarningService EarningService;
    private readonly IExpenseService ExpenseService;
    private readonly ISummaryService SummaryService;

    public MonthSummaryService(IEarningService earningService, IExpenseService expenseService,
                               ISummaryService summaryService)
    {
        EarningService = earningService;
        ExpenseService = expenseService;
        SummaryService = summaryService;
    }
    public MonthSummaryDTO GetMonthSummary(int monthId)
    {
        var monthlyEarnings = EarningService.GetEarningsByMonthAsync(monthId).Result;

        var monthlyExpenses = ExpenseService.GetExpensesByMonthAsync(monthId).Result;

        var summary = SummaryService.GetMonthSummary(monthId);

        return new MonthSummaryDTO
        {
            MonthsId = monthId,
            MonthlyEarnings = monthlyEarnings,
            MonthlyExpenses = monthlyExpenses,
            SumaryOfTheMonth = summary,
        };
    }

    public async Task<MonthSummaryDTO> UpdateMonthSummary(MonthSummaryDTO monthSummaryDTO)
    {
        foreach(EarningDTO earningDTO in monthSummaryDTO.MonthlyEarnings)
        {
            await EarningService.UpdateEarningAsync(earningDTO);            
        }

        foreach(ExpenseDTO expenseDTO in monthSummaryDTO.MonthlyExpenses)
        {
            await ExpenseService.UpdateExpenseAsync(expenseDTO);
        }

        var monthSumaryDto = GetMonthSummary(monthSummaryDTO.MonthsId);

        return monthSumaryDto;
    }
}
