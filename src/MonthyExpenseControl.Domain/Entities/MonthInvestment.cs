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
    /// Type of investment.
    /// </summary>
    public string TypeOfInvestment { get; private set; }

    /// <summary>
    /// The percentage invested related to the salary amount for example 0.10.
    /// </summary>
    public double InvestmentPercentage { get; private set; } = 0.00;

    /// <summary>
    /// Class constructor
    /// </summary>
    /// <param name="investmentAmount"></param>
    /// <param name="typeOfInvestment"></param>
    /// <param name="investmentPercentage"></param>
    /// <param name="monthsId"></param>
    public MonthInvestment(int monthInvestmentId, double investmentAmount, string typeOfInvestment, 
                           double investmentPercentage, int monthsId)
    {
        DomainExceptionValidation.when(monthInvestmentId < 0, "Value cannot be less than zero.");
        MonthInvestmentId = monthInvestmentId;
        validateDomain(investmentAmount, typeOfInvestment, investmentPercentage, monthsId);
    }

    /// <summary>
    /// Class constructor
    /// </summary>
    /// <param name="investmentAmount"></param>
    /// <param name="typeOfInvestment"></param>
    /// <param name="investmentPercentage"></param>
    /// <param name="monthsId"></param>
    public MonthInvestment(double investmentAmount, string typeOfInvestment,
                           double investmentPercentage, int monthsId)
    {
        validateDomain(investmentAmount, typeOfInvestment, investmentPercentage, monthsId);
    }

    private void validateDomain(double investmentAmount, string typeOfInvestment, 
                                double investmentPercentage, int monthsId)
    {
        DomainExceptionValidation.when(investmentAmount < 0, "Value can't be less then zero.");
        DomainExceptionValidation.when(string.IsNullOrEmpty(typeOfInvestment), "Value cannot be null or empty.");
        DomainExceptionValidation.when(investmentPercentage < 0, "Value cannot be null or empty.");
        DomainExceptionValidation.when(monthsId < 0, "Value can't be less then zero.");

        InvestmentAmount = investmentAmount;
        TypeOfInvestment = typeOfInvestment;
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

    private void update(double investmentAmount, string typeOfInvestment,
                           double investmentPercentage, int monthsId)
    {
        validateDomain(investmentAmount, typeOfInvestment, investmentPercentage, monthsId);
    }
}
