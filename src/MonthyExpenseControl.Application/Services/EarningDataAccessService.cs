using AutoMapper;
using MonthyExpenseControl.Application.DTOs;
using MonthyExpenseControl.Application.Interfaces;
using MonthyExpenseControl.Domain.Entities;
using MonthyExpenseControl.Domain.Interfaces;

namespace MonthyExpenseControl.Application.Services;

public class EarningDataAccessService : IEarningService
{
    private readonly IEarningRepository Repository;
    private readonly IMapper Mapper;
    public EarningDataAccessService(IEarningRepository repository, IMapper mapper)
    {
        Repository = repository;
        Mapper = mapper;
    }
    public async Task AddEarningAsync(EarningDTO earningDto)
    {
        var earning = Mapper.Map<Earning>(earningDto);
        await Repository.CreateEarningAsync(earning);
    }

    public async Task<EarningDTO> GetEarningByIdAsync(int id)
    {
        var earning = await Repository.GetEarningByIdAsync(id);
        return Mapper.Map<EarningDTO>(earning);
    }

    public async Task<IEnumerable<EarningDTO>> GetEarningsByMonthAsync(int monthId)
    {
        var earnings = await Repository.GetEarningsAsync();
        var earningsByMonth = earnings
            .Where(e => e.MonthsId == monthId);
        return Mapper.Map<IEnumerable<EarningDTO>>(earningsByMonth);
    }

    public async Task RemoveEarningsAsync(EarningDTO earningDto)
    {
        var earning = Mapper.Map<Earning>(earningDto);
        await Repository.RemoveEarningAsync(earning);
    }

    public async Task UpdateEarningAsync(EarningDTO earningDto)
    {
        var earning = Mapper.Map<Earning>(earningDto);
        await Repository.UpdateEarningAsync(earning);
    }
}
