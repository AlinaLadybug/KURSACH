using Microsoft.EntityFrameworkCore;

namespace LAB9.Models.DataBase
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agrotechnic> Agrotechnic { get; set; }
        public virtual DbSet<AgrotechnicType> AgrotechnicType { get; set; }
        public virtual DbSet<Command> Command { get; set; }
        public virtual DbSet<Crop> Crop { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<Requirement> Requirement { get; set; }
        public virtual DbSet<Roadmap> Roadmap { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=IS62_23;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agrotechnic>(entity =>
            {
                entity.HasKey(e => e.CarId);

                entity.Property(e => e.CarId).HasColumnName("Car_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.TypeId).HasColumnName("Type_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Agrotechnic)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__Agrotechn__Emplo__47DBAE45");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Agrotechnic)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK__Agrotechn__Type___48CFD27E");
            });

            modelBuilder.Entity<AgrotechnicType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.Property(e => e.TypeId).HasColumnName("Type_ID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Command>(entity =>
            {
                entity.Property(e => e.CommandId).HasColumnName("Command_ID");

                entity.Property(e => e.CropId).HasColumnName("Crop_ID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sum).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Crop>(entity =>
            {
                entity.Property(e => e.CropId).HasColumnName("Crop_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasIndex(e => e.Passport)
                    .HasName("unique_employee")
                    .IsUnique();

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.CommandId).HasColumnName("Command_ID");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Passport)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Specialization)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Command)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.CommandId)
                    .HasConstraintName("FK__Employee__Comman__46E78A0C");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_Id");

                entity.Property(e => e.CropId).HasColumnName("Crop_ID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sum).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Crop)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.CropId)
                    .HasConstraintName("FK__Invoice__Crop_ID__3C69FB99");
            });

            modelBuilder.Entity<Requirement>(entity =>
            {
                entity.Property(e => e.RequirementId).HasColumnName("Requirement_ID");

                entity.Property(e => e.CarId).HasColumnName("Car_ID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sum).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Requirement)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK__Requireme__Car_I__5165187F");
            });

            modelBuilder.Entity<Roadmap>(entity =>
            {
                entity.Property(e => e.RoadmapId).HasColumnName("Roadmap_ID");

                entity.Property(e => e.CarId).HasColumnName("Car_ID");

                entity.Property(e => e.CropId).HasColumnName("Crop_ID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sum).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Roadmap)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK__Roadmap__Car_ID__4CA06362");

                entity.HasOne(d => d.Crop)
                    .WithMany(p => p.Roadmap)
                    .HasForeignKey(d => d.CropId)
                    .HasConstraintName("FK__Roadmap__Crop_ID__4D94879B");
            });
        }
    }
}