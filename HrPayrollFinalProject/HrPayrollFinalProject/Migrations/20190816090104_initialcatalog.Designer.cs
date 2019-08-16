﻿// <auto-generated />
using System;
using HrPayrollFinalProject.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HrPayrollFinalProject.Migrations
{
    [DbContext(typeof(PayrollDbContext))]
    [Migration("20190816090104_initialcatalog")]
    partial class initialcatalog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HrPayrollFinalProject.Models.Bonus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int>("EmlpoyeesId");

                    b.Property<int>("EmployeesId");

                    b.HasKey("Id");

                    b.HasIndex("EmployeesId");

                    b.ToTable("Bonus");
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyId");

                    b.Property<int>("EmployeesId");

                    b.Property<bool>("IsHead");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("EmployeesId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HoldingId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("HoldingId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.CompanyDepartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<int>("DepartmentId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("CompanyDepartments");
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Continuity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("EmployeesId");

                    b.Property<bool>("Permission");

                    b.Property<string>("Reason")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("EmployeesId");

                    b.ToTable("Continuities");
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Employees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .IsRequired();

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("Education");

                    b.Property<int>("FamilyState");

                    b.Property<string>("FathersName")
                        .IsRequired();

                    b.Property<bool>("Gender");

                    b.Property<string>("Influnce")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("PassportExpireDate");

                    b.Property<string>("PassportNo")
                        .IsRequired();

                    b.Property<string>("Surname")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchId");

                    b.Property<DateTime>("Date");

                    b.Property<decimal>("FromAmount");

                    b.Property<decimal>("ToAmount");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Holding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Holdings");
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.HoldingDepartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentId");

                    b.Property<int>("HoldingId");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("HoldingId");

                    b.ToTable("HoldingDepartments");
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.OldWorkPlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeesId");

                    b.Property<DateTime>("FireDate");

                    b.Property<string>("FireReason")
                        .IsRequired();

                    b.Property<DateTime>("HireDate");

                    b.Property<string>("WorkPLaceName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("EmployeesId");

                    b.ToTable("OldWorkPlaces");
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Payroll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bonus");

                    b.Property<DateTime>("Date");

                    b.Property<int>("EmployeesId");

                    b.Property<int>("Penalty");

                    b.Property<int>("Salary");

                    b.Property<int>("TotalSalary");

                    b.HasKey("Id");

                    b.HasIndex("EmployeesId");

                    b.ToTable("Payrolls");
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Penalty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int>("EmployeesId");

                    b.HasKey("Id");

                    b.HasIndex("EmployeesId");

                    b.ToTable("Penalties");
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Salary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<int>("PositionId");

                    b.Property<decimal>("SalaryCost");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("PositionId");

                    b.ToTable("Salaries");
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Vacation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeesId");

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("EmployeesId");

                    b.ToTable("Vacations");
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.WorkPlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchId");

                    b.Property<int>("EmployeesId");

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("EntryDate");

                    b.Property<int>("PositionId");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("EmployeesId");

                    b.HasIndex("PositionId");

                    b.ToTable("WorkPlaces");
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Bonus", b =>
                {
                    b.HasOne("HrPayrollFinalProject.Models.Employees", "Employees")
                        .WithMany("Bonus")
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Branch", b =>
                {
                    b.HasOne("HrPayrollFinalProject.Models.Company")
                        .WithMany("Branches")
                        .HasForeignKey("CompanyId");

                    b.HasOne("HrPayrollFinalProject.Models.Employees", "Employees")
                        .WithMany("Branches")
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Company", b =>
                {
                    b.HasOne("HrPayrollFinalProject.Models.Holding", "Holding")
                        .WithMany()
                        .HasForeignKey("HoldingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.CompanyDepartment", b =>
                {
                    b.HasOne("HrPayrollFinalProject.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HrPayrollFinalProject.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Continuity", b =>
                {
                    b.HasOne("HrPayrollFinalProject.Models.Employees", "Employees")
                        .WithMany("Continuities")
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Grade", b =>
                {
                    b.HasOne("HrPayrollFinalProject.Models.Branch", "Branch")
                        .WithMany("Grades")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.HoldingDepartment", b =>
                {
                    b.HasOne("HrPayrollFinalProject.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HrPayrollFinalProject.Models.Holding", "Holding")
                        .WithMany()
                        .HasForeignKey("HoldingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.OldWorkPlace", b =>
                {
                    b.HasOne("HrPayrollFinalProject.Models.Employees", "Employees")
                        .WithMany("OldWorkPlaces")
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Payroll", b =>
                {
                    b.HasOne("HrPayrollFinalProject.Models.Employees", "Employees")
                        .WithMany("Payrolls")
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Penalty", b =>
                {
                    b.HasOne("HrPayrollFinalProject.Models.Employees", "Employees")
                        .WithMany("Penalties")
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Position", b =>
                {
                    b.HasOne("HrPayrollFinalProject.Models.Department", "Department")
                        .WithMany("Positions")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Salary", b =>
                {
                    b.HasOne("HrPayrollFinalProject.Models.Company", "Company")
                        .WithMany("Salaries")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HrPayrollFinalProject.Models.Position", "Position")
                        .WithMany("Salaries")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Vacation", b =>
                {
                    b.HasOne("HrPayrollFinalProject.Models.Employees", "Employees")
                        .WithMany("GetVacations")
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.WorkPlace", b =>
                {
                    b.HasOne("HrPayrollFinalProject.Models.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HrPayrollFinalProject.Models.Employees", "Employees")
                        .WithMany("WorkPlaces")
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HrPayrollFinalProject.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
