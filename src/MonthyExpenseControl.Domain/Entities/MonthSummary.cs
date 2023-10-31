using MonthyExpenseControl.Domain.Validation;
using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Domain.Entities;

/// <summary>
/// All description and values
/// related to expenses and earnings, considering projected
/// and realized.
/// </summary>
public sealed class MonthSummary
{
    /// <summary>
    /// Month Sumary sequential Id
    /// </summary>
    public int MonthSummaryId { get; private set; }

    /// <summary>
    /// Contains all earnings for a month.
    /// </summary>
    public List<Earning> MonthlyEarnings { get; private set; }

    /// <summary>
    /// Contains all expenses for a month.
    /// </summary>
    public List<Expense> MonthlyExpenses { get; private set; }

    /// <summary>
    /// Sumary of the month.
    /// </summary>
    public Summary SumaryOfTheMonth { get; private set; }

    /// <summary>
    /// class constructor
    /// </summary>
    /// <param name="monthlyEarnings"></param>
    /// <param name="monthlyExpenses"></param>
    /// <param name="sumaryOfTheMonth"></param>
    public MonthSummary(int monthSummaryId, List<Earning> monthlyEarnings, List<Expense> monthlyExpenses,
                        Summary sumaryOfTheMonth)
    {
        DomainExceptionValidation.when(monthSummaryId < 0, "Value cannot be less than zero.");
        MonthSummaryId = monthSummaryId;
        MonthlyEarnings = monthlyEarnings;
        MonthlyExpenses = monthlyExpenses;
        SumaryOfTheMonth = sumaryOfTheMonth;
    }

    /// <summary>
    /// class constructor
    /// </summary>
    /// <param name="monthlyEarnings"></param>
    /// <param name="monthlyExpenses"></param>
    /// <param name="sumaryOfTheMonth"></param>
    public MonthSummary(List<Earning> monthlyEarnings, List<Expense> monthlyExpenses,
                        Summary sumaryOfTheMonth)
    {
        MonthlyEarnings = monthlyEarnings;
        MonthlyExpenses = monthlyExpenses;
        SumaryOfTheMonth = sumaryOfTheMonth;
    }

    /// <summary>
    /// Update domain properties
    /// </summary>
    /// <param name="monthlyEarnings"></param>
    /// <param name="monthlyExpenses"></param>
    /// <param name="sumaryOfTheMonth"></param>
    private void Update(List<Earning> monthlyEarnings, List<Expense> monthlyExpenses,
                    Summary sumaryOfTheMonth)
    {
        MonthlyEarnings = monthlyEarnings;
        MonthlyExpenses = monthlyExpenses;
        SumaryOfTheMonth = sumaryOfTheMonth;
    }

    /// <summary>
    /// Number that represent a month
    /// </summary>
    [Required]
    public int MonthsId { get; private set; }

    /// <summary>
    /// Complete Month Description.
    /// </summary>
    public Months MonthDescription { get; private set; }
}
