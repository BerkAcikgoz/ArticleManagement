using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ArticleManagement.DataLibrary.Entity
{
  public partial class ArticleDbContext : DbContext
  {
    public ArticleDbContext()
    {
    }

    public ArticleDbContext(DbContextOptions<ArticleDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Article> Article { get; set; }
    public virtual DbSet<Author> Author { get; set; }
    public virtual DbSet<Category> Category { get; set; }
    public virtual DbSet<Comment> Comment { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseSqlServer("Server=DESKTOP-AHU9E0V\\MSSQLSERVERR;Database=ArticleDb;Trusted_Connection=True;User ID=sa;Password=sap");
      }
    }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

    //    modelBuilder.Entity<Article>(entity =>
    //    {
    //        entity.Property(e => e.Content).IsRequired();

    //        entity.Property(e => e.CreatedDate).HasColumnType("datetime");

    //        entity.Property(e => e.Description).HasMaxLength(300);

    //        entity.Property(e => e.Like).HasDefaultValueSql("((0))");

    //        entity.Property(e => e.Title)
    //            .IsRequired()
    //            .HasMaxLength(100);

    //        entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
    //    });

    //    modelBuilder.Entity<Author>(entity =>
    //    {
    //        entity.Property(e => e.Email).HasMaxLength(50);

    //        entity.Property(e => e.Gender).HasMaxLength(5);

    //        entity.Property(e => e.Name).HasMaxLength(25);

    //        entity.Property(e => e.Surname).HasMaxLength(25);
    //    });

    //    modelBuilder.Entity<Category>(entity =>
    //    {
    //        entity.Property(e => e.CreatedDate).HasColumnType("datetime");

    //        entity.Property(e => e.Name).HasMaxLength(50);

    //        entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
    //    });

    //    modelBuilder.Entity<Comment>(entity =>
    //    {
    //        entity.Property(e => e.Email).HasMaxLength(50);
    //    });
    //}
  }
}
