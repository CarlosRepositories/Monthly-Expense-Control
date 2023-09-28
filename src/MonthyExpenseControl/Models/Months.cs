using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Models
{
    /// <summary>
    /// Represents a Month
    /// </summary>
    public class Months
    {
        /// <summary>
        /// Number that represent a month
        /// </summary>
        [Required]        
        public int MonthsId { get; set; }

        /// <summary>
        /// Month Name
        /// </summary>
        [Required]
        public string MonthName { get; set; }        

    }
}
