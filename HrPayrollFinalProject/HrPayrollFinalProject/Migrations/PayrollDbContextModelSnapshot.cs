﻿// <auto-generated />
using System;
using HrPayrollFinalProject.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HrPayrollFinalProject.Migrations
{
    [DbContext(typeof(PayrollDbContext))]
    partial class PayrollDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HrPayrollFinalProject.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Surname");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

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

                    b.Property<int>("EmployeesId");

                    b.Property<bool>("IsHead");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

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

            modelBuilder.Entity("HrPayrollFinalProject.Models.Continuity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Attendance");

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

            modelBuilder.Entity("HrPayrollFinalProject.Models.EmployeeAccuredSalary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccuredSalary");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName");

                    b.Property<int>("PhoneNumber");

                    b.Property<string>("SecondName");

                    b.HasKey("Id");

                    b.ToTable("EmployeeAccureds");
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Employees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .IsRequired();

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("Education")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FamilyState")
                        .IsRequired();

                    b.Property<string>("FathersName")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(2000);

                    b.Property<string>("Influnce")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("Number")
                        .HasMaxLength(13);

                    b.Property<DateTime>("PassportExpireDate");

                    b.Property<string>("PassportNo")
                        .IsRequired();

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("HrPayrollFinalProject.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bonus");

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

                    b.Property<int>("BranchId");

                    b.Property<int>("CompanyId");

                    b.Property<int>("DepartmentId");

                    b.Property<int>("HoldingId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("HoldingId");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
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
                    b.HasOne("HrPayrollFinalProject.Models.Branch", "Branch")
                        .WithMany("Positions")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HrPayrollFinalProject.Models.Company", "Company")
                        .WithMany("Positions")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HrPayrollFinalProject.Models.Department", "Department")
                        .WithMany("Positions")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HrPayrollFinalProject.Models.Holding", "Holding")
                        .WithMany("Positions")
                        .HasForeignKey("HoldingId")
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HrPayrollFinalProject.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HrPayrollFinalProject.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HrPayrollFinalProject.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HrPayrollFinalProject.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
