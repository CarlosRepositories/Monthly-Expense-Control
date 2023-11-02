using MonthyExpenseControl.Domain.Validation;

namespace MonthyExpenseControl.Domain.Entities;

/// <summary>
/// Total last year invested    
/// </summary>
public sealed class LastYearInvestment
{
    /// <summary>
    /// Sequential Id
    /// </summary>
    public int LatestYearId { get; set; }

    /// <summary>
    /// Amount invested last Year
    /// </summary>
    public double TotalInvestedLastYear { get; private set; }

    /// <summary>
    /// year when the investment was accumulated
    /// </summary>
    public int Year { get; private set; }

    /// <summary>
    /// class constructor
    /// </summary>
    /// <param name="totalInvestedLastYear"></param>

    public LastYearInvestment(int latestYearId, double totalInvestedLastYear, int year)
    {
        DomainExceptionValidation.when(latestYearId < 0, "Value cannot be less than zero.");
        LatestYearId = latestYearId;
        validateDomain(totalInvestedLastYear, year);

    }

    /// <summary>
    /// Validates domain values
    /// according to business rules
    /// </summary>
    /// <param name="totalInvestmentLastYear">Amount invested last Year</param>
    private void validateDomain(double totalInvestedLastYear, int year)
    {
        DomainExceptionValidation.when(totalInvestedLastYear < 0, "Value cannot be less than zero.");
        var currentYear = DateTime.Now.Year;
        DomainExceptionValidation.when(year >= currentYear, "Parameter year cannot be bigger than current year.");
        TotalInvestedLastYear = totalInvestedLastYear;
        Year = year;
    }

    /// <summary>
    /// Update domain values
    /// </summary>
    /// <param name="totalInvestimentLastYear"></param>
    public void update(double totalInvestimentLastYear, int year)
    {
        validateDomain(totalInvestimentLastYear, year);
    }
}
