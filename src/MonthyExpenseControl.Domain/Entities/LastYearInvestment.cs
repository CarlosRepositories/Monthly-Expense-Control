using MonthyExpenseControl.Domain.Validation;

namespace MonthyExpenseControl.Domain.Entities;

/// <summary>
/// Total last year invested    
/// </summary>
public sealed class LastYearInvestment
{
    /// <summary>
    /// Amount invested last Year
    /// </summary>
    public double TotalInvestedLastYear { get; private set; }

    public LastYearInvestment(double totalInvestedLastYear)
    {
        validateDomain(totalInvestedLastYear);

    }

    /// <summary>
    /// Validates domain values
    /// according to business rules
    /// </summary>
    /// <param name="totalInvestmentLastYear">Amount invested last Year</param>
    private void validateDomain(double totalInvestedLastYear)
    {
        DomainExceptionValidation.when(totalInvestedLastYear < 0, "Value cannot be less than zero.");
        TotalInvestedLastYear = totalInvestedLastYear;
    }

    /// <summary>
    /// Update domain values
    /// </summary>
    /// <param name="totalInvestimentLastYear"></param>
    public void update(double totalInvestimentLastYear)
    {
        validateDomain(totalInvestimentLastYear);
    }
}
