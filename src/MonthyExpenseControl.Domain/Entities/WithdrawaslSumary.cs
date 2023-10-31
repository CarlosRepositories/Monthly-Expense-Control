using MonthyExpenseControl.Domain.Validation;
using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Domain.Entities;

/// <summary>
/// Represent the WithDrawal sumaries per month
/// </summary>
public sealed class WithdrawalSummary
{

    /// <summary>
    /// Withdrawal Summary sequential Id
    /// </summary>
    public int WithdrawalSummaryId { get; private set; }

    /// <summary>
    /// Class constructor
    /// </summary>
    /// <param name="monthlyWithDrawalTotal"></param>
    public WithdrawalSummary(double monthlyWithDrawalTotal)
    {
        MonthlyWithdrawalTotal = monthlyWithDrawalTotal;
    }

    /// <summary>
    /// Class constructor
    /// </summary>
    /// <param name="monthlyWithDrawalTotal"></param>
    public WithdrawalSummary(int withdrawalSummaryId, double monthlyWithDrawalTotal)
    {
        DomainExceptionValidation.when(withdrawalSummaryId < 0, "Value cannot be less than zero.");
        DomainExceptionValidation.when(MonthlyWithdrawalTotal < 0, "Value cannot be less than zero.");
        WithdrawalSummaryId = withdrawalSummaryId;
        MonthlyWithdrawalTotal = monthlyWithDrawalTotal;
    }

    /// <summary>
    /// Contains the monthly withdrawal total value
    /// </summary>
    public double MonthlyWithdrawalTotal { get; private set; }

    /// <summary>
    /// Number that represent the month
    /// when the expense happened
    /// </summary>
    [Required]
    public int MonthsId { get; private set; }

    /// <summary>
    /// Complete month description
    /// </summary>        
    public Months MonthDescription { get; private set; }

}
