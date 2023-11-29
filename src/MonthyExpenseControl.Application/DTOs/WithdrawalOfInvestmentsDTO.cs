using MonthyExpenseControl.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Application.DTOs;

/// <summary>
/// Used to transferer WithdrawalOfInvestments Objects
/// </summary>
public class WithdrawalOfInvestmentsDTO
{
    /// <summary>
    /// Sequential Id
    /// </summary>
    public int WithdrawalOfInvestmentsId { get; set; }

    /// <summary>
    /// Withdraw description.
    /// </summary>
    [MaxLength(40, ErrorMessage = "A descrição deve ter no máximo 40 caracteres")]
    public string Description { get; set; }

    /// <summary>
    /// Amount that was withdrawn.
    /// </summary>
    public double WithDrawalValue { get; set; }

    /// <summary>
    /// Number that represent the month        
    /// </summary>
    [Required]
    public int MonthId { get; set; }

    /// <summary>
    /// Month that the withdrawal happened.
    /// </summary>
    public Months Month { get; set; }
}
