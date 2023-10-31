using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonthyExpenseControl.Infra.Data.Migrations;

/// <inheritdoc />
public partial class AdjustingSumaryTable : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.RenameColumn(
            name: "InvestmentCapacity",
            table: "Sumaries",
            newName: "TotalRealizedInvestmentCapacity");

        migrationBuilder.RenameColumn(
            name: "Expenses",
            table: "Sumaries",
            newName: "TotalRealizedExpenses");

        migrationBuilder.RenameColumn(
            name: "Earnings",
            table: "Sumaries",
            newName: "TotalRealizedEarnings");

        migrationBuilder.AddColumn<double>(
            name: "TotalProjectedEarnings",
            table: "Sumaries",
            type: "float",
            nullable: false,
            defaultValue: 0.0);

        migrationBuilder.AddColumn<double>(
            name: "TotalProjectedExpenses",
            table: "Sumaries",
            type: "float",
            nullable: false,
            defaultValue: 0.0);

        migrationBuilder.AddColumn<double>(
            name: "TotalProjectedInvestmentCapacity",
            table: "Sumaries",
            type: "float",
            nullable: false,
            defaultValue: 0.0);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "TotalProjectedEarnings",
            table: "Sumaries");

        migrationBuilder.DropColumn(
            name: "TotalProjectedExpenses",
            table: "Sumaries");

        migrationBuilder.DropColumn(
            name: "TotalProjectedInvestmentCapacity",
            table: "Sumaries");

        migrationBuilder.RenameColumn(
            name: "TotalRealizedInvestmentCapacity",
            table: "Sumaries",
            newName: "InvestmentCapacity");

        migrationBuilder.RenameColumn(
            name: "TotalRealizedExpenses",
            table: "Sumaries",
            newName: "Expenses");

        migrationBuilder.RenameColumn(
            name: "TotalRealizedEarnings",
            table: "Sumaries",
            newName: "Earnings");
    }
}
