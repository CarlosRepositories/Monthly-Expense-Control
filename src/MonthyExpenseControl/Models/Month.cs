using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Models
{
    /// <summary>
    /// All description and values
    /// related to expenses and earnings, considering projected
    /// and realized.
    /// </summary>
    public class Month
    {

        /// <summary>
        /// Number that represent a month
        /// </summary>
        public int MonthId { get; set; }

        /// <summary>
        /// The Month Name.
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
        public Sumary SumaryOfTheMonth { get; set; }
    }
}
