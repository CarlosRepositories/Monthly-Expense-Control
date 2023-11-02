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
    [MaxLength(40, ErrorMessage = "A descrição deve ter no máximo 40 caracteres")]
    public string Description { get; private set; }

    /// <summary>
    /// Amount that was withdrawn.
    /// </summary>
    public double WithDrawalValue { get; private set; }

    /// <summary>
    /// class contructor
    /// </summary>
    /// <param name="description"></param>
    /// <param name="withDrawalValue"></param>
    public WithdrawalOfInvestments(string description, double withDrawalValue)
    {
        ValidationDomain(description, withDrawalValue);
    }

    /// <summary>
    /// class contructor
    /// </summary>
    /// <param name="description"></param>
    /// <param name="withDrawalValue"></param>
    public WithdrawalOfInvestments(int withdrawalOfInvestmentsId, string description, double withDrawalValue)
    {
        DomainExceptionValidation.when(withdrawalOfInvestmentsId < 0, "Value cannot be less than zero.");
        WithdrawalOfInvestmentsId = withdrawalOfInvestmentsId;
        ValidationDomain(description, withDrawalValue);
    }
    private void ValidationDomain(string description, double withDrawalValue)
    {
        DomainExceptionValidation.when(string.IsNullOrEmpty(description), "Value cannot be null.");
        DomainExceptionValidation.when(withDrawalValue < 0, "Value cannot be less than zero.");
        Description = description;
        WithDrawalValue = withDrawalValue;
    }

    private void Update(string description, double withDrawalValue)
    {
        ValidationDomain(description, withDrawalValue);
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
