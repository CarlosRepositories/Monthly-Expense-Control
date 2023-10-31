using MonthyExpenseControl.Domain.Validation;
using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Domain.Entities;

/// <summary>
/// Represents monthly Withdraw of the investments
/// </summary>
public sealed class WithdrawalOfInvestments
{
    /// <summary>
    /// Sequential Id
    /// </summary>
    public int WithdrawalOfInvestmentsId { get; private set; }

    /// <summary>
    /// Withdraw description.
    /// </summary>
    public string Description { get; private set; }

    /// <summary>
    /// Amount that was withdrawn.
    /// </summary>
    public double WithDrawalValue { get; private set; }

    /// <summary>
    /// class contructor
    /// </summary>
    /// <param name="description"></param>
    /// <param name="withdrawalvalue"></param>
    public WithdrawalOfInvestments(string description, double withdrawalvalue)
    {
        ValidationDomain(description, withdrawalvalue);
    }

    /// <summary>
    /// class contructor
    /// </summary>
    /// <param name="description"></param>
    /// <param name="withdrawalvalue"></param>
    public WithdrawalOfInvestments(int withdrawalOfInvestmentsId, string description, double withdrawalvalue)
    {
        DomainExceptionValidation.when(withdrawalOfInvestmentsId < 0, "Value cannot be less than zero.");
        WithdrawalOfInvestmentsId = withdrawalOfInvestmentsId;
        ValidationDomain(description, withdrawalvalue);
    }
    private void ValidationDomain(string description, double withdrawalvalue)
    {
        DomainExceptionValidation.when(string.IsNullOrEmpty(description), "Value cannot be null.");
        DomainExceptionValidation.when(withdrawalvalue < 0, "Value cannot be less than zero.");
        Description = description;
        WithDrawalValue = withdrawalvalue;
    }

    private void Update(string description, double withdrawalvalue)
    {
        ValidationDomain(description, withdrawalvalue);
    }

    /// <summary>
    /// Number that represent the month        
    /// </summary>
    [Required]
    public int MonthId { get; private set; }

    /// <summary>
    /// Month that the withdrawal happened.
    /// </summary>
    public Months Month { get; private set; }
}
