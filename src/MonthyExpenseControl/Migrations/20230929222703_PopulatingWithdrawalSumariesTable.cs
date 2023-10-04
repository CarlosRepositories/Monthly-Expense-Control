using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonthyExpenseControl.Migrations
{
    /// <inheritdoc />
    public partial class PopulatingWithdrawalSumariesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO WithdrawalSumaries(MonthsId, MonthlyWithdrawalTotal) VALUES (1, 100.00)");
            migrationBuilder.Sql("INSERT INTO WithdrawalSumaries(MonthsId, MonthlyWithdrawalTotal) VALUES (2, 120.00)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM WithdrawalSumaries");
        }
    }
}
