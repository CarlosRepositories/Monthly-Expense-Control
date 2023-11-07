using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MonthyExpenseControl.Application.Mappings;
using MonthyExpenseControl.Domain.Interfaces;
using MonthyExpenseControl.Infra.Data.Context;
using MonthyExpenseControl.Infra.Data.Repositories;

namespace MonthyExpenseControl.Infra.IOC
{
    public static class DependencyInjectionInfrastructure
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext)
                    .Assembly.FullName)));


            services.AddScoped<IEarningRepository, EarningRepository>();
            services.AddScoped<IExpenseRepository, ExpenseRepository>();
            services.AddScoped<ILastYearInvestmentRepository, LastYearInvestmentRepository>();
            services.AddScoped<IWithdrawalOfInvestmentsRepository, WithdrawalOfInvestmentsRepository>();
            services.AddAutoMapper(typeof(DomainToDTOMappingProfiler));

            return services;
        }

    }
}
