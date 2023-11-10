using MonthyExpenseControl.Domain.Validation;
using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Domain.Entities;

/// <summary>
/// Represents a Month
/// </summary>
public sealed class Months
{
    /// <summary>
    /// Number that represent a month
    /// </summary>
    [Required]        
    public int MonthsId { get; private set; }

    /// <summary>
    /// Month Name
    /// </summary>
    [Required]
    public string MonthName { get; private set; }

    /// <summary>
    /// Class constructor
    /// </summary>
    /// <param name="monthsId"></param>
    /// <param name="monthName"></param>
    public Months(int monthsId, string monthName)
    {
        ValidateDomain(monthsId, monthName);
    }

    private void ValidateDomain(int monthsId, string monthName)
    {
        DomainExceptionValidation.when(monthsId < 0, "Value cannot be less than zero.");
        DomainExceptionValidation.when(string.IsNullOrEmpty(monthName), "Value cannot be null or empty.");

        MonthsId = monthsId;
        MonthName = monthName;
    }
}
