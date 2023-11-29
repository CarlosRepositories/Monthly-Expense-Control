using AutoMapper;
using MonthyExpenseControl.Application.DTOs;
using MonthyExpenseControl.Domain.Entities;

namespace MonthyExpenseControl.Application.Mappings
{
    public class DomainToDTOMappingProfiler : Profile
    {
        public DomainToDTOMappingProfiler() 
        {
            CreateMap<Earning, EarningDTO>().ReverseMap();
            CreateMap<Expense, ExpenseDTO>().ReverseMap();
            CreateMap<LastYearInvestment, LastYearInvestmentDTO>().ReverseMap();
            CreateMap<WithdrawalOfInvestments, WithdrawalOfInvestmentsDTO>().ReverseMap();
        }
    }
}
