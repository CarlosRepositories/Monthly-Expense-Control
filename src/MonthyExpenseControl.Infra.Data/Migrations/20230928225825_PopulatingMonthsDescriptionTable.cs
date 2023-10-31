using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonthyExpenseControl.Infra.Data.Migrations;

/// <inheritdoc />
public partial class PopulatingMonthsDescriptionTable : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("INSERT INTO MonthsDescription (MonthName) VALUES ('Janeiro')");
        migrationBuilder.Sql("INSERT INTO MonthsDescription (MonthName) VALUES ('Fevereiro')");
        migrationBuilder.Sql("INSERT INTO MonthsDescription (MonthName) VALUES ('Março')");
        migrationBuilder.Sql("INSERT INTO MonthsDescription (MonthName) VALUES ('Abril')");
        migrationBuilder.Sql("INSERT INTO MonthsDescription (MonthName) VALUES ('Maio')");
        migrationBuilder.Sql("INSERT INTO MonthsDescription (MonthName) VALUES ('Junho')");
        migrationBuilder.Sql("INSERT INTO MonthsDescription (MonthName) VALUES ('Julho')");
        migrationBuilder.Sql("INSERT INTO MonthsDescription (MonthName) VALUES ('Agosto')");
        migrationBuilder.Sql("INSERT INTO MonthsDescription (MonthName) VALUES ('Setembro')");
        migrationBuilder.Sql("INSERT INTO MonthsDescription (MonthName) VALUES ('Outubro')");
        migrationBuilder.Sql("INSERT INTO MonthsDescription (MonthName) VALUES ('Novembro')");
        migrationBuilder.Sql("INSERT INTO MonthsDescription (MonthName) VALUES ('Dezembro')");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("DELETE FROM MonthsDescription");
    }
}
