using MonthyExpenseControl.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Application.DTOs;

/// <summary>
///  Used to transferer InvestmentCapacity Objects
/// </summary>
public class InvestmentCapacityDTO
{
    /// <summary>
    /// Investiment sequential Id
    /// </summary>
    public int InvestmentCapacityId { get; set; }

    /// <summary>
    /// Projected investment capacity.
    /// </summary>
    public double ProjectedInvestmentCapacity { get; set; }

    /// <summary>
    /// Realized investment capacity 
    /// </summary>
    public double ReliazedInvestmentCapacity { get; set; }

    /// <summary>
    /// Number that represent the month        
    /// </summary>
    [Required]
    public int MonthsId { get; set; }

    /// <summary>
    /// Complete month description
    /// </summary>        
    public Months MonthDescription { get; set; }
}
