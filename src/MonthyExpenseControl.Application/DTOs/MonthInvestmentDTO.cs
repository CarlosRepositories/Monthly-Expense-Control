using MonthyExpenseControl.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Application.DTOs;

/// <summary>
/// Used to transferer MonthInvestment Objects
/// </summary>
public class MonthInvestmentDTO
{
    /// <summary>
    /// Month Investment sequential Id
    /// </summary>
    public int MonthInvestmentId { get; set; }

    /// <summary>
    /// The amount invested.
    /// </summary>
    public double InvestmentAmount { get; set; }

    /// <summary>
    /// Type of investment.
    /// </summary>
    public string TypeOfInvestment { get; set; }

    /// <summary>
    /// The percentage invested related to the salary amount for example 0.10.
    /// </summary>
    public double InvestmentPercentage { get; set; }

    /// <summary>
    /// Number that represent the month        
    /// </summary>
    [Required]
    public int MonthsId { get; set; }

    /// <summary>
    /// Month that the investment happened.
    /// </summary>
    public Months Month { get; set; }
}
