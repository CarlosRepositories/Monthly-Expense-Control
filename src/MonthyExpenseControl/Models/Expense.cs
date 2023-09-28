using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Models
{
    /// <summary>
    /// Represents a expense.
    /// </summary>
    public class Expense
    {
        /// <summary>
        /// Expense sequential Id
        /// </summary>
        public int ExpenseId { get; set; }

        /// <summary>
        /// Number that represent the month
        /// when the expense happened
        /// </summary>
        [Required]
        public int MonthsId { get; set; }

        /// <summary>
        /// Complete month description
        /// </summary>        
        public virtual Months MonthDescription { get; set; }

        /// <summary>
        /// Expense description.
        /// </summary>
        [Required]
        [MaxLength(40, ErrorMessage = "A descrição deve ter no máximo 40 caracteres")]
        public string Description { get; set; }

        /// <summary>
        /// Projected Expense value.
        /// </summary>
        public double ProjectedExpense { get; set; } = 0.00;

        /// <summary>
        /// Incurred Expense value.
        /// </summary>
        public double IncurredExpense { get; set; } = 0.00;
    }
}
