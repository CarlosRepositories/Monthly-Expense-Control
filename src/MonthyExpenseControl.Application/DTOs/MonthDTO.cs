using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Application.DTOs;

/// <summary>
/// Used to transferer Month Objects
/// </summary>
public class MonthDTO
{
    /// <summary>
    /// Number that represent a month
    /// </summary>
    [Required]
    public int MonthsId { get; set; }

    /// <summary>
    /// Month Name
    /// </summary>
    [Required]
    public string MonthName { get; set; }
}
