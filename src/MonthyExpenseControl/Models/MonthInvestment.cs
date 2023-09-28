namespace MonthyExpenseControl.Models
{
    /// <summary>
    /// Monthly investment summary.
    /// </summary>
    public class MonthInvestment
    {
        /// <summary>
        /// Number that represent the month        
        /// </summary>
        public int MonthId { get; set; }

        /// <summary>
        /// Month that the investment happened.
        /// </summary>
        public virtual Months Month { get; set; }

        /// <summary>
        /// The amount invested.
        /// </summary>
        public double InvestmentAmount { get; set; }

        /// <summary>
        /// Type of investment.
        /// </summary>
        public string TypeOfInvestment { get; set; }

        /// <summary>
        /// The percentage invested related to the salary amount for example 0.10.
        /// </summary>
        public double InvestmentPercentage { get; set; }
    }
}
