using MonthyExpenseControl.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthyExpenseControl.Application.Interfaces
{
    public interface IInvestmentStatementService
    {
        IEnumerable<MonthInvestmentDTO> GetMonthlyInvestments();
    }
}
