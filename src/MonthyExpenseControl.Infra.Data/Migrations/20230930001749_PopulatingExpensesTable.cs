using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonthyExpenseControl.Infra.Data.Migrations;

/// <inheritdoc />
public partial class PopulatingExpensesTable : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("INSERT INTO Expenses(MonthsId, Description, ProjectedExpense, RealizedExpense, MonthSummaryId) " +
            "VALUES (1, 'CONTA DE LUZ', 160, 72.37,2)");
        migrationBuilder.Sql("INSERT INTO Expenses(MonthsId, Description, ProjectedExpense, RealizedExpense, MonthSummaryId) " +
            "VALUES (1, 'CONTA DE ÁGUA', 115, 115,2)");
        migrationBuilder.Sql("INSERT INTO Expenses(MonthsId, Description, ProjectedExpense, RealizedExpense, MonthSummaryId) " +
            "VALUES (2, 'FATURA TIM', 32.50, 80, 3)");
        migrationBuilder.Sql("INSERT INTO Expenses(MonthsId, Description, ProjectedExpense, RealizedExpense, MonthSummaryId) " +
            "VALUES (2, 'FATURA CARTÃO', 400, 125, 3)");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("DELETE FROM Expenses");
    }
}
