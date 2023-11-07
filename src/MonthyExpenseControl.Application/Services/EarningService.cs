using AutoMapper;
using MonthyExpenseControl.Application.DTOs;
using MonthyExpenseControl.Application.Interfaces;
using MonthyExpenseControl.Domain.Entities;
using MonthyExpenseControl.Domain.Interfaces;

namespace MonthyExpenseControl.Application.Services
{
    public class EarningService : IEarningService
    {
        private readonly IEarningRepository Repository;
        private readonly IMapper Mapper;
        public EarningService(IEarningRepository repository, IMapper mapper)
        {
            Repository = repository;
            Mapper = mapper;
        }
        public async Task<EarningDTO> CreateEarningAsync(Earning earning)
        {
            await Repository.CreateEarningAsync(earning);
            return Mapper.Map<EarningDTO>(earning);
        }

        public async Task<EarningDTO> GetEarningByIdAsync(int id)
        {
            var earning = await Repository.GetEarningByIdAsync(id);
            return Mapper.Map<EarningDTO>(earning);
        }

        public async Task<IEnumerable<EarningDTO>> GetEarningsAsync()
        {
            var earnings = await Repository.GetEarningsAsync();
            return Mapper.Map<IEnumerable<EarningDTO>>(earnings);
        }

        public async Task<EarningDTO> RemoveEarningsAsync(Earning earning)
        {
            var missedEarning = await Repository.RemoveEarningAsync(earning);
            return Mapper.Map<EarningDTO>(missedEarning);
        }

        public async Task<EarningDTO> UpdateEarningAsync(Earning earning)
        {
            var updatedEarning = await Repository.UpdateEarningAsync(earning);
            return Mapper.Map<EarningDTO>(updatedEarning);
        }
    }
}
