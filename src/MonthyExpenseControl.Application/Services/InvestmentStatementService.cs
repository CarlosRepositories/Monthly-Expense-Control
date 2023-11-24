using AutoMapper;
using MonthyExpenseControl.Application.DTOs;
using MonthyExpenseControl.Application.Interfaces;
using MonthyExpenseControl.Domain.Interfaces;

namespace MonthyExpenseControl.Application.Services
{
    public class InvestmentStatementService
    {
        private readonly ISummaryService SummaryService;
        private readonly ILastYearInvestmentRepository LastYearInvestmentRepository;
        private readonly IMapper Mapper;
        private readonly ILastYearInvestmentService LastYearInvestmentService;
        private readonly IWithdrawalOfInvestmentsService WithdrawalOfInvestmentsService;
        public InvestmentStatementService(ISummaryService summaryService,
                                          ILastYearInvestmentRepository lastYearInvestmentRepository,
                                          IMapper mapper,
                                          ILastYearInvestmentService lastYearInvestmentService,
                                          IWithdrawalOfInvestmentsService withdrawalOfInvestmentsService)
        {
            SummaryService = summaryService;
            LastYearInvestmentRepository = lastYearInvestmentRepository;
            Mapper = mapper;
            LastYearInvestmentService = lastYearInvestmentService;
            WithdrawalOfInvestmentsService = withdrawalOfInvestmentsService;
        }

        public IEnumerable<MonthInvestmentDTO> GetMonthlyInvestments()
        {
            var withdrawal = WithdrawalOfInvestmentsService.GetWithdrawalOfInvestmentAsync().Result;            

            var monthlyInvestments = new List<MonthInvestmentDTO>();            
            for (int i = 1; i <= 12; i++)
            {
                var summary = SummaryService.GetMonthSummary(i);

                var withdrawalSummary = new WithdrawalSummaryDTO()
                {
                    MonthsId = i,
                    MonthlyWithdrawalTotal = withdrawal
                    .Where(_ => _.MonthId == i)
                    .Sum(_ => _.WithDrawalValue),                    
                };

                var monthlyInvestment = new MonthInvestmentDTO()
                {
                    InvestmentAmount = summary.TotalRealizedInvestmentCapacity,
                    InvestmentPercentage = summary.TotalRealizedEarnings == 0 ? 0 :
                        summary.TotalRealizedInvestmentCapacity / summary.TotalRealizedEarnings,
                    MonthsId = i,
                    LastYearInvestment = LastYearInvestmentService.GetLastYearInvestmentAsync().Result,
                    WithdrawalSummary = withdrawalSummary
                };

                monthlyInvestments.Add(monthlyInvestment);
            }

            return monthlyInvestments;
        }
    }
}


