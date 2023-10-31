
#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace MonthyExpenseControl.Infra.Data.Migrations;

/// <inheritdoc />
public partial class InitialMigration : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "MonthsDescription",
            columns: table => new
            {
                MonthsId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                MonthName = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_MonthsDescription", x => x.MonthsId);
            });

        migrationBuilder.CreateTable(
            name: "InvestmentCapacities",
            columns: table => new
            {
                InvestmentCapacityId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                MonthsId = table.Column<int>(type: "int", nullable: false),
                ProjectedInvestmentCapacity = table.Column<double>(type: "float", nullable: false),
                IncurredInvestmentCapacity = table.Column<double>(type: "float", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_InvestmentCapacities", x => x.InvestmentCapacityId);
                table.ForeignKey(
                    name: "FK_InvestmentCapacities_MonthsDescription_MonthsId",
                    column: x => x.MonthsId,
                    principalTable: "MonthsDescription",
                    principalColumn: "MonthsId",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "MonthInvestments",
            columns: table => new
            {
                MonthInvestmentId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                MonthsId = table.Column<int>(type: "int", nullable: false),
                InvestmentAmount = table.Column<double>(type: "float", nullable: false),
                TypeOfInvestment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                InvestmentPercentage = table.Column<double>(type: "float", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_MonthInvestments", x => x.MonthInvestmentId);
                table.ForeignKey(
                    name: "FK_MonthInvestments_MonthsDescription_MonthsId",
                    column: x => x.MonthsId,
                    principalTable: "MonthsDescription",
                    principalColumn: "MonthsId",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Sumaries",
            columns: table => new
            {
                SumaryId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                MonthId = table.Column<int>(type: "int", nullable: false),
                MonthDescriptionMonthsId = table.Column<int>(type: "int", nullable: true),
                Earnings = table.Column<double>(type: "float", nullable: false),
                Expenses = table.Column<double>(type: "float", nullable: false),
                InvestmentCapacity = table.Column<double>(type: "float", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Sumaries", x => x.SumaryId);
                table.ForeignKey(
                    name: "FK_Sumaries_MonthsDescription_MonthDescriptionMonthsId",
                    column: x => x.MonthDescriptionMonthsId,
                    principalTable: "MonthsDescription",
                    principalColumn: "MonthsId");
            });

        migrationBuilder.CreateTable(
            name: "WithdrawalOfInvestments",
            columns: table => new
            {
                WithdrawalOfInvestmentsId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                MonthId = table.Column<int>(type: "int", nullable: false),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                WithDrawalValue = table.Column<double>(type: "float", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_WithdrawalOfInvestments", x => x.WithdrawalOfInvestmentsId);
                table.ForeignKey(
                    name: "FK_WithdrawalOfInvestments_MonthsDescription_MonthId",
                    column: x => x.MonthId,
                    principalTable: "MonthsDescription",
                    principalColumn: "MonthsId",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Months",
            columns: table => new
            {
                MonthSumaryId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                MonthsId = table.Column<int>(type: "int", nullable: false),
                SumaryOfTheMonthSumaryId = table.Column<int>(type: "int", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Months", x => x.MonthSumaryId);
                table.ForeignKey(
                    name: "FK_Months_MonthsDescription_MonthsId",
                    column: x => x.MonthsId,
                    principalTable: "MonthsDescription",
                    principalColumn: "MonthsId",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_Months_Sumaries_SumaryOfTheMonthSumaryId",
                    column: x => x.SumaryOfTheMonthSumaryId,
                    principalTable: "Sumaries",
                    principalColumn: "SumaryId");
            });

        migrationBuilder.CreateTable(
            name: "Earnings",
            columns: table => new
            {
                EarningId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                MonthsId = table.Column<int>(type: "int", nullable: false),
                Description = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                ProjectedEarning = table.Column<double>(type: "float", nullable: false),
                IncurredEarning = table.Column<double>(type: "float", nullable: false),
                MonthSumaryId = table.Column<int>(type: "int", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Earnings", x => x.EarningId);
                table.ForeignKey(
                    name: "FK_Earnings_MonthsDescription_MonthsId",
                    column: x => x.MonthsId,
                    principalTable: "MonthsDescription",
                    principalColumn: "MonthsId",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_Earnings_Months_MonthSumaryId",
                    column: x => x.MonthSumaryId,
                    principalTable: "Months",
                    principalColumn: "MonthSumaryId");
            });

        migrationBuilder.CreateTable(
            name: "Expenses",
            columns: table => new
            {
                ExpenseId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                MonthsId = table.Column<int>(type: "int", nullable: false),
                Description = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                ProjectedExpense = table.Column<double>(type: "float", nullable: false),
                IncurredExpense = table.Column<double>(type: "float", nullable: false),
                MonthSumaryId = table.Column<int>(type: "int", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Expenses", x => x.ExpenseId);
                table.ForeignKey(
                    name: "FK_Expenses_MonthsDescription_MonthsId",
                    column: x => x.MonthsId,
                    principalTable: "MonthsDescription",
                    principalColumn: "MonthsId",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_Expenses_Months_MonthSumaryId",
                    column: x => x.MonthSumaryId,
                    principalTable: "Months",
                    principalColumn: "MonthSumaryId");
            });

        migrationBuilder.CreateIndex(
            name: "IX_Earnings_MonthsId",
            table: "Earnings",
            column: "MonthsId");

        migrationBuilder.CreateIndex(
            name: "IX_Earnings_MonthSumaryId",
            table: "Earnings",
            column: "MonthSumaryId");

        migrationBuilder.CreateIndex(
            name: "IX_Expenses_MonthsId",
            table: "Expenses",
            column: "MonthsId");

        migrationBuilder.CreateIndex(
            name: "IX_Expenses_MonthSumaryId",
            table: "Expenses",
            column: "MonthSumaryId");

        migrationBuilder.CreateIndex(
            name: "IX_InvestmentCapacities_MonthsId",
            table: "InvestmentCapacities",
            column: "MonthsId");

        migrationBuilder.CreateIndex(
            name: "IX_MonthInvestments_MonthsId",
            table: "MonthInvestments",
            column: "MonthsId");

        migrationBuilder.CreateIndex(
            name: "IX_Months_MonthsId",
            table: "Months",
            column: "MonthsId");

        migrationBuilder.CreateIndex(
            name: "IX_Months_SumaryOfTheMonthSumaryId",
            table: "Months",
            column: "SumaryOfTheMonthSumaryId");

        migrationBuilder.CreateIndex(
            name: "IX_Sumaries_MonthDescriptionMonthsId",
            table: "Sumaries",
            column: "MonthDescriptionMonthsId");

        migrationBuilder.CreateIndex(
            name: "IX_WithdrawalOfInvestments_MonthId",
            table: "WithdrawalOfInvestments",
            column: "MonthId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Earnings");

        migrationBuilder.DropTable(
            name: "Expenses");

        migrationBuilder.DropTable(
            name: "InvestmentCapacities");

        migrationBuilder.DropTable(
            name: "MonthInvestments");

        migrationBuilder.DropTable(
            name: "WithdrawalOfInvestments");

        migrationBuilder.DropTable(
            name: "Months");

        migrationBuilder.DropTable(
            name: "Sumaries");

        migrationBuilder.DropTable(
            name: "MonthsDescription");
    }
}
