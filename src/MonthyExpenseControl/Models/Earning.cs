using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Models
{
    /// <summary>
    /// Represents a earning.
    /// </summary>
    public class Earning
    {
        /// <summary>
        /// Number that represent the month
        /// when the earning happened
        /// </summary>
        public int MonthId { get; set; }

        /// <summary>
        /// Complete month description
        /// </summary>        
        public virtual Months MonthDescription { get; set; }

        /// <summary>
        /// Projected Earning value.
        /// </summary>
        public double ProjectedEarning { get; set; } = 0.00;

        /// <summary>
        /// Incurred Earning value.
        /// </summary>
        public double IncurredEarning { get; set; } = 0.00;
    }
}
