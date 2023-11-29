using MonthyExpenseControl.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Application.DTOs;

/// <summary>
/// Used to transferer Expense Objects
/// </summary>
public class ExpenseDTO
{
    /// <summary>
    /// Expense sequential Id
    /// </summary>
    public int ExpenseId { get; set; }

    /// <summary>
    /// Expense description.
    /// </summary>
    [Required]
    [MaxLength(40, ErrorMessage = "A descrição deve ter no máximo 40 caracteres")]
    public string Description { get; set; }

    /// <summary>
    /// Projected Expense value.
    /// </summary>
    public double ProjectedExpense { get; set; }

    /// <summary>
    /// Realized Expense value.
    /// </summary>
    public double RealizedExpense { get; set; }

    /// <summary>
    /// Number that represent the month
    /// when the expense happened
    /// </summary>
    [Required]
    public int MonthsId { get; set; }

    /// <summary>
    /// Complete month description
    /// </summary>        
    public Months MonthDescription { get; set; }
}
