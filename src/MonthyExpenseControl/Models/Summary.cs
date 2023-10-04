using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Models
{
    /// <summary>
    /// Monthly sumary of Total earnings and Expenses.
    /// </summary>
    public class Summary
    {
        /// <summary>
        /// Sumary sequential Id
        /// </summary>
        public int SummaryId { get; set; }

        /// <summary>
        /// Number that represent the month        
        /// </summary>
        [Required]
        public int MonthId { get; set; }

        /// <summary>
        /// Complete month description
        /// </summary>        
        public virtual Months MonthDescription { get; set; }

        /// <summary>
        /// Total projected earnings.
        /// </summary>
        public double TotalProjectedEarnings { get; set; } = 0.00;

        /// <summary>
        /// Total projected Earning.
        /// </summary>
        public double TotalProjectedExpenses { get; set; } = 0.00;

        /// <summary>
        /// Total projected earnings.
        /// </summary>
        public double TotalRealizedEarnings { get; set; } = 0.00;

        /// <summary>
        /// Total projected Earning.
        /// </summary>
        public double TotalRealizedExpenses { get; set; } = 0.00;

        /// <summary>
        /// Total Projected Investment Capacity.
        /// </summary>
        public double TotalProjectedInvestmentCapacity { get; set; } = 0.00;

        /// <summary>
        /// Total Projected Investment Capacity.
        /// </summary>
        public double TotalRealizedInvestmentCapacity { get; set; } = 0.00;
    }
}
