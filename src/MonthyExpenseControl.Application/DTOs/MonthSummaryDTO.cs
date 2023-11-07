using MonthyExpenseControl.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Application.DTOs;

/// <summary>
/// Used to transferer MonthSummary Objects
/// </summary>
public class MonthSummaryDTO
{
    /// <summary>
    /// Month Sumary sequential Id
    /// </summary>
    public int MonthSummaryId { get; set; }

    /// <summary>
    /// Contains all earnings for a month.
    /// </summary>
    public List<Earning> MonthlyEarnings { get; set; }

    /// <summary>
    /// Contains all expenses for a month.
    /// </summary>
    public List<Expense> MonthlyExpenses { get; set; }

    /// <summary>
    /// Sumary of the month.
    /// </summary>
    public Summary SumaryOfTheMonth { get; set; }

    /// <summary>
    /// Number that represent a month
    /// </summary>
    [Required]
    public int MonthsId { get; set; }

    /// <summary>
    /// Complete Month Description.
    /// </summary>
    public Months MonthDescription { get; set; }
}
