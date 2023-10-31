using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonthyExpenseControl.Infra.Data.Migrations;

/// <inheritdoc />
public partial class UpdatingPropertiesName : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.RenameColumn(
            name: "IncurredInvestmentCapacity",
            table: "InvestmentCapacities",
            newName: "ReliazedInvestmentCapacity");

        migrationBuilder.RenameColumn(
            name: "IncurredExpense",
            table: "Expenses",
            newName: "RealizedExpense");

        migrationBuilder.RenameColumn(
            name: "IncurredEarning",
            table: "Earnings",
            newName: "RealizedEarning");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.RenameColumn(
            name: "ReliazedInvestmentCapacity",
            table: "InvestmentCapacities",
            newName: "IncurredInvestmentCapacity");

        migrationBuilder.RenameColumn(
            name: "RealizedExpense",
            table: "Expenses",
            newName: "IncurredExpense");

        migrationBuilder.RenameColumn(
            name: "RealizedEarning",
            table: "Earnings",
            newName: "IncurredEarning");
    }
}
