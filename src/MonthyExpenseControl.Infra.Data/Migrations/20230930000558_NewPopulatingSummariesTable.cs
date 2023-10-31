using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonthyExpenseControl.Infra.Data.Migrations;

/// <inheritdoc />
public partial class NewPopulatingSummariesTable : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("INSERT INTO Summaries(MonthId, MonthDescriptionMonthsId, " +
            "TotalRealizedEarnings, TotalRealizedExpenses, TotalRealizedInvestmentCapacity," +
            " TotalProjectedEarnings, TotalProjectedExpenses, TotalProjectedInvestmentCapacity) " +
            "VALUES (1, 1, 1000, 187.37,812.63, 1000, 275, 725)");

        migrationBuilder.Sql("INSERT INTO Summaries(MonthId, MonthDescriptionMonthsId, " +
            "TotalRealizedEarnings, TotalRealizedExpenses, TotalRealizedInvestmentCapacity," +
            " TotalProjectedEarnings, TotalProjectedExpenses, TotalProjectedInvestmentCapacity) " +
            "VALUES (2, 2, 1200, 205, 995, 1100, 432.50, 667.50)");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("DELETE FROM Summaries");
    }
}
