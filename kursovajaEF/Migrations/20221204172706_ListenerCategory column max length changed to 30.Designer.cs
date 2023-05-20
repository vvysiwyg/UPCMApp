﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using kursovajaEF;

namespace kursovajaEF.Migrations
{
    [DbContext(typeof(testDBContext))]
    [Migration("20221204172706_ListenerCategory column max length changed to 30")]
    partial class ListenerCategorycolumnmaxlengthchangedto30
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Russian_Russia.1251")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("kursovajaEF.Contract", b =>
                {
                    b.Property<int>("ContractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("contract_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Bank")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)")
                        .HasColumnName("bank");

                    b.Property<string>("Certificate")
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)")
                        .HasColumnName("certificate");

                    b.Property<string>("Crn")
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)")
                        .HasColumnName("crn");

                    b.Property<string>("ExpulsionDate")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("expulsion_date");

                    b.Property<string>("IssueCertificate")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("issue_certificate");

                    b.Property<string>("ListenedHours")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)")
                        .HasColumnName("listened_hours");

                    b.Property<bool?>("Paid40pct")
                        .HasColumnType("boolean")
                        .HasColumnName("paid_40pct");

                    b.Property<string>("PayDate40pct")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("pay_date_40pct");

                    b.Property<decimal?>("PayedSum")
                        .HasPrecision(8, 2)
                        .HasColumnType("numeric(8,2)")
                        .HasColumnName("payed_sum");

                    b.Property<string>("PaymentDeadline")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("payment_deadline");

                    b.Property<decimal?>("RestOfSum")
                        .HasPrecision(8, 2)
                        .HasColumnType("numeric(8,2)")
                        .HasColumnName("rest_of_sum");

                    b.Property<decimal?>("TotalSum")
                        .HasPrecision(8, 2)
                        .HasColumnType("numeric(8,2)")
                        .HasColumnName("total_sum");

                    b.Property<string>("TransferGroup")
                        .HasMaxLength(4)
                        .HasColumnType("character varying(4)")
                        .HasColumnName("transfer_group");

                    b.Property<string>("WhoPay")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)")
                        .HasColumnName("who_pay");

                    b.HasKey("ContractId");

                    b.ToTable("contracts");
                });

            modelBuilder.Entity("kursovajaEF.ContractInfo", b =>
                {
                    b.Property<int>("ContractInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("contract_info_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ContractId")
                        .HasColumnType("integer")
                        .HasColumnName("contract_id");

                    b.Property<int?>("DisciplineId")
                        .HasColumnType("integer")
                        .HasColumnName("discipline_id");

                    b.Property<string>("DisciplineName")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("discipline_name");

                    b.Property<short?>("NumOfPeople")
                        .HasColumnType("smallint")
                        .HasColumnName("num_of_people");

                    b.Property<short?>("StudyHours")
                        .HasColumnType("smallint")
                        .HasColumnName("study_hours");

                    b.HasKey("ContractInfoId");

                    b.HasIndex("ContractId");

                    b.HasIndex("DisciplineId");

                    b.ToTable("contract_info");
                });

            modelBuilder.Entity("kursovajaEF.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("department_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DepartmentName")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("department_name");

                    b.HasKey("DepartmentId");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("kursovajaEF.Discipline", b =>
                {
                    b.Property<int>("DisciplineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("discipline_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DisciplineName")
                        .HasMaxLength(65)
                        .HasColumnType("character varying(65)")
                        .HasColumnName("discipline_name");

                    b.Property<short?>("HoursOfStudy")
                        .HasColumnType("smallint")
                        .HasColumnName("hours_of_study");

                    b.Property<string>("StudyPeriod")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("study_period");

                    b.HasKey("DisciplineId");

                    b.ToTable("disciplines");
                });

            modelBuilder.Entity("kursovajaEF.DisciplinesTeacher", b =>
                {
                    b.Property<int>("DisciplineId")
                        .HasColumnType("integer")
                        .HasColumnName("discipline_id");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("integer")
                        .HasColumnName("teacher_id");

                    b.HasKey("DisciplineId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.HasIndex(new[] { "DisciplineId", "TeacherId" }, "unique_dis_teach")
                        .IsUnique();

                    b.ToTable("disciplines_teachers");
                });

            modelBuilder.Entity("kursovajaEF.DisciplinesTimetable", b =>
                {
                    b.Property<int>("DisciplineId")
                        .HasColumnType("integer")
                        .HasColumnName("discipline_id");

                    b.Property<int>("TtId")
                        .HasColumnType("integer")
                        .HasColumnName("tt_id");

                    b.HasIndex("TtId");

                    b.HasIndex(new[] { "DisciplineId", "TtId" }, "unique_dis_time")
                        .IsUnique();

                    b.ToTable("disciplines_timetable");
                });

            modelBuilder.Entity("kursovajaEF.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("group_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("DisciplineId")
                        .HasColumnType("integer")
                        .HasColumnName("discipline_id");

                    b.Property<string>("DisciplineName")
                        .HasMaxLength(65)
                        .HasColumnType("character varying(65)")
                        .HasColumnName("discipline_name");

                    b.Property<string>("GroupNum")
                        .HasMaxLength(4)
                        .HasColumnType("character varying(4)")
                        .HasColumnName("group_num");

                    b.Property<int?>("NumOfHours")
                        .HasColumnType("integer")
                        .HasColumnName("num_of_hours");

                    b.HasKey("GroupId");

                    b.HasIndex("DisciplineId");

                    b.ToTable("groups");
                });

            modelBuilder.Entity("kursovajaEF.GroupInfo", b =>
                {
                    b.Property<int>("GroupInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("group_info_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("EndLearning")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("end_learning");

                    b.Property<string>("EndTime")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)")
                        .HasColumnName("end_time");

                    b.Property<int?>("GroupId")
                        .HasColumnType("integer")
                        .HasColumnName("group_id");

                    b.Property<string>("StartLearning")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("start_learning");

                    b.Property<string>("StartTime")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)")
                        .HasColumnName("start_time");

                    b.Property<string>("Weekday")
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)")
                        .HasColumnName("weekday");

                    b.HasKey("GroupInfoId");

                    b.HasIndex("GroupId");

                    b.ToTable("group_info");
                });

            modelBuilder.Entity("kursovajaEF.GroupInfoTeacher", b =>
                {
                    b.Property<int?>("GroupInfoId")
                        .HasColumnType("integer")
                        .HasColumnName("group_info_id");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("integer")
                        .HasColumnName("teacher_id");

                    b.HasKey("GroupInfoId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("group_info_teacher");
                });

            modelBuilder.Entity("kursovajaEF.GroupsListener", b =>
                {
                    b.Property<int?>("GroupId")
                        .HasColumnType("integer")
                        .HasColumnName("group_id");

                    b.Property<int?>("ListenerId")
                        .HasColumnType("integer")
                        .HasColumnName("listener_id");

                    b.HasIndex("GroupId");

                    b.HasIndex("ListenerId");

                    b.ToTable("groups_listeners");
                });

            modelBuilder.Entity("kursovajaEF.GroupsTeacher", b =>
                {
                    b.Property<int>("GroupId")
                        .HasColumnType("integer")
                        .HasColumnName("group_id");

                    b.Property<int>("TeacherId")
                        .HasColumnType("integer")
                        .HasColumnName("teacher_id");

                    b.HasIndex("TeacherId");

                    b.HasIndex(new[] { "GroupId", "TeacherId" }, "unique_gr_teach")
                        .IsUnique();

                    b.ToTable("groups_teachers");
                });

            modelBuilder.Entity("kursovajaEF.GroupsTimetable", b =>
                {
                    b.Property<int>("GroupId")
                        .HasColumnType("integer")
                        .HasColumnName("group_id");

                    b.Property<int>("TtId")
                        .HasColumnType("integer")
                        .HasColumnName("tt_id");

                    b.HasIndex("TtId");

                    b.HasIndex(new[] { "GroupId", "TtId" }, "unique_gr_time")
                        .IsUnique();

                    b.ToTable("groups_timetable");
                });

            modelBuilder.Entity("kursovajaEF.Listener", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasDefaultValueSql("nextval('list_id_seq'::regclass)");

                    b.Property<int?>("Code")
                        .HasColumnType("integer")
                        .HasColumnName("code");

                    b.Property<int?>("ContractId")
                        .HasColumnType("integer")
                        .HasColumnName("contract_id");

                    b.Property<string>("Doi")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("doi");

                    b.Property<string>("Email")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)")
                        .HasColumnName("email");

                    b.Property<string>("Firstname")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("firstname");

                    b.Property<string>("Issued")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("issued");

                    b.Property<string>("Lastname")
                        .HasMaxLength(24)
                        .HasColumnType("character varying(24)")
                        .HasColumnName("lastname");

                    b.Property<string>("ListenerCategory")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("listener_category");

                    b.Property<string>("Matriculation")
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)")
                        .HasColumnName("matriculation");

                    b.Property<string>("Midname")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("midname");

                    b.Property<int?>("Num")
                        .HasColumnType("integer")
                        .HasColumnName("num");

                    b.Property<decimal?>("PhoneNum")
                        .HasPrecision(11)
                        .HasColumnType("numeric(11)")
                        .HasColumnName("phone_num");

                    b.Property<string>("Pob")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)")
                        .HasColumnName("pob");

                    b.Property<string>("SchoolGrade")
                        .HasMaxLength(7)
                        .HasColumnType("character varying(7)")
                        .HasColumnName("school_grade");

                    b.Property<string>("SchoolName")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)")
                        .HasColumnName("school_name");

                    b.Property<int?>("Series")
                        .HasColumnType("integer")
                        .HasColumnName("series");

                    b.Property<string>("Sex")
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)")
                        .HasColumnName("sex");

                    b.Property<string>("Yob")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("yob");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ContractId" }, "unique_contract_id")
                        .IsUnique();

                    b.ToTable("listeners");
                });

            modelBuilder.Entity("kursovajaEF.ListenerWish", b =>
                {
                    b.Property<int>("WishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("wish_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ContractId")
                        .HasColumnType("integer")
                        .HasColumnName("contract_id");

                    b.Property<string>("EndTime")
                        .HasColumnType("character varying")
                        .HasColumnName("end_time");

                    b.Property<string>("StartTime")
                        .HasColumnType("character varying")
                        .HasColumnName("start_time");

                    b.Property<string>("Weekday")
                        .HasColumnType("character varying")
                        .HasColumnName("weekday");

                    b.HasKey("WishId")
                        .HasName("listener_wishes_pkey");

                    b.HasIndex("ContractId");

                    b.ToTable("listener_wishes");
                });

            modelBuilder.Entity("kursovajaEF.Models.GroupInfoContractInfo", b =>
                {
                    b.Property<int>("GroupInfoId")
                        .HasColumnType("integer")
                        .HasColumnName("group_info_id");

                    b.Property<int>("ContractInfoId")
                        .HasColumnType("integer")
                        .HasColumnName("contract_info_id");

                    b.HasKey("GroupInfoId", "ContractInfoId");

                    b.HasIndex("ContractInfoId");

                    b.ToTable("group_info_contract_info");
                });

            modelBuilder.Entity("kursovajaEF.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("teacher_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Degree")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("degree");

                    b.Property<string>("Dob")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("dob");

                    b.Property<string>("Email")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)")
                        .HasColumnName("email");

                    b.Property<string>("Fio")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)")
                        .HasColumnName("fio");

                    b.Property<string>("OverallExperience")
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)")
                        .HasColumnName("overall_experience");

                    b.Property<string>("PedagogicalExperience")
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)")
                        .HasColumnName("pedagogical_experience");

                    b.Property<decimal?>("PhoneNum")
                        .HasPrecision(11)
                        .HasColumnType("numeric(11)")
                        .HasColumnName("phone_num");

                    b.Property<string>("Position")
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("position");

                    b.Property<string>("Title")
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("title");

                    b.HasKey("TeacherId");

                    b.ToTable("teachers");
                });

            modelBuilder.Entity("kursovajaEF.Timetable", b =>
                {
                    b.Property<int>("TtId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("tt_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("EndTime")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)")
                        .HasColumnName("end_time");

                    b.Property<string>("StartTime")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)")
                        .HasColumnName("start_time");

                    b.Property<string>("Weekday")
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)")
                        .HasColumnName("weekday");

                    b.HasKey("TtId")
                        .HasName("timetable_pkey");

                    b.ToTable("timetable");
                });

            modelBuilder.Entity("kursovajaEF.ContractInfo", b =>
                {
                    b.HasOne("kursovajaEF.Contract", "Contract")
                        .WithMany("ContractInfos")
                        .HasForeignKey("ContractId")
                        .HasConstraintName("contract_id_fkey")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("kursovajaEF.Discipline", "Discipline")
                        .WithMany("ContractInfos")
                        .HasForeignKey("DisciplineId")
                        .HasConstraintName("discipline_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Contract");

                    b.Navigation("Discipline");
                });

            modelBuilder.Entity("kursovajaEF.DisciplinesTeacher", b =>
                {
                    b.HasOne("kursovajaEF.Discipline", "Discipline")
                        .WithMany()
                        .HasForeignKey("DisciplineId")
                        .HasConstraintName("FK2")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kursovajaEF.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .HasConstraintName("teacher_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discipline");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("kursovajaEF.DisciplinesTimetable", b =>
                {
                    b.HasOne("kursovajaEF.Discipline", "Discipline")
                        .WithMany()
                        .HasForeignKey("DisciplineId")
                        .HasConstraintName("discipline_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kursovajaEF.Timetable", "Tt")
                        .WithMany()
                        .HasForeignKey("TtId")
                        .HasConstraintName("tt_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discipline");

                    b.Navigation("Tt");
                });

            modelBuilder.Entity("kursovajaEF.Group", b =>
                {
                    b.HasOne("kursovajaEF.Discipline", "Discipline")
                        .WithMany("Groups")
                        .HasForeignKey("DisciplineId")
                        .HasConstraintName("discipline_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Discipline");
                });

            modelBuilder.Entity("kursovajaEF.GroupInfo", b =>
                {
                    b.HasOne("kursovajaEF.Group", "Group")
                        .WithMany("GroupInfos")
                        .HasForeignKey("GroupId")
                        .HasConstraintName("group_id_fkey")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Group");
                });

            modelBuilder.Entity("kursovajaEF.GroupInfoTeacher", b =>
                {
                    b.HasOne("kursovajaEF.GroupInfo", "GroupInfo")
                        .WithMany()
                        .HasForeignKey("GroupInfoId")
                        .HasConstraintName("group_info_fkey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kursovajaEF.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .HasConstraintName("teacher_fkey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroupInfo");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("kursovajaEF.GroupsListener", b =>
                {
                    b.HasOne("kursovajaEF.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .HasConstraintName("group_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("kursovajaEF.Listener", "Listener")
                        .WithMany()
                        .HasForeignKey("ListenerId")
                        .HasConstraintName("listener_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Group");

                    b.Navigation("Listener");
                });

            modelBuilder.Entity("kursovajaEF.GroupsTeacher", b =>
                {
                    b.HasOne("kursovajaEF.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .HasConstraintName("group_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kursovajaEF.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .HasConstraintName("teacher_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("kursovajaEF.GroupsTimetable", b =>
                {
                    b.HasOne("kursovajaEF.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .HasConstraintName("group_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kursovajaEF.Timetable", "Tt")
                        .WithMany()
                        .HasForeignKey("TtId")
                        .HasConstraintName("tt_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Tt");
                });

            modelBuilder.Entity("kursovajaEF.Listener", b =>
                {
                    b.HasOne("kursovajaEF.Contract", "Contract")
                        .WithOne("Listener")
                        .HasForeignKey("kursovajaEF.Listener", "ContractId")
                        .HasConstraintName("contracts_fkey")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Contract");
                });

            modelBuilder.Entity("kursovajaEF.ListenerWish", b =>
                {
                    b.HasOne("kursovajaEF.Contract", "Contract")
                        .WithMany("ListenerWishes")
                        .HasForeignKey("ContractId")
                        .HasConstraintName("contract_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Contract");
                });

            modelBuilder.Entity("kursovajaEF.Models.GroupInfoContractInfo", b =>
                {
                    b.HasOne("kursovajaEF.ContractInfo", "ContractInfo")
                        .WithMany()
                        .HasForeignKey("ContractInfoId")
                        .HasConstraintName("contract_info_fkey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kursovajaEF.GroupInfo", "GroupInfo")
                        .WithMany()
                        .HasForeignKey("GroupInfoId")
                        .HasConstraintName("group_info_fkey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContractInfo");

                    b.Navigation("GroupInfo");
                });

            modelBuilder.Entity("kursovajaEF.Contract", b =>
                {
                    b.Navigation("ContractInfos");

                    b.Navigation("Listener");

                    b.Navigation("ListenerWishes");
                });

            modelBuilder.Entity("kursovajaEF.Discipline", b =>
                {
                    b.Navigation("ContractInfos");

                    b.Navigation("Groups");
                });

            modelBuilder.Entity("kursovajaEF.Group", b =>
                {
                    b.Navigation("GroupInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
