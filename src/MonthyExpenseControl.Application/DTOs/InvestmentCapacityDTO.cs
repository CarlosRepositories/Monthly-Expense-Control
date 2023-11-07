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
    public int InvestmentCapacityId { get; private set; }

    /// <summary>
    /// Projected investment capacity.
    /// </summary>
    public double ProjectedInvestmentCapacity { get; private set; }

    /// <summary>
    /// Realized investment capacity 
    /// </summary>
    public double ReliazedInvestmentCapacity { get; private set; }

    /// <summary>
    /// Number that represent the month        
    /// </summary>
    [Required]
    public int MonthsId { get; private set; }

    /// <summary>
    /// Complete month description
    /// </summary>        
    public Months MonthDescription { get; private set; }
}
