using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Models
{
    /// <summary>
    /// Represents monthly investment capacity
    /// </summary>
    public class InvestmentCapacity
    {
        /// <summary>
        /// Investiment sequential Id
        /// </summary>
        public int InvestmentCapacityId { get; set; }

        /// <summary>
        /// Number that represent the month        
        /// </summary>
        [Required]
        public int MonthsId { get; set; }

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
