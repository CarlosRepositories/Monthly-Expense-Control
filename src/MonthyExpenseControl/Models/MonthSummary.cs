using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Models
{
    /// <summary>
    /// All description and values
    /// related to expenses and earnings, considering projected
    /// and realized.
    /// </summary>
    public class MonthSummary
    {
        /// <summary>
        /// Month Sumary sequential Id
        /// </summary>
        public int MonthSummaryId { get; set; }

        /// <summary>
        /// Number that represent a month
        /// </summary>
        [Required]
        public int MonthsId { get; set; }

        /// <summary>
        /// Complete Month Description.
        /// </summary>
        public virtual Months MonthDescription { get; set; }

        /// <summary>
        /// Contains all earnings for a month.
        /// </summary>
        public List<Earning> MonthlyEarnings { get; set; }

        /// <summary>
        /// Contains all expenses for a month.
        /// </summary>
        public List<Expense> MonthlyExpenses { get; set; }

        /// <summary>
        /// Sumary of the month.
        /// </summary>
        public Summary SumaryOfTheMonth { get; set; }
    }
}
