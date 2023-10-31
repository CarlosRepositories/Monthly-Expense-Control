using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonthyExpenseControl.Infra.Data.Migrations;

/// <inheritdoc />
public partial class PopulatingMonthInvestmentsTable : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("INSERT INTO MonthInvestments(MonthsId, InvestmentAmount, TypeOfInvestment, InvestmentPercentage) VALUES (1, 812.63, 'Poupança',0.81)");
        migrationBuilder.Sql("INSERT INTO MonthInvestments(MonthsId, InvestmentAmount, TypeOfInvestment, InvestmentPercentage) VALUES (2, 995.00, 'Tesouro Direto',0.83)");

    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("DELETE FROM MonthInvestments");
    }
}
