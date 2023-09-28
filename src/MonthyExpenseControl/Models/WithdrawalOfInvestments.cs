using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Models
{
    /// <summary>
    /// Represents monthly Withdraw of the investments
    /// </summary>
    public class WithdrawalOfInvestments
    {
        /// <summary>
        /// Sequential Id
        /// </summary>
        public int WithdrawalOfInvestmentsId { get; set; }

        /// <summary>
        /// Number that represent the month        
        /// </summary>
        [Required]
        public int MonthId { get; set; }

        /// <summary>
        /// Month that the withdrawal happened.
        /// </summary>
        public virtual Months Month { get; set; }        

        /// <summary>
        /// Withdraw description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Amount that was withdrawn.
        /// </summary>
        public double WithDrawalValue { get; set; }
    }
}
