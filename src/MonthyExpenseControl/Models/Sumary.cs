namespace MonthyExpenseControl.Models
{
    /// <summary>
    /// Monthly sumary of Total earnings and Expenses.
    /// </summary>
    public class Sumary
    {
        /// <summary>
        /// Number that represent the month        
        /// </summary>
        public int MonthId { get; set; }

        /// <summary>
        /// Complete month description
        /// </summary>        
        public virtual Months MonthDescription { get; set; }

        /// <summary>
        /// Total earnings.
        /// </summary>
        public Earning Earnings { get; set; }

        /// <summary>
        /// Total Earning.
        /// </summary>
        public Expense Expenses { get; set; }

        /// <summary>
        /// Total Investment Capacity.
        /// </summary>
        public InvestmentCapacity InvestmentCapacity { get; set; }
    }
}
