using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Contrat_AC.Models.Autorisation;

public partial class AUTORISATIONContext : DbContext
{
    public AUTORISATIONContext(DbContextOptions<AUTORISATIONContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UsersRole> UsersRoles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>(entity =>
        {
            entity.Property(e => e.RoleName).HasMaxLength(255);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.AdressMail).HasMaxLength(100);
            entity.Property(e => e.DateCreate).HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.PasswordHash).HasMaxLength(50);
        });

        modelBuilder.Entity<UsersRole>(entity =>
        {
            entity.HasKey(e => e.UserRoleId);

            entity.ToTable("UsersRole");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
