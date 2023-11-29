using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonthyExpenseControl.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdjustingMonthInvestmetProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeOfInvestment",
                table: "MonthInvestments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TypeOfInvestment",
                table: "MonthInvestments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
