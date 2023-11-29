namespace MonthyExpenseControl.Application.DTOs;

/// <summary>
/// Used to transferer LastYearInvestment Objects
/// </summary>
public class LastYearInvestmentDTO
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
}
