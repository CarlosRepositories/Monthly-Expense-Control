using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonthyExpenseControl.Infra.Data.Migrations;

/// <inheritdoc />
public partial class PopulatingInvestmentCapacitiesTable : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("INSERT INTO InvestmentCapacities(MonthsId, ProjectedInvestmentCapacity, ReliazedInvestmentCapacity) VALUES (1, 725.25, 812.63)");
        migrationBuilder.Sql("INSERT INTO InvestmentCapacities(MonthsId, ProjectedInvestmentCapacity, ReliazedInvestmentCapacity) VALUES (2, 667.50, 995.00)");

    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("DELETE FROM InvestmentCapacities");
    }
}
