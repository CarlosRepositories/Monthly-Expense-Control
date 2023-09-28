using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Models
{
    /// <summary>
    /// Monthly investment summary.
    /// </summary>
    public class MonthInvestment
    {
        /// <summary>
        /// Month Investment sequential Id
        /// </summary>
        public int MonthInvestmentId { get; set; }

        /// <summary>
        /// Number that represent the month        
        /// </summary>
        [Required]
        public int MonthsId { get; set; }

        /// <summary>
        /// Month that the investment happened.
        /// </summary>
        public virtual Months Month { get; set; }

        /// <summary>
        /// The amount invested.
        /// </summary>
        public double InvestmentAmount { get; set; } = 0.00;

        /// <summary>
        /// Type of investment.
        /// </summary>
        public string TypeOfInvestment { get; set; }

        /// <summary>
        /// The percentage invested related to the salary amount for example 0.10.
        /// </summary>
        public double InvestmentPercentage { get; set; } = 0.00;
    }
}
