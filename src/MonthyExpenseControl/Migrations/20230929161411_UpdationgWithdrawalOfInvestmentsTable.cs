using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonthyExpenseControl.Migrations
{
    /// <inheritdoc />
    public partial class UpdationgWithdrawalOfInvestmentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO WithdrawalOfInvestments(MonthId, Description, WithDrawalValue) VALUES (1, 'PAGAMENTO IPVA', 100.00)");
            migrationBuilder.Sql("INSERT INTO WithdrawalOfInvestments(MonthId, Description, WithDrawalValue) VALUES (2, 'VIAGEM', 120.00)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM WithdrawalOfInvestments");
        }
    }
}
