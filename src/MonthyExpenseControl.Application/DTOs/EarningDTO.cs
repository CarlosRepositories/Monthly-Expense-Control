using MonthyExpenseControl.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Application.DTOs;

/// <summary>
/// Used to transferer Earning Objects
/// </summary>
public class EarningDTO
{
    /// <summary>
    /// Earning sequential Id
    /// </summary>
    public int EarningId { get; set; }

    /// <summary>
    /// Earning description.
    /// </summary>        
    [Required]
    [MaxLength(40, ErrorMessage = "A descrição deve ter no máximo 40 caracteres")]
    public string Description { get; set; }

    /// <summary>
    /// Projected Earning value.
    /// </summary>        

    public double ProjectedEarning { get; set; }

    /// <summary>
    /// Realized Earning value.
    /// </summary>        
    public double RealizedEarning { get; set; }

    /// <summary>
    /// Number that represent the month
    /// when the earning happened
    /// </summary>
    [Required]
    public int MonthsId { get; set; }

    /// <summary>
    /// Complete month description
    /// </summary>        
    public Months MonthDescription { get; set; }
}
