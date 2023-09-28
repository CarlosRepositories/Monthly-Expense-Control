using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Models
{
    /// <summary>
    /// Monthly sumary of Total earnings and Expenses.
    /// </summary>
    public class Sumary
    {
        /// <summary>
        /// Sumary sequential Id
        /// </summary>
        public int SumaryId { get; set; }

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
        /// Total earnings.
        /// </summary>
        public double Earnings { get; set; } = 0.00;

        /// <summary>
        /// Total Earning.
        /// </summary>
        public double Expenses { get; set; } = 0.00;

        /// <summary>
        /// Total Investment Capacity.
        /// </summary>
        public double InvestmentCapacity { get; set; } = 0.00;
    }
}
