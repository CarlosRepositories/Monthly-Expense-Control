using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonthyExpenseControl.Infra.Data.Migrations;

/// <inheritdoc />
public partial class PopulatingEarningsTable : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("INSERT INTO Earnings(MonthsId, Description, ProjectedEarning, RealizedEarning, MonthSummaryId) " +
            "VALUES (1, 'Salário', 1000, 1000, 2)");
        migrationBuilder.Sql("INSERT INTO Earnings(MonthsId, Description, ProjectedEarning, RealizedEarning, MonthSummaryId) " +
            "VALUES (2, 'Salário', 1100, 1200, 3)");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("DELETE FROM Earnings");
    }
}
