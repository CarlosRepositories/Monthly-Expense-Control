using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonthyExpenseControl.Infra.Data.Migrations;

/// <inheritdoc />
public partial class adjustingModelsAndCreatingWithDrawalSumariesModel : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Earnings_Months_MonthSumaryId",
            table: "Earnings");

        migrationBuilder.DropForeignKey(
            name: "FK_Expenses_Months_MonthSumaryId",
            table: "Expenses");

        migrationBuilder.DropForeignKey(
            name: "FK_Months_Sumaries_SumaryOfTheMonthSumaryId",
            table: "Months");

        migrationBuilder.RenameColumn(
            name: "SumaryId",
            table: "Sumaries",
            newName: "SummaryId");

        migrationBuilder.RenameColumn(
            name: "SumaryOfTheMonthSumaryId",
            table: "Months",
            newName: "SumaryOfTheMonthSummaryId");

        migrationBuilder.RenameColumn(
            name: "MonthSumaryId",
            table: "Months",
            newName: "MonthSummaryId");

        migrationBuilder.RenameIndex(
            name: "IX_Months_SumaryOfTheMonthSumaryId",
            table: "Months",
            newName: "IX_Months_SumaryOfTheMonthSummaryId");

        migrationBuilder.RenameColumn(
            name: "MonthSumaryId",
            table: "Expenses",
            newName: "MonthSummaryId");

        migrationBuilder.RenameIndex(
            name: "IX_Expenses_MonthSumaryId",
            table: "Expenses",
            newName: "IX_Expenses_MonthSummaryId");

        migrationBuilder.RenameColumn(
            name: "MonthSumaryId",
            table: "Earnings",
            newName: "MonthSummaryId");

        migrationBuilder.RenameIndex(
            name: "IX_Earnings_MonthSumaryId",
            table: "Earnings",
            newName: "IX_Earnings_MonthSummaryId");

        migrationBuilder.CreateTable(
            name: "WithdrawalSumaries",
            columns: table => new
            {
                WithdrawalSummaryId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                MonthsId = table.Column<int>(type: "int", nullable: false),
                MonthlyWithdrawalTotal = table.Column<double>(type: "float", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_WithdrawalSumaries", x => x.WithdrawalSummaryId);
                table.ForeignKey(
                    name: "FK_WithdrawalSumaries_MonthsDescription_MonthsId",
                    column: x => x.MonthsId,
                    principalTable: "MonthsDescription",
                    principalColumn: "MonthsId",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_WithdrawalSumaries_MonthsId",
            table: "WithdrawalSumaries",
            column: "MonthsId");

        migrationBuilder.AddForeignKey(
            name: "FK_Earnings_Months_MonthSummaryId",
            table: "Earnings",
            column: "MonthSummaryId",
            principalTable: "Months",
            principalColumn: "MonthSummaryId");

        migrationBuilder.AddForeignKey(
            name: "FK_Expenses_Months_MonthSummaryId",
            table: "Expenses",
            column: "MonthSummaryId",
            principalTable: "Months",
            principalColumn: "MonthSummaryId");

        migrationBuilder.AddForeignKey(
            name: "FK_Months_Sumaries_SumaryOfTheMonthSummaryId",
            table: "Months",
            column: "SumaryOfTheMonthSummaryId",
            principalTable: "Sumaries",
            principalColumn: "SummaryId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Earnings_Months_MonthSummaryId",
            table: "Earnings");

        migrationBuilder.DropForeignKey(
            name: "FK_Expenses_Months_MonthSummaryId",
            table: "Expenses");

        migrationBuilder.DropForeignKey(
            name: "FK_Months_Sumaries_SumaryOfTheMonthSummaryId",
            table: "Months");

        migrationBuilder.DropTable(
            name: "WithdrawalSumaries");

        migrationBuilder.RenameColumn(
            name: "SummaryId",
            table: "Sumaries",
            newName: "SumaryId");

        migrationBuilder.RenameColumn(
            name: "SumaryOfTheMonthSummaryId",
            table: "Months",
            newName: "SumaryOfTheMonthSumaryId");

        migrationBuilder.RenameColumn(
            name: "MonthSummaryId",
            table: "Months",
            newName: "MonthSumaryId");

        migrationBuilder.RenameIndex(
            name: "IX_Months_SumaryOfTheMonthSummaryId",
            table: "Months",
            newName: "IX_Months_SumaryOfTheMonthSumaryId");

        migrationBuilder.RenameColumn(
            name: "MonthSummaryId",
            table: "Expenses",
            newName: "MonthSumaryId");

        migrationBuilder.RenameIndex(
            name: "IX_Expenses_MonthSummaryId",
            table: "Expenses",
            newName: "IX_Expenses_MonthSumaryId");

        migrationBuilder.RenameColumn(
            name: "MonthSummaryId",
            table: "Earnings",
            newName: "MonthSumaryId");

        migrationBuilder.RenameIndex(
            name: "IX_Earnings_MonthSummaryId",
            table: "Earnings",
            newName: "IX_Earnings_MonthSumaryId");

        migrationBuilder.AddForeignKey(
            name: "FK_Earnings_Months_MonthSumaryId",
            table: "Earnings",
            column: "MonthSumaryId",
            principalTable: "Months",
            principalColumn: "MonthSumaryId");

        migrationBuilder.AddForeignKey(
            name: "FK_Expenses_Months_MonthSumaryId",
            table: "Expenses",
            column: "MonthSumaryId",
            principalTable: "Months",
            principalColumn: "MonthSumaryId");

        migrationBuilder.AddForeignKey(
            name: "FK_Months_Sumaries_SumaryOfTheMonthSumaryId",
            table: "Months",
            column: "SumaryOfTheMonthSumaryId",
            principalTable: "Sumaries",
            principalColumn: "SumaryId");
    }
}
