using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1.Models;

public partial class ProjektDbContext : DbContext
{
    public ProjektDbContext()
    {
    }

    public ProjektDbContext(DbContextOptions<ProjektDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Collection> Collections { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Vinyl> Vinyls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:software024.database.windows.net,1433;Initial Catalog=projektDB;Persist Security Info=False;User ID=hallgato;Password=softwareAron123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Collection>(entity =>
        {
            entity.HasKey(e => e.CollectionId).HasName("PK__COLLECTI__7DE6BC246C601867");

            entity.ToTable("COLLECTION");

            entity.Property(e => e.CollectionId).HasColumnName("CollectionID");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date");
            entity.Property(e => e.UserIdfk).HasColumnName("UserIDFK");
            entity.Property(e => e.VinylIdfk).HasColumnName("VinylIDFK");

            entity.HasOne(d => d.UserIdfkNavigation).WithMany(p => p.Collections)
                .HasForeignKey(d => d.UserIdfk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__COLLECTIO__UserI__6383C8BA");

            entity.HasOne(d => d.VinylIdfkNavigation).WithMany(p => p.Collections)
                .HasForeignKey(d => d.VinylIdfk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__COLLECTIO__Vinyl__6477ECF3");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__USERS__1788CCAC5273FF17");

            entity.ToTable("USERS");

            entity.HasIndex(e => e.Email, "UQ__USERS__A9D10534A3908D48").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        modelBuilder.Entity<Vinyl>(entity =>
        {
            entity.HasKey(e => e.VinylId).HasName("PK__VINYLS__52D17577E1A10295");

            entity.ToTable("VINYLS");

            entity.Property(e => e.VinylId).HasColumnName("VinylID");
            entity.Property(e => e.Artist).HasMaxLength(200);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Genre).HasMaxLength(100);
            entity.Property(e => e.Title).HasMaxLength(200);
            entity.Property(e => e.Value).HasColumnType("decimal(10, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
