using MonthyExpenseControl.Domain.Validation;
using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Domain.Entities;

/// <summary>
/// Represents monthly investment capacity
/// </summary>
public sealed class InvestmentCapacity
{
    /// <summary>
    /// Investiment sequential Id
    /// </summary>
    public int InvestmentCapacityId { get; private set; }

    /// <summary>
    /// Projected investment capacity.
    /// </summary>
    public double ProjectedInvestmentCapacity { get; private set; } = 0.00;

    /// <summary>
    /// Realized investment capacity 
    /// </summary>
    public double ReliazedInvestmentCapacity { get; private set; } = 0.00;

    /// <summary>
    /// Class constructor
    /// </summary>
    /// <param name="monthsId"></param>
    /// <param name="projectedInvestmentCapacity"></param>
    /// <param name="reliazedInvestmentCapacity"></param>
    public InvestmentCapacity(int monthsId, double projectedInvestmentCapacity, double reliazedInvestmentCapacity)
    {
        validateDomain(monthsId, projectedInvestmentCapacity, reliazedInvestmentCapacity);
    }

    /// <summary>
    /// Class constructor
    /// </summary>
    /// <param name="monthsId"></param>
    /// <param name="projectedInvestmentCapacity"></param>
    /// <param name="reliazedInvestmentCapacity"></param>
    public InvestmentCapacity(int investmentCapacityId, int monthsId, double projectedInvestmentCapacity, double reliazedInvestmentCapacity)
    {
        DomainExceptionValidation.when(investmentCapacityId < 0, "Value cannot be less tha zero.");
        InvestmentCapacityId = investmentCapacityId;
        validateDomain(monthsId, projectedInvestmentCapacity, reliazedInvestmentCapacity);
    }

    /// <summary>
    /// Validates domain values
    /// according to business rules
    /// </summary>
    private void validateDomain(int monthsId, double projectedInvestmentCapacity, double reliazedInvestmentCapacity)
    {
        DomainExceptionValidation.when(monthsId < 0, "Invalid Id value.");
        DomainExceptionValidation.when(projectedInvestmentCapacity < 0, "Value cannot be less than zero.");
        DomainExceptionValidation.when(reliazedInvestmentCapacity < 0, "Value cannot be less than zero.");

        MonthsId = monthsId;
        ProjectedInvestmentCapacity = projectedInvestmentCapacity;
        ReliazedInvestmentCapacity = reliazedInvestmentCapacity;
    }

    /// <summary>
    /// Update domain values
    /// </summary>
    /// <param name="monthsId"></param>
    /// <param name="projectedInvestmentCapacity"></param>
    /// <param name="reliazedInvestmentCapacity"></param>
    public void update(int monthsId, double projectedInvestmentCapacity, double reliazedInvestmentCapacity)
    {
        validateDomain(monthsId, projectedInvestmentCapacity, reliazedInvestmentCapacity);
    }

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
