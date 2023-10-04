using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Models
{
    /// <summary>
    /// Represent
    /// </summary>
    public class WithdrawalSummary
    {

        /// <summary>
        /// Withdrawal Summary sequential Id
        /// </summary>
        public int WithdrawalSummaryId { get; set; }

        /// <summary>
        /// Number that represent the month
        /// when the expense happened
        /// </summary>
        [Required]
        public int MonthsId { get; set; }

        /// <summary>
        /// Complete month description
        /// </summary>        
        public virtual Months MonthDescription { get; set; }

        /// <summary>
        /// Contains the monthly withdrawal total value
        /// </summary>
        public double MonthlyWithdrawalTotal { get; set; }

    }
}
