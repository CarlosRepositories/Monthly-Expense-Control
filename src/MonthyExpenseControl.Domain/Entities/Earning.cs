using MonthyExpenseControl.Domain.Validation;
using System.ComponentModel.DataAnnotations;

namespace MonthyExpenseControl.Domain.Entities;

/// <summary>
/// Represents a earning.
/// </summary>
public sealed class Earning
{
    /// <summary>
    /// Earning sequential Id
    /// </summary>
    public int EarningId { get; private set; }

    /// <summary>
    /// Earning description.
    /// </summary>        
    [Required]
    [MaxLength(40, ErrorMessage = "A descrição deve ter no máximo 40 caracteres")]
    public string Description { get; private set; }

    /// <summary>
    /// Projected Earning value.
    /// </summary>        

    public double ProjectedEarning { get; private set; } = 0.00;

    /// <summary>
    /// Realized Earning value.
    /// </summary>        
    public double RealizedEarning { get; private set; } = 0.00;

    /// <summary>
    /// Class constructor
    /// </summary>
    /// <param name="monthsId"></param>
    /// <param name="earningId"></param>    /// 
    /// <param name="description"></param>
    /// <param name="projectedEarning"></param>
    /// <param name="realizedEarning"></param>
    public Earning(int earningId, int monthsId, string description,
                   double projectedEarning, double realizedEarning)
    {
        DomainExceptionValidation.when(earningId < 0, "Value cannot be less than zero");
        EarningId = earningId;
        ValidateDomain(monthsId, description, projectedEarning, realizedEarning);
    }

    /// <summary>
    /// Class constructor
    /// </summary>
    /// <param name="monthsId"></param>
    /// <param name="description"></param>
    /// <param name="projectedEarning"></param>
    /// <param name="realizedEarning"></param>
    public Earning(int monthsId, string description,
                   double projectedEarning, double realizedEarning)
    {
        ValidateDomain(monthsId, description,
                        projectedEarning, realizedEarning);
    }

    /// <summary>
    /// Validates domain values
    /// according to business rules
    /// </summary>
    /// <param name="monthsId"></param>
    /// <param name="description"></param>
    /// <param name="projectedEarning"></param>
    /// <param name="realizedEarning"></param>
    private void ValidateDomain(int monthsId, string description,
                   double projectedEarning, double realizedEarning)    {
        
        DomainExceptionValidation.when(monthsId < 0, "Invalid MonthId value");
        DomainExceptionValidation.when(string.IsNullOrEmpty(description),
            "Invalid description.");
        DomainExceptionValidation.when(projectedEarning < 0,
            "Projected Earning can't be less than zero");
        DomainExceptionValidation.when(realizedEarning < 0,
            "Realized Earning can't be less than zero");
        
        MonthsId = monthsId;        
        Description = description;
        ProjectedEarning = projectedEarning;
        RealizedEarning = realizedEarning;
    }

    /// <summary>
    /// Update domain values
    /// </summary>
    /// <param name="monthsId"></param>
    /// <param name="description"></param>
    /// <param name="projectedEarning"></param>
    /// <param name="realizedEarning"></param>
    public void Update(int monthsId,string description,
                   double projectedEarning, double realizedEarning)
    {
        ValidateDomain(monthsId, description,
                        projectedEarning, realizedEarning);
    }

    /// <summary>
    /// Number that represent the month
    /// when the earning happened
    /// </summary>
    [Required]
    public int MonthsId { get; private set; }

    /// <summary>
    /// Complete month description
    /// </summary>        
    public Months MonthDescription { get; private set; }
}
