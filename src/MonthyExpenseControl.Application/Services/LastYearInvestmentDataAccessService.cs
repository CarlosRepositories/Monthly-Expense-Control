using AutoMapper;
using MonthyExpenseControl.Application.DTOs;
using MonthyExpenseControl.Application.Interfaces;
using MonthyExpenseControl.Domain.Entities;
using MonthyExpenseControl.Domain.Interfaces;

namespace MonthyExpenseControl.Application.Services;

public class LastYearInvestmentDataAccessService : ILastYearInvestmentService
{
    private readonly ILastYearInvestmentRepository Repository;
    private readonly IMapper Mapper;
    public LastYearInvestmentDataAccessService(ILastYearInvestmentRepository repository,
                                    IMapper mapper) 
    {
        Repository = repository;
        Mapper = mapper;
    }
    public async Task AddLastYearInvestmentAsync(LastYearInvestmentDTO investmentDto)
    {
            var investment = Mapper.Map<LastYearInvestment>(investmentDto);
            await Repository.CreateLastYearInvestmentAsync(investment);
    }

    public async Task<IEnumerable<LastYearInvestmentDTO>> GetLastYearInvestmentAsync()
    {
        var investments = await Repository.GetAllAnnualInvestment();
        return Mapper.Map<IEnumerable<LastYearInvestmentDTO>>(investments);
    }

    public async Task<LastYearInvestmentDTO> GetLastYearInvestmentByIdAsync(int id)
    {
        var investment = await Repository.GetLastYearInvestmentAsync();
        return Mapper.Map<LastYearInvestmentDTO>(investment);
    }

    public async Task RemoveLastYearInvestmentAsync(LastYearInvestmentDTO investmentDto)
    {
        var investment = Mapper.Map<LastYearInvestment>(investmentDto);
        await Repository.RemoveExpensesAsync(investment);
    }

    public async Task UpdateLastYearInvestmentAsync(LastYearInvestmentDTO investmentDto)
    {
        var investment = Mapper.Map<LastYearInvestment>(investmentDto);
        await Repository.UpdateLastYearInvestmentAsync(investment);
    }
}
