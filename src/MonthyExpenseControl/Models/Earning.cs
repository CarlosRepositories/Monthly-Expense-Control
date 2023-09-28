using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MonthyExpenseControl.Models
{
    /// <summary>
    /// Represents a earning.
    /// </summary>
    public class Earning
    {
        /// <summary>
        /// Earning sequential Id
        /// </summary>
        public int EarningId { get; set; }

        /// <summary>
        /// Number that represent the month
        /// when the earning happened
        /// </summary>
        [Required]
        public int MonthsId { get; set; }

        /// <summary>
        /// Complete month description
        /// </summary>        
        public virtual Months MonthDescription { get; set; }

        /// <summary>
        /// Earning description.
        /// </summary>        
        [Required]
        [MaxLength(40, ErrorMessage = "A descrição deve ter no máximo 40 caracteres")]
        public string Description { get; set; }

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
