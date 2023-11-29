using AutoMapper;
using MonthyExpenseControl.Application.DTOs;
using MonthyExpenseControl.Application.Interfaces;
using MonthyExpenseControl.Domain.Entities;
using MonthyExpenseControl.Domain.Interfaces;

namespace MonthyExpenseControl.Application.Services;

public class WithdrawalOfInvestmentsDataAccessService : IWithdrawalOfInvestmentsService
{
    private readonly IWithdrawalOfInvestmentsRepository Repository;
    private readonly IMapper Mapper;

    public WithdrawalOfInvestmentsDataAccessService(IWithdrawalOfInvestmentsRepository repository,
                                                    IMapper mapper)
    {
        Repository = repository;
        Mapper = mapper;
    }

    public async Task AddWithdrawalOfInvestmentAsync(WithdrawalOfInvestmentsDTO withdrawalDto)
    {
        var withdrawal = Mapper.Map<WithdrawalOfInvestments>(withdrawalDto);
        await Repository.CreateWithDrawalAsync(withdrawal);
    }

    public async Task<IEnumerable<WithdrawalOfInvestmentsDTO>> GetWithdrawalOfInvestmentAsync()
    {
        var withdrawals = await Repository.GetWithDrawalsAsync();
        return Mapper.Map<IEnumerable<WithdrawalOfInvestmentsDTO>>(withdrawals);
        
    }

    public async Task<WithdrawalOfInvestmentsDTO> GetWithdrawalOfInvestmentByIdAsync(int id)
    {
        var withdrawal = await Repository.GetWithDrawalByIdAsync(id);
        return Mapper.Map<WithdrawalOfInvestmentsDTO>(withdrawal);
    }

    public async Task RemoveWithdrawalOfInvestmentAsync(WithdrawalOfInvestmentsDTO withdrawalDto)
    {
        var withdrawal = Mapper.Map<WithdrawalOfInvestments>(withdrawalDto);
        await Repository.RemoveWithDrawalAsync(withdrawal);
    }

    public async Task UpdateWithdrawalOfInvestmentAsync(WithdrawalOfInvestmentsDTO withdrawalDto)
    {
        var withdrawal = Mapper.Map<WithdrawalOfInvestments>(withdrawalDto);
        await Repository.UpdateWithDrawalAsync(withdrawal);
    }
}
