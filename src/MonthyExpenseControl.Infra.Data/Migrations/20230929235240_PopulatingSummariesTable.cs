using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonthyExpenseControl.Infra.Data.Migrations;

/// <inheritdoc />
public partial class PopulatingSummariesTable : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Months_Sumaries_SumaryOfTheMonthSummaryId",
            table: "Months");

        migrationBuilder.DropForeignKey(
            name: "FK_Sumaries_MonthsDescription_MonthDescriptionMonthsId",
            table: "Sumaries");

        migrationBuilder.DropPrimaryKey(
            name: "PK_Sumaries",
            table: "Sumaries");

        migrationBuilder.RenameTable(
            name: "Sumaries",
            newName: "Summaries");

        migrationBuilder.RenameIndex(
            name: "IX_Sumaries_MonthDescriptionMonthsId",
            table: "Summaries",
            newName: "IX_Summaries_MonthDescriptionMonthsId");

        migrationBuilder.AddPrimaryKey(
            name: "PK_Summaries",
            table: "Summaries",
            column: "SummaryId");

        migrationBuilder.AddForeignKey(
            name: "FK_Months_Summaries_SumaryOfTheMonthSummaryId",
            table: "Months",
            column: "SumaryOfTheMonthSummaryId",
            principalTable: "Summaries",
            principalColumn: "SummaryId");

        migrationBuilder.AddForeignKey(
            name: "FK_Summaries_MonthsDescription_MonthDescriptionMonthsId",
            table: "Summaries",
            column: "MonthDescriptionMonthsId",
            principalTable: "MonthsDescription",
            principalColumn: "MonthsId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Months_Summaries_SumaryOfTheMonthSummaryId",
            table: "Months");

        migrationBuilder.DropForeignKey(
            name: "FK_Summaries_MonthsDescription_MonthDescriptionMonthsId",
            table: "Summaries");

        migrationBuilder.DropPrimaryKey(
            name: "PK_Summaries",
            table: "Summaries");

        migrationBuilder.RenameTable(
            name: "Summaries",
            newName: "Sumaries");

        migrationBuilder.RenameIndex(
            name: "IX_Summaries_MonthDescriptionMonthsId",
            table: "Sumaries",
            newName: "IX_Sumaries_MonthDescriptionMonthsId");

        migrationBuilder.AddPrimaryKey(
            name: "PK_Sumaries",
            table: "Sumaries",
            column: "SummaryId");

        migrationBuilder.AddForeignKey(
            name: "FK_Months_Sumaries_SumaryOfTheMonthSummaryId",
            table: "Months",
            column: "SumaryOfTheMonthSummaryId",
            principalTable: "Sumaries",
            principalColumn: "SummaryId");

        migrationBuilder.AddForeignKey(
            name: "FK_Sumaries_MonthsDescription_MonthDescriptionMonthsId",
            table: "Sumaries",
            column: "MonthDescriptionMonthsId",
            principalTable: "MonthsDescription",
            principalColumn: "MonthsId");
    }
}
