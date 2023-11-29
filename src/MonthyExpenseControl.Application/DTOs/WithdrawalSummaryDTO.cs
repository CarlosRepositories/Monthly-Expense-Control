using MonthyExpenseControl.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Application.DTOs;

/// <summary>
/// Used to transferer WithdrawalSummary Objects
/// </summary>
public class WithdrawalSummaryDTO
{
    /// <summary>
    /// Withdrawal Summary sequential Id
    /// </summary>
    public int WithdrawalSummaryId { get; set; }

    /// <summary>
    /// Contains the monthly withdrawal total value
    /// </summary>
    public double MonthlyWithdrawalTotal { get; set; }

    /// <summary>
    /// Number that represent the month
    /// when the expense happened
    /// </summary>
    [Required]
    public int MonthsId { get; set; }

    /// <summary>
    /// Complete month description
    /// </summary>        
    public Months MonthDescription { get; set; }
}
