﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OutOfOffice.DAL;

#nullable disable

namespace OutOfOffice.DAL.Migrations
{
    [DbContext(typeof(OfficeDbContext))]
    [Migration("20240610114651_IsDeactivated_field_Migration")]
    partial class IsDeactivated_field_Migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GeneralEmployeeProject", b =>
                {
                    b.Property<int>("EmployeesId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectsId")
                        .HasColumnType("int");

                    b.HasKey("EmployeesId", "ProjectsId");

                    b.HasIndex("ProjectsId");

                    b.ToTable("GeneralEmployeeProject");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.ApprovalRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApproverId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LeaveRequestId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApproverId");

                    b.HasIndex("LeaveRequestId")
                        .IsUnique();

                    b.ToTable("ApprovalRequests");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.AuthorizationInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ExpiredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("AuthorizationInfos");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Employees.BaseEmployeeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorizationInfoId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("isDeactivated")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BaseEmployeeEntity");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.LeaveRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AbsenceReasonId")
                        .HasColumnType("int");

                    b.Property<int>("ApprovalRequestId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GeneralEmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AbsenceReasonId");

                    b.HasIndex("GeneralEmployeeId");

                    b.ToTable("LeaveRequests");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProjectManagerId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<bool>("isDeactivated")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ProjectManagerId");

                    b.HasIndex("ProjectTypeId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Selections.AbsenceReason", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ReasonDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AbsenceReasons");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Selections.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Selections.ProjectType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectTypes");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Selections.Subdivision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subdivisions");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Employees.AdminEntity", b =>
                {
                    b.HasBaseType("OutOfOffice.DAL.Entity.Employees.BaseEmployeeEntity");

                    b.HasDiscriminator().HasValue("AdminEntity");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Employees.BaseManagerEntity", b =>
                {
                    b.HasBaseType("OutOfOffice.DAL.Entity.Employees.BaseEmployeeEntity");

                    b.HasDiscriminator().HasValue("BaseManagerEntity");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Employees.GeneralEmployee", b =>
                {
                    b.HasBaseType("OutOfOffice.DAL.Entity.Employees.BaseEmployeeEntity");

                    b.Property<int?>("HrMangerId")
                        .HasColumnType("int");

                    b.Property<decimal>("OutOfOfficeBalance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("PositionId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("SubdivisionId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasIndex("HrMangerId");

                    b.HasIndex("Id");

                    b.HasIndex("PositionId");

                    b.HasIndex("SubdivisionId");

                    b.HasDiscriminator().HasValue("GeneralEmployee");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Employees.HrManager", b =>
                {
                    b.HasBaseType("OutOfOffice.DAL.Entity.Employees.BaseManagerEntity");

                    b.HasDiscriminator().HasValue("HrManager");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Employees.ProjectManager", b =>
                {
                    b.HasBaseType("OutOfOffice.DAL.Entity.Employees.BaseManagerEntity");

                    b.HasDiscriminator().HasValue("ProjectManager");
                });

            modelBuilder.Entity("GeneralEmployeeProject", b =>
                {
                    b.HasOne("OutOfOffice.DAL.Entity.Employees.GeneralEmployee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OutOfOffice.DAL.Entity.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.ApprovalRequest", b =>
                {
                    b.HasOne("OutOfOffice.DAL.Entity.Employees.BaseManagerEntity", "Approver")
                        .WithMany("ApprovalRequest")
                        .HasForeignKey("ApproverId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OutOfOffice.DAL.Entity.LeaveRequest", "LeaveRequest")
                        .WithOne("ApprovalRequest")
                        .HasForeignKey("OutOfOffice.DAL.Entity.ApprovalRequest", "LeaveRequestId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Approver");

                    b.Navigation("LeaveRequest");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.AuthorizationInfo", b =>
                {
                    b.HasOne("OutOfOffice.DAL.Entity.Employees.BaseEmployeeEntity", "Employee")
                        .WithOne("AuthorizationInfo")
                        .HasForeignKey("OutOfOffice.DAL.Entity.AuthorizationInfo", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.LeaveRequest", b =>
                {
                    b.HasOne("OutOfOffice.DAL.Entity.Selections.AbsenceReason", "AbsenceReason")
                        .WithMany("LeaveRequests")
                        .HasForeignKey("AbsenceReasonId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OutOfOffice.DAL.Entity.Employees.GeneralEmployee", "GeneralEmployee")
                        .WithMany("LeaveRequests")
                        .HasForeignKey("GeneralEmployeeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AbsenceReason");

                    b.Navigation("GeneralEmployee");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Project", b =>
                {
                    b.HasOne("OutOfOffice.DAL.Entity.Employees.ProjectManager", "ProjectManager")
                        .WithMany("Projects")
                        .HasForeignKey("ProjectManagerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OutOfOffice.DAL.Entity.Selections.ProjectType", "ProjectType")
                        .WithMany("Projects")
                        .HasForeignKey("ProjectTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ProjectManager");

                    b.Navigation("ProjectType");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Employees.GeneralEmployee", b =>
                {
                    b.HasOne("OutOfOffice.DAL.Entity.Employees.HrManager", "HrManager")
                        .WithMany("Partners")
                        .HasForeignKey("HrMangerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OutOfOffice.DAL.Entity.Selections.Position", "Position")
                        .WithMany("Employees")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OutOfOffice.DAL.Entity.Selections.Subdivision", "Subdivision")
                        .WithMany("Employees")
                        .HasForeignKey("SubdivisionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HrManager");

                    b.Navigation("Position");

                    b.Navigation("Subdivision");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Employees.BaseEmployeeEntity", b =>
                {
                    b.Navigation("AuthorizationInfo");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.LeaveRequest", b =>
                {
                    b.Navigation("ApprovalRequest");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Selections.AbsenceReason", b =>
                {
                    b.Navigation("LeaveRequests");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Selections.Position", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Selections.ProjectType", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Selections.Subdivision", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Employees.BaseManagerEntity", b =>
                {
                    b.Navigation("ApprovalRequest");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Employees.GeneralEmployee", b =>
                {
                    b.Navigation("LeaveRequests");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Employees.HrManager", b =>
                {
                    b.Navigation("Partners");
                });

            modelBuilder.Entity("OutOfOffice.DAL.Entity.Employees.ProjectManager", b =>
                {
                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
