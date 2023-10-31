using MonthyExpenseControl.Domain.Validation;
using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Domain.Entities;

/// <summary>
/// Monthly sumary of Total earnings and Expenses.
/// </summary>
public sealed class Summary
{
    /// <summary>
    /// Sumary sequential Id
    /// </summary>
    public int SummaryId { get; private set; }

    /// <summary>
    /// Total projected earnings.
    /// </summary>
    public double TotalProjectedEarnings { get; private set; } = 0.00;

    /// <summary>
    /// Total projected Earning.
    /// </summary>
    public double TotalProjectedExpenses { get; private set; } = 0.00;

    /// <summary>
    /// Total projected earnings.
    /// </summary>
    public double TotalRealizedEarnings { get; private set; } = 0.00;

    /// <summary>
    /// Total projected Earning.
    /// </summary>
    public double TotalRealizedExpenses { get; private set; } = 0.00;

    /// <summary>
    /// Total Projected Investment Capacity.
    /// </summary>
    public double TotalProjectedInvestmentCapacity { get; private set; } = 0.00;

    /// <summary>
    /// Total Projected Investment Capacity.
    /// </summary>
    public double TotalRealizedInvestmentCapacity { get; private set; } = 0.00;

    /// <summary>
    /// Class constructor
    /// </summary>
    /// <param name="totalProjectedEarnings"></param>
    /// <param name="totalProjectedExpenses"></param>
    /// <param name="totalRealizedEarnings"></param>
    /// <param name="totalRealizedExpenses"></param>
    /// <param name="totalProjectedInvestmentCapacity"></param>
    /// <param name="totalRealizedInvestmentCapacity"></param>
    /// <param name="monthId"></param>
    public Summary(int summaryId, double totalProjectedEarnings, double totalProjectedExpenses,
                   double totalRealizedEarnings, double totalRealizedExpenses,
                   double totalProjectedInvestmentCapacity, double totalRealizedInvestmentCapacity,
                   int monthId)
    {
        DomainExceptionValidation.when(summaryId < 0, "Value cannot be less than zero.");
        SummaryId = summaryId;
        ValidateDomain(totalProjectedEarnings, totalProjectedExpenses,
                       totalRealizedEarnings, totalRealizedExpenses,
                       totalProjectedInvestmentCapacity, totalRealizedInvestmentCapacity,
                       monthId);
    }

    /// <summary>
    /// Class constructor
    /// </summary>
    /// <param name="totalProjectedEarnings"></param>
    /// <param name="totalProjectedExpenses"></param>
    /// <param name="totalRealizedEarnings"></param>
    /// <param name="totalRealizedExpenses"></param>
    /// <param name="totalProjectedInvestmentCapacity"></param>
    /// <param name="totalRealizedInvestmentCapacity"></param>
    /// <param name="monthId"></param>
    public Summary(double totalProjectedEarnings, double totalProjectedExpenses,
                   double totalRealizedEarnings, double totalRealizedExpenses,
                   double totalProjectedInvestmentCapacity, double totalRealizedInvestmentCapacity,
                   int monthId)
    {
        ValidateDomain(totalProjectedEarnings, totalProjectedExpenses,
                       totalRealizedEarnings, totalRealizedExpenses,
                       totalProjectedInvestmentCapacity, totalRealizedInvestmentCapacity,
                       monthId);
    }

    /// <summary>
    /// Validate Summary properties
    /// </summary>
    /// <param name="totalProjectedEarnings"></param>
    /// <param name="totalProjectedExpenses"></param>
    /// <param name="totalRealizedEarnings"></param>
    /// <param name="totalRealizedExpenses"></param>
    /// <param name="totalProjectedInvestmentCapacity"></param>
    /// <param name="totalRealizedInvestmentCapacity"></param>
    /// <param name="monthId"></param>
    private void ValidateDomain(double totalProjectedEarnings, double totalProjectedExpenses,
                   double totalRealizedEarnings, double totalRealizedExpenses,
                   double totalProjectedInvestmentCapacity, double totalRealizedInvestmentCapacity,
                   int monthId)
    {
        DomainExceptionValidation.when(totalProjectedEarnings < 0, "Value cannot be less than zero");
        DomainExceptionValidation.when(totalProjectedExpenses < 0, "Value cannot be less than zero");
        DomainExceptionValidation.when(totalRealizedEarnings < 0, "Value cannot be less than zero");
        DomainExceptionValidation.when(totalRealizedExpenses < 0, "Value cannot be less than zero");
        DomainExceptionValidation.when(totalProjectedInvestmentCapacity < 0, "Value cannot be less than zero");
        DomainExceptionValidation.when(totalRealizedInvestmentCapacity < 0, "Value cannot be less than zero");
        DomainExceptionValidation.when(monthId < 0, "Value cannot be less than zero");

        TotalProjectedEarnings = totalProjectedEarnings;
        TotalProjectedExpenses = totalProjectedExpenses;
        TotalRealizedEarnings = totalRealizedEarnings;
        TotalRealizedExpenses = totalRealizedExpenses;
        TotalProjectedInvestmentCapacity = totalProjectedInvestmentCapacity;
        TotalRealizedInvestmentCapacity = totalRealizedInvestmentCapacity;
        MonthId = monthId;
    }

    /// <summary>
    /// Update Summary properties
    /// </summary>
    /// <param name="totalProjectedEarnings"></param>
    /// <param name="totalProjectedExpenses"></param>
    /// <param name="totalRealizedEarnings"></param>
    /// <param name="totalRealizedExpenses"></param>
    /// <param name="totalProjectedInvestmentCapacity"></param>
    /// <param name="totalRealizedInvestmentCapacity"></param>
    /// <param name="monthId"></param>
    private void Update(double totalProjectedEarnings, double totalProjectedExpenses,
               double totalRealizedEarnings, double totalRealizedExpenses,
               double totalProjectedInvestmentCapacity, double totalRealizedInvestmentCapacity,
               int monthId)
    {
        ValidateDomain(totalProjectedEarnings, totalProjectedExpenses,
                       totalRealizedEarnings, totalRealizedExpenses,
                       totalProjectedInvestmentCapacity, totalRealizedInvestmentCapacity,
                       monthId);
    }

    /// <summary>
    /// Number that represent the month        
    /// </summary>
    [Required]
    public int MonthId { get; private set; }

    /// <summary>
    /// Complete month description
    /// </summary>        
    public Months MonthDescription { get; private set; }
}
