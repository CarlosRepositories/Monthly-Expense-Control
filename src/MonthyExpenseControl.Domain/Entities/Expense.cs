using MonthyExpenseControl.Domain.Validation;
using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Domain.Entities;

/// <summary>
/// Represents a expense.
/// </summary>
public sealed class Expense
{
    /// <summary>
    /// Expense sequential Id
    /// </summary>
    public int ExpenseId { get; private set; }

    /// <summary>
    /// Expense description.
    /// </summary>
    [Required]
    [MaxLength(40, ErrorMessage = "A descrição deve ter no máximo 40 caracteres")]
    public string Description { get; private set; }

    /// <summary>
    /// Projected Expense value.
    /// </summary>
    public double ProjectedExpense { get; private set; } = 0.00;

    /// <summary>
    /// Realized Expense value.
    /// </summary>
    public double RealizedExpense { get; private set; } = 0.00;

    /// <summary>
    /// Class constructor
    /// </summary>
    /// <param name="monthsId"></param>
    /// <param name="expenseId"></param>
    /// <param name="description"></param>
    /// <param name="projectedExpense"></param>
    /// <param name="realizedExpense"></param>
    public Expense(int expenseId, int monthsId, string description,
               double projectedExpense, double realizedExpense)
    {
        DomainExceptionValidation.when(expenseId < 0, "Value cannot be less than zero.");
        ExpenseId = expenseId;
        ValidateDomain(monthsId, description, projectedExpense, realizedExpense);
    }

    /// <summary>
    /// Class constructor
    /// </summary>
    /// <param name="monthsId"></param>
    /// <param name="description"></param>
    /// <param name="projectedExpense"></param>
    /// <param name="realizedExpense"></param>
    public Expense(int monthsId, string description,
                   double projectedExpense, double realizedExpense)
    {
        ValidateDomain(monthsId, description, projectedExpense, realizedExpense);
    }

    /// <summary>    
    /// Validates domain values
    /// according to business rules    
    /// </summary>
    /// <param name="monthsId"></param>
    /// <param name="description"></param>
    /// <param name="projectedExpense"></param>
    /// <param name="realizedExpense"></param>
    private void ValidateDomain(int monthsId, string description,
                   double projectedExpense, double realizedExpense)
    {
        DomainExceptionValidation.when(monthsId < 0,
            "Invalid Id value.");
        DomainExceptionValidation.when(string.IsNullOrEmpty(description),
            "Invalid description: cannot be null or empty.");
        DomainExceptionValidation.when(projectedExpense < 0,
            "Projected expense cannot be less than 0");
        DomainExceptionValidation.when(realizedExpense < 0,
            "Realized expense cannot be less than 0");

        MonthsId = monthsId;
        Description = description;
        ProjectedExpense = projectedExpense;
        RealizedExpense = realizedExpense;
    }

    /// <summary>
    /// update domain values
    /// </summary>
    /// <param name="monthsId"></param>
    /// <param name="description"></param>
    /// <param name="projectedExpense"></param>
    /// <param name="realizedExpense"></param>
    public void update(int monthsId, string description,
                   double projectedExpense, double realizedExpense)
    {
        ValidateDomain(monthsId, description, projectedExpense, realizedExpense);
    }

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
