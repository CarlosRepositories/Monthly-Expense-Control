namespace MonthyExpenseControl.Models
{
    /// <summary>
    /// Represents a expense.
    /// </summary>
    public class Expense
    {
        /// <summary>
        /// Number that represent the month
        /// when the expense happened
        /// </summary>
        public int MonthId { get; set; }

        /// <summary>
        /// Complete month description
        /// </summary>        
        public virtual Months MonthDescription { get; set; }

        /// <summary>
        /// Expense description.
        /// </summary>
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
