using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonthyExpenseControl.Migrations
{
    /// <inheritdoc />
    public partial class PopulatingMonthsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Months(MonthsId, SumaryOfTheMonthSummaryId) VALUES (1,1)");
            migrationBuilder.Sql("INSERT INTO Months(MonthsId, SumaryOfTheMonthSummaryId) VALUES (2,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Months");
        }
    }
}
