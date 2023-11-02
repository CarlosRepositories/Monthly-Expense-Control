﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using MonthyExpenseControl.Infra.Data.Context;

#nullable disable

namespace MonthyExpenseControl.Infra.Data.Migrations;

[DbContext(typeof(ApplicationDbContext))]
[Migration("20230929160640_PopulationgWithdrawalOfInvestmentsTable")]
partial class PopulationgWithdrawalOfInvestmentsTable
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

                b.Property<int?>("MonthSummaryId")
                    .HasColumnType("int");

                b.Property<int>("MonthsId")
                    .HasColumnType("int");

                b.Property<double>("ProjectedEarning")
                    .HasColumnType("float");

                b.Property<double>("RealizedEarning")
                    .HasColumnType("float");

                b.HasKey("EarningId");

                b.HasIndex("MonthSummaryId");

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

                b.Property<int?>("MonthSummaryId")
                    .HasColumnType("int");

                b.Property<int>("MonthsId")
                    .HasColumnType("int");

                b.Property<double>("ProjectedExpense")
                    .HasColumnType("float");

                b.Property<double>("RealizedExpense")
                    .HasColumnType("float");

                b.HasKey("ExpenseId");

                b.HasIndex("MonthSummaryId");

                b.HasIndex("MonthsId");

                b.ToTable("Expenses");
            });

        modelBuilder.Entity("MonthyExpenseControl.Models.InvestmentCapacity", b =>
            {
                b.Property<int>("InvestmentCapacityId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvestmentCapacityId"));

                b.Property<int>("MonthsId")
                    .HasColumnType("int");

                b.Property<double>("ProjectedInvestmentCapacity")
                    .HasColumnType("float");

                b.Property<double>("ReliazedInvestmentCapacity")
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

        modelBuilder.Entity("MonthyExpenseControl.Models.MonthSummary", b =>
            {
                b.Property<int>("MonthSummaryId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MonthSummaryId"));

                b.Property<int>("MonthsId")
                    .HasColumnType("int");

                b.Property<int?>("SumaryOfTheMonthSummaryId")
                    .HasColumnType("int");

                b.HasKey("MonthSummaryId");

                b.HasIndex("MonthsId");

                b.HasIndex("SumaryOfTheMonthSummaryId");

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

        modelBuilder.Entity("MonthyExpenseControl.Models.Summary", b =>
            {
                b.Property<int>("SummaryId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SummaryId"));

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

                b.HasKey("SummaryId");

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

        modelBuilder.Entity("MonthyExpenseControl.Models.WithdrawalSummary", b =>
            {
                b.Property<int>("WithdrawalSummaryId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WithdrawalSummaryId"));

                b.Property<double>("MonthlyWithdrawalTotal")
                    .HasColumnType("float");

                b.Property<int>("MonthsId")
                    .HasColumnType("int");

                b.HasKey("WithdrawalSummaryId");

                b.HasIndex("MonthsId");

                b.ToTable("WithdrawalSumaries");
            });

        modelBuilder.Entity("MonthyExpenseControl.Models.Earning", b =>
            {
                b.HasOne("MonthyExpenseControl.Models.MonthSummary", null)
                    .WithMany("MonthlyEarnings")
                    .HasForeignKey("MonthSummaryId");

                b.HasOne("MonthyExpenseControl.Models.Months", "MonthDescription")
                    .WithMany()
                    .HasForeignKey("MonthsId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("MonthDescription");
            });

        modelBuilder.Entity("MonthyExpenseControl.Models.Expense", b =>
            {
                b.HasOne("MonthyExpenseControl.Models.MonthSummary", null)
                    .WithMany("MonthlyExpenses")
                    .HasForeignKey("MonthSummaryId");

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

        modelBuilder.Entity("MonthyExpenseControl.Models.MonthSummary", b =>
            {
                b.HasOne("MonthyExpenseControl.Models.Months", "MonthDescription")
                    .WithMany()
                    .HasForeignKey("MonthsId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("MonthyExpenseControl.Models.Summary", "SumaryOfTheMonth")
                    .WithMany()
                    .HasForeignKey("SumaryOfTheMonthSummaryId");

                b.Navigation("MonthDescription");

                b.Navigation("SumaryOfTheMonth");
            });

        modelBuilder.Entity("MonthyExpenseControl.Models.Summary", b =>
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

        modelBuilder.Entity("MonthyExpenseControl.Models.WithdrawalSummary", b =>
            {
                b.HasOne("MonthyExpenseControl.Models.Months", "MonthDescription")
                    .WithMany()
                    .HasForeignKey("MonthsId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("MonthDescription");
            });

        modelBuilder.Entity("MonthyExpenseControl.Models.MonthSummary", b =>
            {
                b.Navigation("MonthlyEarnings");

                b.Navigation("MonthlyExpenses");
            });
#pragma warning restore 612, 618
    }
}
