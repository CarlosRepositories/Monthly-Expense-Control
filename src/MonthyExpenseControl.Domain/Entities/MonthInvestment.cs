using MonthyExpenseControl.Domain.Validation;
using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Domain.Entities;

/// <summary>
/// Monthly investment summary.
/// </summary>
public sealed class MonthInvestment
{
    /// <summary>
    /// Month Investment sequential Id
    /// </summary>
    public int MonthInvestmentId { get; private set; }

    /// <summary>
    /// The amount invested.
    /// </summary>
    public double InvestmentAmount { get; private set; } = 0.00;

    /// <summary>
    /// The percentage invested related to the salary amount for example 0.10.
    /// </summary>
    public double InvestmentPercentage { get; private set; } = 0.00;

    /// <summary>
    /// Class constructor
    /// </summary>
    /// <param name="investmentAmount"></param>    
    /// <param name="investmentPercentage"></param>
    /// <param name="monthsId"></param>
    public MonthInvestment(int monthInvestmentId, double investmentAmount, 
                           double investmentPercentage, int monthsId)
    {
        DomainExceptionValidation.when(monthInvestmentId < 0, "Value cannot be less than zero.");
        MonthInvestmentId = monthInvestmentId;
        validateDomain(investmentAmount, investmentPercentage, monthsId);
    }

    /// <summary>
    /// Class constructor
    /// </summary>
    /// <param name="investmentAmount"></param>    
    /// <param name="investmentPercentage"></param>
    /// <param name="monthsId"></param>
    public MonthInvestment(double investmentAmount,
                           double investmentPercentage, int monthsId)
    {
        validateDomain(investmentAmount, investmentPercentage, monthsId);
    }

    private void validateDomain(double investmentAmount,
                                double investmentPercentage, int monthsId)
    {
        DomainExceptionValidation.when(investmentAmount < 0, "Value can't be less then zero.");        
        DomainExceptionValidation.when(investmentPercentage < 0, "Value cannot be null or empty.");
        DomainExceptionValidation.when(monthsId < 0, "Value can't be less then zero.");

        InvestmentAmount = investmentAmount;
        InvestmentPercentage = investmentPercentage;
        MonthsId = monthsId;
    }

    /// <summary>
    /// Number that represent the month        
    /// </summary>
    [Required]
    public int MonthsId { get; private set; }

    /// <summary>
    /// Month that the investment happened.
    /// </summary>
    public Months Month { get; private set; }

    private void update(double investmentAmount,
                           double investmentPercentage, int monthsId)
    {
        validateDomain(investmentAmount, investmentPercentage, monthsId);
    }
}
