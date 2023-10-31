﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonthyExpenseControl.Infra.Data.Migrations;

[DbContext(typeof(AppDbContext))]
[Migration("20230928220859_InitialMigration")]
partial class InitialMigration
{
    /// <inheritdoc />
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "7.0.11")
            .HasAnnotation("Relational:MaxIdentifierLength", 128);

        SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

        modelBuilder.Entity("MonthyExpenseControl.Models.Earning", b =>
        {
            b.Property<int>("EarningId")
                .ValueGeneratedOnAdd()
                .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EarningId"));

            b.Property<string>("Description")
                .IsRequired()
                .HasMaxLength(40)
                .HasColumnType("nvarchar(40)");

            b.Property<double>("IncurredEarning")
                .HasColumnType("float");

            b.Property<int?>("MonthSumaryId")
                .HasColumnType("int");

            b.Property<int>("MonthsId")
                .HasColumnType("int");

            b.Property<double>("ProjectedEarning")
                .HasColumnType("float");

            b.HasKey("EarningId");

            b.HasIndex("MonthSumaryId");

            b.HasIndex("MonthsId");

            b.ToTable("Earnings");
        });

        modelBuilder.Entity("MonthyExpenseControl.Models.Expense", b =>
        {
            b.Property<int>("ExpenseId")
                .ValueGeneratedOnAdd()
                .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExpenseId"));

            b.Property<string>("Description")
                .IsRequired()
                .HasMaxLength(40)
                .HasColumnType("nvarchar(40)");

            b.Property<double>("IncurredExpense")
                .HasColumnType("float");

            b.Property<int?>("MonthSumaryId")
                .HasColumnType("int");

            b.Property<int>("MonthsId")
                .HasColumnType("int");

            b.Property<double>("ProjectedExpense")
                .HasColumnType("float");

            b.HasKey("ExpenseId");

            b.HasIndex("MonthSumaryId");

            b.HasIndex("MonthsId");

            b.ToTable("Expenses");
        });

        modelBuilder.Entity("MonthyExpenseControl.Models.InvestmentCapacity", b =>
        {
            b.Property<int>("InvestmentCapacityId")
                .ValueGeneratedOnAdd()
                .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvestmentCapacityId"));

            b.Property<double>("IncurredInvestmentCapacity")
                .HasColumnType("float");

            b.Property<int>("MonthsId")
                .HasColumnType("int");

            b.Property<double>("ProjectedInvestmentCapacity")
                .HasColumnType("float");

            b.HasKey("InvestmentCapacityId");

            b.HasIndex("MonthsId");

            b.ToTable("InvestmentCapacities");
        });

        modelBuilder.Entity("MonthyExpenseControl.Models.MonthInvestment", b =>
        {
            b.Property<int>("MonthInvestmentId")
                .ValueGeneratedOnAdd()
                .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MonthInvestmentId"));

            b.Property<double>("InvestmentAmount")
                .HasColumnType("float");

            b.Property<double>("InvestmentPercentage")
                .HasColumnType("float");

            b.Property<int>("MonthsId")
                .HasColumnType("int");

            b.Property<string>("TypeOfInvestment")
                .HasColumnType("nvarchar(max)");

            b.HasKey("MonthInvestmentId");

            b.HasIndex("MonthsId");

            b.ToTable("MonthInvestments");
        });

        modelBuilder.Entity("MonthyExpenseControl.Models.MonthSumary", b =>
        {
            b.Property<int>("MonthSumaryId")
                .ValueGeneratedOnAdd()
                .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MonthSumaryId"));

            b.Property<int>("MonthsId")
                .HasColumnType("int");

            b.Property<int?>("SumaryOfTheMonthSumaryId")
                .HasColumnType("int");

            b.HasKey("MonthSumaryId");

            b.HasIndex("MonthsId");

            b.HasIndex("SumaryOfTheMonthSumaryId");

            b.ToTable("Months");
        });

        modelBuilder.Entity("MonthyExpenseControl.Models.Months", b =>
        {
            b.Property<int>("MonthsId")
                .ValueGeneratedOnAdd()
                .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MonthsId"));

            b.Property<string>("MonthName")
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            b.HasKey("MonthsId");

            b.ToTable("MonthsDescription");
        });

        modelBuilder.Entity("MonthyExpenseControl.Models.Sumary", b =>
        {
            b.Property<int>("SumaryId")
                .ValueGeneratedOnAdd()
                .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SumaryId"));

            b.Property<double>("Earnings")
                .HasColumnType("float");

            b.Property<double>("Expenses")
                .HasColumnType("float");

            b.Property<double>("InvestmentCapacity")
                .HasColumnType("float");

            b.Property<int?>("MonthDescriptionMonthsId")
                .HasColumnType("int");

            b.Property<int>("MonthId")
                .HasColumnType("int");

            b.HasKey("SumaryId");

            b.HasIndex("MonthDescriptionMonthsId");

            b.ToTable("Sumaries");
        });

        modelBuilder.Entity("MonthyExpenseControl.Models.WithdrawalOfInvestments", b =>
        {
            b.Property<int>("WithdrawalOfInvestmentsId")
                .ValueGeneratedOnAdd()
                .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WithdrawalOfInvestmentsId"));

            b.Property<string>("Description")
                .HasColumnType("nvarchar(max)");

            b.Property<int>("MonthId")
                .HasColumnType("int");

            b.Property<double>("WithDrawalValue")
                .HasColumnType("float");

            b.HasKey("WithdrawalOfInvestmentsId");

            b.HasIndex("MonthId");

            b.ToTable("WithdrawalOfInvestments");
        });

        modelBuilder.Entity("MonthyExpenseControl.Models.Earning", b =>
        {
            b.HasOne("MonthyExpenseControl.Models.MonthSumary", null)
                .WithMany("MonthlyEarnings")
                .HasForeignKey("MonthSumaryId");

            b.HasOne("MonthyExpenseControl.Models.Months", "MonthDescription")
                .WithMany()
                .HasForeignKey("MonthsId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.Navigation("MonthDescription");
        });

        modelBuilder.Entity("MonthyExpenseControl.Models.Expense", b =>
        {
            b.HasOne("MonthyExpenseControl.Models.MonthSumary", null)
                .WithMany("MonthlyExpenses")
                .HasForeignKey("MonthSumaryId");

            b.HasOne("MonthyExpenseControl.Models.Months", "MonthDescription")
                .WithMany()
                .HasForeignKey("MonthsId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.Navigation("MonthDescription");
        });

        modelBuilder.Entity("MonthyExpenseControl.Models.InvestmentCapacity", b =>
        {
            b.HasOne("MonthyExpenseControl.Models.Months", "MonthDescription")
                .WithMany()
                .HasForeignKey("MonthsId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.Navigation("MonthDescription");
        });

        modelBuilder.Entity("MonthyExpenseControl.Models.MonthInvestment", b =>
        {
            b.HasOne("MonthyExpenseControl.Models.Months", "Month")
                .WithMany()
                .HasForeignKey("MonthsId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.Navigation("Month");
        });

        modelBuilder.Entity("MonthyExpenseControl.Models.MonthSumary", b =>
        {
            b.HasOne("MonthyExpenseControl.Models.Months", "MonthDescription")
                .WithMany()
                .HasForeignKey("MonthsId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.HasOne("MonthyExpenseControl.Models.Sumary", "SumaryOfTheMonth")
                .WithMany()
                .HasForeignKey("SumaryOfTheMonthSumaryId");

            b.Navigation("MonthDescription");

            b.Navigation("SumaryOfTheMonth");
        });

        modelBuilder.Entity("MonthyExpenseControl.Models.Sumary", b =>
        {
            b.HasOne("MonthyExpenseControl.Models.Months", "MonthDescription")
                .WithMany()
                .HasForeignKey("MonthDescriptionMonthsId");

            b.Navigation("MonthDescription");
        });

        modelBuilder.Entity("MonthyExpenseControl.Models.WithdrawalOfInvestments", b =>
        {
            b.HasOne("MonthyExpenseControl.Models.Months", "Month")
                .WithMany()
                .HasForeignKey("MonthId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.Navigation("Month");
        });

        modelBuilder.Entity("MonthyExpenseControl.Models.MonthSumary", b =>
        {
            b.Navigation("MonthlyEarnings");

            b.Navigation("MonthlyExpenses");
        });
#pragma warning restore 612, 618
    }
}