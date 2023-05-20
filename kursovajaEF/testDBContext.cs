using System.IO;
using kursovajaEF.Models;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace kursovajaEF
{
    public partial class testDBContext : DbContext
    {
        public testDBContext()
        {
            logWriter = new StreamWriter("log.txt", false);
        }

        public testDBContext(DbContextOptions<testDBContext> options)
            : base(options)
        {
        }

        public string connectionString = "Host=localhost;Port=5432;Database=testDB;Username=postgres;Password=112358;Include Error Detail=true";

        private readonly StreamWriter logWriter;
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<ContractInfo> ContractInfos { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Discipline> Disciplines { get; set; }
        public virtual DbSet<DisciplinesTeacher> DisciplinesTeachers { get; set; }
        public virtual DbSet<DisciplinesTimetable> DisciplinesTimetables { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<GroupInfo> GroupInfos { get; set; }
        public virtual DbSet<GroupInfoTeacher> GroupInfoTeachers { get; set; }
        public virtual DbSet<GroupInfoContractInfo> GroupInfoContractInfos { get; set; }
        public virtual DbSet<GroupsListener> GroupsListeners { get; set; }
        public virtual DbSet<GroupsTeacher> GroupsTeachers { get; set; }
        public virtual DbSet<GroupsTimetable> GroupsTimetables { get; set; }
        public virtual DbSet<Listener> Listeners { get; set; }
        public virtual DbSet<ListenerWish> ListenerWishes { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Timetable> Timetables { get; set; }
        public virtual DbSet<Chair> Chairs { get; set; }
        public virtual DbSet<ListenerEnrollmentOrder> ListenerEnrollmentOrders { get; set; }
        public virtual DbSet<ListenerExpulsionOrder> ListenerExpulsionOrders { get; set; }

        public override void Dispose()
        {
            base.Dispose();
            logWriter.Dispose();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(connectionString);
                optionsBuilder.LogTo(logWriter.WriteLine);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Russian_Russia.1251");

            modelBuilder.HasSequence<int>("ListenerEnrollmentOrderIdSequence", schema: "public")
                .StartsAt(1)
                .HasMax(2147483647)
                .IncrementsBy(1);

            modelBuilder.HasSequence<int>("ListenerExpulsionOrderIdSequence", schema: "public")
                .StartsAt(1)
                .HasMax(2147483647)
                .IncrementsBy(1);

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.ToTable("contracts");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.ListenerId).HasColumnName("listener_id");

                entity.Property(e => e.Certificate)
                    .HasMaxLength(25)
                    .HasColumnName("certificate");

                entity.Property(e => e.Crn)
                    .HasMaxLength(25)
                    .HasColumnName("crn");

                entity.Property(e => e.ExpulsionDate)
                    .HasMaxLength(10)
                    .HasColumnName("expulsion_date");

                entity.Property(e => e.IssueCertificate)
                    .HasMaxLength(10)
                    .HasColumnName("issue_certificate");

                entity.Property(e => e.ListenedHours)
                    .HasMaxLength(5)
                    .HasColumnName("listened_hours");

                entity.Property(e => e.Paid40pct).HasColumnName("paid_40pct");

                entity.Property(e => e.PayDate40pct)
                    .HasMaxLength(10)
                    .HasColumnName("pay_date_40pct");

                entity.Property(e => e.PayedSum)
                    .HasPrecision(8, 2)
                    .HasColumnName("payed_sum");

                entity.Property(e => e.PaymentDeadline)
                    .HasMaxLength(10)
                    .HasColumnName("payment_deadline");

                entity.Property(e => e.RestOfSum)
                    .HasPrecision(8, 2)
                    .HasColumnName("rest_of_sum");

                entity.Property(e => e.TotalSum)
                    .HasPrecision(8, 2)
                    .HasColumnName("total_sum");

                entity.Property(e => e.TransferGroup)
                    .HasMaxLength(4)
                    .HasColumnName("transfer_group");

                entity.Property(e => e.WhoPay)
                    .HasMaxLength(55)
                    .HasColumnName("who_pay");

                entity.Property(e => e.Bank)
                    .HasMaxLength(55)
                    .HasColumnName("bank");

                entity.HasOne(d => d.Listener)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.ListenerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("listener_id_fkey2");
            });

            modelBuilder.Entity<ContractInfo>(entity =>
            {
                entity.ToTable("contract_info");

                entity.Property(e => e.ContractInfoId).HasColumnName("contract_info_id");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.NumOfPeople).HasColumnName("num_of_people");

                entity.Property(e => e.StudyHours).HasColumnName("study_hours");

                entity.Property(e => e.DisciplineId).HasColumnName("discipline_id");

                entity.HasIndex(e => e.ContractId, "unique_index_contract_id")
                    .IsUnique();

                entity.Property(e => e.DisciplineName)
                    .HasMaxLength(30)
                    .HasColumnName("discipline_name");

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.ContractInfos)
                    .HasForeignKey(d => d.ContractId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("contract_id_fkey");

                entity.HasOne(d => d.Discipline)
                    .WithMany(p => p.ContractInfos)
                    .HasForeignKey(d => d.DisciplineId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("discipline_id_fkey");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("departments");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(100)
                    .HasColumnName("department_name");
            });
            
            modelBuilder.Entity<Discipline>(entity =>
            {
                entity.ToTable("disciplines");

                entity.Property(e => e.DisciplineId).HasColumnName("discipline_id");

                entity.Property(e => e.DisciplineName)
                    .HasMaxLength(65)
                    .HasColumnName("discipline_name");

                entity.Property(e => e.HoursOfStudy).HasColumnName("hours_of_study");

                entity.Property(e => e.StudyPeriod)
                    .HasMaxLength(20)
                    .HasColumnName("study_period");
            });

            modelBuilder.Entity<DisciplinesTeacher>(entity =>
            {
                entity.HasKey(keys => new { keys.DisciplineId, keys.TeacherId });

                entity.ToTable("disciplines_teachers");

                entity.Property(e => e.DisciplineId).HasColumnName("discipline_id");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Date).
                    HasMaxLength(10).
                    HasColumnName("date");

                entity.HasOne(d => d.Discipline)
                    .WithMany()
                    .HasForeignKey(d => d.DisciplineId)
                    .HasConstraintName("FK2");

                entity.HasOne(d => d.Teacher)
                    .WithMany()
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("teacher_id_fkey");
            });

            modelBuilder.Entity<DisciplinesTimetable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("disciplines_timetable");

                entity.HasIndex(e => new { e.DisciplineId, e.TtId }, "unique_dis_time")
                    .IsUnique();

                entity.Property(e => e.DisciplineId).HasColumnName("discipline_id");

                entity.Property(e => e.TtId).HasColumnName("tt_id");

                entity.HasOne(d => d.Discipline)
                    .WithMany()
                    .HasForeignKey(d => d.DisciplineId)
                    .HasConstraintName("discipline_id_fkey");

                entity.HasOne(d => d.Tt)
                    .WithMany()
                    .HasForeignKey(d => d.TtId)
                    .HasConstraintName("tt_id_fkey");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("groups");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.DisciplineId).HasColumnName("discipline_id");

                entity.Property(e => e.DisciplineName)
                    .HasMaxLength(65)
                    .HasColumnName("discipline_name");

                entity.Property(e => e.GroupNum)
                    .HasMaxLength(4)
                    .HasColumnName("group_num");

                entity.Property(e => e.NumOfHours).HasColumnName("num_of_hours");

                entity.HasOne(d => d.Discipline)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.DisciplineId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("discipline_id_fkey");
            });

            modelBuilder.Entity<GroupInfo>(entity =>
            {
                entity.ToTable("group_info");

                entity.Property(e => e.GroupInfoId).HasColumnName("group_info_id");

                entity.Property(e => e.EndLearning)
                    .HasMaxLength(10)
                    .HasColumnName("end_learning");

                entity.Property(e => e.EndTime)
                    .HasMaxLength(5)
                    .HasColumnName("end_time");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.StartLearning)
                    .HasMaxLength(10)
                    .HasColumnName("start_learning");

                entity.Property(e => e.StartTime)
                    .HasMaxLength(5)
                    .HasColumnName("start_time");

                entity.Property(e => e.Weekday)
                    .HasMaxLength(11)
                    .HasColumnName("weekday");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupInfos)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("group_id_fkey");
            });

            modelBuilder.Entity<GroupInfoTeacher>(entity =>
            {
                entity.HasKey(keys => new { keys.GroupInfoId, keys.TeacherId });

                entity.ToTable("group_info_teacher");

                entity.Property(e => e.GroupInfoId).HasColumnName("group_info_id");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.HasOne(d => d.GroupInfo)
                    .WithMany()
                    .HasForeignKey(d => d.GroupInfoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("group_info_fkey");

                entity.HasOne(d => d.Teacher)
                    .WithMany()
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("teacher_fkey");
            });

            modelBuilder.Entity<GroupInfoContractInfo>(entity =>
            {
                entity.HasKey(keys => new { keys.GroupInfoId, keys.ContractInfoId });

                entity.ToTable("group_info_contract_info");

                entity.Property(e => e.GroupInfoId).HasColumnName("group_info_id");

                entity.Property(e => e.ContractInfoId).HasColumnName("contract_info_id");

                entity.HasOne(d => d.GroupInfo)
                    .WithMany()
                    .HasForeignKey(d => d.GroupInfoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("group_info_fkey");

                entity.HasOne(d => d.ContractInfo)
                    .WithMany()
                    .HasForeignKey(d => d.ContractInfoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("contract_info_fkey");
            });

            modelBuilder.Entity<GroupsListener>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("groups_listeners");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.ListenerId).HasColumnName("listener_id");

                entity.HasOne(d => d.Group)
                    .WithMany()
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("group_id_fkey");

                entity.HasOne(d => d.Listener)
                    .WithMany()
                    .HasForeignKey(d => d.ListenerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("listener_id_fkey");
            });

            modelBuilder.Entity<GroupsTeacher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("groups_teachers");

                entity.HasIndex(e => new { e.GroupId, e.TeacherId }, "unique_gr_teach")
                    .IsUnique();

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.HasOne(d => d.Group)
                    .WithMany()
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("group_id_fkey");

                entity.HasOne(d => d.Teacher)
                    .WithMany()
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("teacher_id_fkey");
            });

            modelBuilder.Entity<GroupsTimetable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("groups_timetable");

                entity.HasIndex(e => new { e.GroupId, e.TtId }, "unique_gr_time")
                    .IsUnique();

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.TtId).HasColumnName("tt_id");

                entity.HasOne(d => d.Group)
                    .WithMany()
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("group_id_fkey");

                entity.HasOne(d => d.Tt)
                    .WithMany()
                    .HasForeignKey(d => d.TtId)
                    .HasConstraintName("tt_id_fkey");
            });

            modelBuilder.Entity<Listener>(entity =>
            {
                entity.ToTable("listeners");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('list_id_seq'::regclass)");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Doi)
                    .HasMaxLength(10)
                    .HasColumnName("doi");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .HasColumnName("email");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(20)
                    .HasColumnName("firstname");

                entity.Property(e => e.Issued)
                    .HasMaxLength(150)
                    .HasColumnName("issued");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(24)
                    .HasColumnName("lastname");

                entity.Property(e => e.Matriculation)
                    .HasMaxLength(3)
                    .HasColumnName("matriculation");

                entity.Property(e => e.Midname)
                    .HasMaxLength(20)
                    .HasColumnName("midname");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.PhoneNum)
                    .HasPrecision(11)
                    .HasColumnName("phone_num");

                entity.Property(e => e.Pob)
                    .HasMaxLength(60)
                    .HasColumnName("pob");

                entity.Property(e => e.SchoolGrade)
                    .HasMaxLength(7)
                    .HasColumnName("school_grade");

                entity.Property(e => e.SchoolName)
                    .HasMaxLength(60)
                    .HasColumnName("school_name");

                entity.Property(e => e.Series).HasColumnName("series");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .HasColumnName("sex");

                entity.Property(e => e.Yob)
                    .HasMaxLength(10)
                    .HasColumnName("yob");

                entity.Property(e => e.ListenerCategory)
                    .HasMaxLength(30)
                    .HasColumnName("listener_category");
            });

            modelBuilder.Entity<ListenerWish>(entity =>
            {
                entity.HasKey(e => e.WishId)
                    .HasName("listener_wishes_pkey");

                entity.ToTable("listener_wishes");

                entity.Property(e => e.WishId).HasColumnName("wish_id");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.EndTime)
                    .HasColumnType("character varying")
                    .HasColumnName("end_time");

                entity.Property(e => e.StartTime)
                    .HasColumnType("character varying")
                    .HasColumnName("start_time");

                entity.Property(e => e.Weekday)
                    .HasColumnType("character varying")
                    .HasColumnName("weekday");

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.ListenerWishes)
                    .HasForeignKey(d => d.ContractId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("contract_id_fkey");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("teachers");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.Property(e => e.Degree)
                    .HasMaxLength(100)
                    .HasColumnName("degree");

                entity.Property(e => e.Dob)
                    .HasMaxLength(10)
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .HasColumnName("email");

                entity.Property(e => e.Fio)
                    .HasMaxLength(60)
                    .HasColumnName("fio");

                entity.Property(e => e.OverallExperience)
                    .HasMaxLength(12)
                    .HasColumnName("overall_experience");

                entity.Property(e => e.PedagogicalExperience)
                    .HasMaxLength(12)
                    .HasColumnName("pedagogical_experience");

                entity.Property(e => e.PhoneNum)
                    .HasPrecision(11)
                    .HasColumnName("phone_num");

                entity.Property(e => e.Position)
                    .HasMaxLength(40)
                    .HasColumnName("position");

                entity.Property(e => e.Title)
                    .HasMaxLength(40)
                    .HasColumnName("title");

                entity.Property(e => e.ChairId).HasColumnName("chair_id");

                entity.HasOne(t => t.Chair)
                    .WithMany(c => c.Teachers)
                    .HasForeignKey(t => t.ChairId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("chair_id_fkey");
            });

            modelBuilder.Entity<Timetable>(entity =>
            {
                entity.HasKey(e => e.TtId)
                    .HasName("timetable_pkey");

                entity.ToTable("timetable");

                entity.Property(e => e.TtId).HasColumnName("tt_id");

                entity.Property(e => e.EndTime)
                    .HasMaxLength(5)
                    .HasColumnName("end_time");

                entity.Property(e => e.StartTime)
                    .HasMaxLength(5)
                    .HasColumnName("start_time");

                entity.Property(e => e.Weekday)
                    .HasMaxLength(11)
                    .HasColumnName("weekday");
            });

            modelBuilder.Entity<Chair>(entity =>
            {
                entity.ToTable("chairs");

                entity.HasKey(key => key.ChairId);

                entity.Property(e => e.ChairId).HasColumnName("chair_id");

                entity.Property(e => e.ChairName)
                    .HasMaxLength(65)
                    .HasColumnName("chair_name");
            });

            modelBuilder.Entity<ListenerEnrollmentOrder>(entity =>
            {
                entity.ToTable("listener_enrollment_orders");

                entity.HasKey(e => e.ListenerEnrollmentOrderId)
                    .HasName("listener_enrollment_orders_pkey");

                entity.Property(e => e.ListenerEnrollmentOrderId)
                    .HasColumnName("listener_enrollment_order_id")
                    .HasDefaultValueSql("nextval('\"ListenerEnrollmentOrderIdSequence\"')");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Date)
                    .HasMaxLength(10)
                    .HasColumnName("date")
                    .IsRequired();

                entity.HasIndex(e => e.ContractId, "unique_index_contract_id_listener_enrollment_orders")
                    .IsUnique();

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.ListenerEnrollmentOrders)
                    .HasForeignKey(d => d.ContractId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("listener_enrollment_orders_contract_id__fkey");
            });

            modelBuilder.Entity<ListenerExpulsionOrder>(entity =>
            {
                entity.ToTable("listener_expulsion_orders");

                entity.HasKey(e => e.ListenerExpulsionOrderId)
                    .HasName("listener_expulsion_orders_pkey");

                entity.Property(e => e.ListenerExpulsionOrderId)
                    .HasColumnName("listener_expulsion_order_id")
                    .HasDefaultValueSql("nextval('\"ListenerExpulsionOrderIdSequence\"')");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Date)
                    .HasMaxLength(10)
                    .HasColumnName("date")
                    .IsRequired();

                entity.HasIndex(e => e.ContractId, "unique_index_contract_id_listener_expulsion_orders")
                    .IsUnique();

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.ListenerExpulsionOrders)
                    .HasForeignKey(d => d.ContractId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("listener_expulsion_orders_contract_id__fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
