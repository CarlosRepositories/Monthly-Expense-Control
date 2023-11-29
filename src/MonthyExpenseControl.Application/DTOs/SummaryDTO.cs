using MonthyExpenseControl.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Application.DTOs;

/// <summary>
/// Used to transferer Sumary Objects
/// </summary>
public class SummaryDTO
{
    /// <summary>
    /// Sumary sequential Id
    /// </summary>
    public int SummaryId { get; set; }

    /// <summary>
    /// Total projected earnings.
    /// </summary>
    public double TotalProjectedEarnings { get; set; }

    /// <summary>
    /// Total projected Earning.
    /// </summary>
    public double TotalProjectedExpenses { get; set; }

    /// <summary>
    /// Total projected earnings.
    /// </summary>
    public double TotalRealizedEarnings { get; set; }

    /// <summary>
    /// Total projected Earning.
    /// </summary>
    public double TotalRealizedExpenses { get; set; }

    /// <summary>
    /// Total Projected Investment Capacity.
    /// </summary>
    public double TotalProjectedInvestmentCapacity { get; set; }

    /// <summary>
    /// Total Projected Investment Capacity.
    /// </summary>
    public double TotalRealizedInvestmentCapacity { get; set; }

    /// <summary>
    /// Number that represent the month        
    /// </summary>
    [Required]
    public int MonthId { get; set; }

    /// <summary>
    /// Complete month description
    /// </summary>        
    public Months MonthDescription { get; set; }
}
