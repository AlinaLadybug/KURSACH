using System;
using KR.Models.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KR.Models.Database
{
    public partial class KRContext : DbContext
    {
        public KRContext()
        {
        }

        public KRContext(DbContextOptions<KRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Problem> Problem { get; set; }
        public virtual DbSet<ProblemType> ProblemType { get; set; }
        public virtual DbSet<Sender> Sender { get; set; }
        public virtual DbSet<CommentVm> CommentVm { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\;Database=kursach;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("COMMENT");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Text)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Problem)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.ProblemId)
                    .HasConstraintName("FK__COMMENT__Problem__5165187F");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.SenderId)
                    .HasConstraintName("FK__COMMENT__SenderI__52593CB8");
            });

            modelBuilder.Entity<Problem>(entity =>
            {
                entity.ToTable("PROBLEM");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Problem)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK__PROBLEM__TypeId__4CA06362");
            });

            modelBuilder.Entity<ProblemType>(entity =>
            {
                entity.ToTable("PROBLEM_TYPE");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sender>(entity =>
            {
                entity.ToTable("SENDER");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
