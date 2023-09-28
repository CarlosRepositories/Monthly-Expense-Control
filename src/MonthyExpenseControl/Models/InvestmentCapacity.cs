namespace MonthyExpenseControl.Models
{
    /// <summary>
    /// Represents monthly investment capacity
    /// </summary>
    public class InvestmentCapacity
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
        /// Projected investment capacity.
        /// </summary>
        public double ProjectedInvestmentCapacity { get; set; } = 0.00;

        /// <summary>
        /// Incurred investment capacity 
        /// </summary>
        public double IncurredInvestmentCapacity { get; set; } = 0.00;
    }
}
