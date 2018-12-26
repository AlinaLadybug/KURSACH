using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KR.Models.Database
{
    public partial class DataBaseContext : DbContext
    {
        public DataBaseContext()
        {
        }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<Problem> Problem { get; set; }
        public virtual DbSet<Sender> Sender { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=kursach;Trusted_Connection=True; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.ProblemId).HasColumnName("ProblemID");

                entity.Property(e => e.Sent).HasColumnType("datetime");

                entity.Property(e => e.Text).HasMaxLength(200);

                entity.HasOne(d => d.From)
                    .WithMany(p => p.MessageFrom)
                    .HasForeignKey(d => d.FromId)
                    .HasConstraintName("FK__Message__FromId");

                entity.HasOne(d => d.Problem)
                    .WithMany(p => p.Message)
                    .HasForeignKey(d => d.ProblemId)
                    .HasConstraintName("FK__Message__Problem");

                entity.HasOne(d => d.To)
                    .WithMany(p => p.MessageTo)
                    .HasForeignKey(d => d.ToId)
                    .HasConstraintName("FK__Message__ToId");
            });

            modelBuilder.Entity<Problem>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<Sender>(entity =>
            {
                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName).HasMaxLength(20);

                entity.Property(e => e.JobPosition)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName).HasMaxLength(20);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}
