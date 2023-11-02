using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonthyExpenseControl.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class adjustingDatabaseScheme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Earnings_Months_MonthSummaryId",
                table: "Earnings");

            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Months_MonthSummaryId",
                table: "Expenses");

            migrationBuilder.DropTable(
                name: "InvestmentCapacities");

            migrationBuilder.DropTable(
                name: "Months");

            migrationBuilder.DropTable(
                name: "WithdrawalSumaries");

            migrationBuilder.DropTable(
                name: "Summaries");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_MonthSummaryId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Earnings_MonthSummaryId",
                table: "Earnings");

            migrationBuilder.DropColumn(
                name: "MonthSummaryId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "MonthSummaryId",
                table: "Earnings");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "WithdrawalOfInvestments",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfInvestment",
                table: "MonthInvestments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "LastYearInvestment",
                columns: table => new
                {
                    LatestYearId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalInvestedLastYear = table.Column<double>(type: "float", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LastYearInvestment", x => x.LatestYearId);
                });

            migrationBuilder.InsertData(
                table: "LastYearInvestment",
                columns: new[] { "LatestYearId", "TotalInvestedLastYear", "Year" },
                values: new object[] { 1, 1535.0, 2022 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LastYearInvestment");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "WithdrawalOfInvestments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfInvestment",
                table: "MonthInvestments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "MonthSummaryId",
                table: "Expenses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MonthSummaryId",
                table: "Earnings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InvestmentCapacities",
                columns: table => new
                {
                    InvestmentCapacityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthsId = table.Column<int>(type: "int", nullable: false),
                    ProjectedInvestmentCapacity = table.Column<double>(type: "float", nullable: false),
                    ReliazedInvestmentCapacity = table.Column<double>(type: "float", nullable: false)
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
                name: "Summaries",
                columns: table => new
                {
                    SummaryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthDescriptionMonthsId = table.Column<int>(type: "int", nullable: true),
                    MonthId = table.Column<int>(type: "int", nullable: false),
                    TotalProjectedEarnings = table.Column<double>(type: "float", nullable: false),
                    TotalProjectedExpenses = table.Column<double>(type: "float", nullable: false),
                    TotalProjectedInvestmentCapacity = table.Column<double>(type: "float", nullable: false),
                    TotalRealizedEarnings = table.Column<double>(type: "float", nullable: false),
                    TotalRealizedExpenses = table.Column<double>(type: "float", nullable: false),
                    TotalRealizedInvestmentCapacity = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summaries", x => x.SummaryId);
                    table.ForeignKey(
                        name: "FK_Summaries_MonthsDescription_MonthDescriptionMonthsId",
                        column: x => x.MonthDescriptionMonthsId,
                        principalTable: "MonthsDescription",
                        principalColumn: "MonthsId");
                });

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

            migrationBuilder.CreateTable(
                name: "Months",
                columns: table => new
                {
                    MonthSummaryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthsId = table.Column<int>(type: "int", nullable: false),
                    SumaryOfTheMonthSummaryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Months", x => x.MonthSummaryId);
                    table.ForeignKey(
                        name: "FK_Months_MonthsDescription_MonthsId",
                        column: x => x.MonthsId,
                        principalTable: "MonthsDescription",
                        principalColumn: "MonthsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Months_Summaries_SumaryOfTheMonthSummaryId",
                        column: x => x.SumaryOfTheMonthSummaryId,
                        principalTable: "Summaries",
                        principalColumn: "SummaryId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_MonthSummaryId",
                table: "Expenses",
                column: "MonthSummaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Earnings_MonthSummaryId",
                table: "Earnings",
                column: "MonthSummaryId");

            migrationBuilder.CreateIndex(
                name: "IX_InvestmentCapacities_MonthsId",
                table: "InvestmentCapacities",
                column: "MonthsId");

            migrationBuilder.CreateIndex(
                name: "IX_Months_MonthsId",
                table: "Months",
                column: "MonthsId");

            migrationBuilder.CreateIndex(
                name: "IX_Months_SumaryOfTheMonthSummaryId",
                table: "Months",
                column: "SumaryOfTheMonthSummaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Summaries_MonthDescriptionMonthsId",
                table: "Summaries",
                column: "MonthDescriptionMonthsId");

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
        }
    }
}
