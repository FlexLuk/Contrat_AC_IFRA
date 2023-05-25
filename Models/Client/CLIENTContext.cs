using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Contrat_AC.Models.Client;

public partial class CLIENTContext : DbContext
{

    public CLIENTContext(DbContextOptions<CLIENTContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Conjointe> Conjointes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.ToTable("client");

            entity.Property(e => e.Clientid).HasColumnName("CLIENTID");
            entity.Property(e => e.Adresse)
                .HasMaxLength(100)
                .HasColumnName("ADRESSE");
            entity.Property(e => e.CodePostal)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("CODE_POSTAL");
            entity.Property(e => e.DateNaissance)
                .HasColumnType("datetime")
                .HasColumnName("DATE_NAISSANCE");
            entity.Property(e => e.DelivreA)
                .HasMaxLength(100)
                .HasColumnName("DELIVRE_A");
            entity.Property(e => e.DelivreLe)
                .HasColumnType("datetime")
                .HasColumnName("DELIVRE_LE");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Fonction)
                .HasMaxLength(100)
                .HasColumnName("FONCTION");
            entity.Property(e => e.LieuNaissance)
                .HasMaxLength(100)
                .HasColumnName("LIEU_NAISSANCE");
            entity.Property(e => e.Nationalite)
                .HasMaxLength(100)
                .HasColumnName("NATIONALITE");
            entity.Property(e => e.Nom)
                .HasMaxLength(100)
                .HasColumnName("NOM");
            entity.Property(e => e.NomCompletMere)
                .HasMaxLength(100)
                .HasColumnName("NOM_COMPLET_MERE");
            entity.Property(e => e.NomCompletPere)
                .HasMaxLength(100)
                .HasColumnName("NOM_COMPLET_PERE");
            entity.Property(e => e.NumeroPiece)
                .HasMaxLength(50)
                .HasColumnName("NUMERO_PIECE");
            entity.Property(e => e.Pays)
                .HasMaxLength(100)
                .HasColumnName("PAYS");
            entity.Property(e => e.Prenom)
                .HasMaxLength(100)
                .HasColumnName("PRENOM");
            entity.Property(e => e.Telephone)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("TELEPHONE");
            entity.Property(e => e.TypeIdentite)
                .HasMaxLength(100)
                .HasColumnName("TYPE_IDENTITE");
            entity.Property(e => e.Ville)
                .HasMaxLength(100)
                .HasColumnName("VILLE");
        });

        modelBuilder.Entity<Conjointe>(entity =>
        {
            entity.ToTable("conjointe");

            entity.Property(e => e.Conjointeid).HasColumnName("CONJOINTEID");
            entity.Property(e => e.Cin)
                .HasMaxLength(50)
                .HasColumnName("CIN");
            entity.Property(e => e.Clientid).HasColumnName("CLIENTID");
            entity.Property(e => e.DateNaissance)
                .HasColumnType("datetime")
                .HasColumnName("DATE_NAISSANCE");
            entity.Property(e => e.DelivreA)
                .HasMaxLength(100)
                .HasColumnName("DELIVRE_A");
            entity.Property(e => e.DelivreLe)
                .HasColumnType("datetime")
                .HasColumnName("DELIVRE_LE");
            entity.Property(e => e.LieuNaissance)
                .HasMaxLength(100)
                .HasColumnName("LIEU_NAISSANCE");
            entity.Property(e => e.Nom)
                .HasMaxLength(100)
                .HasColumnName("NOM");
            entity.Property(e => e.Prenom)
                .HasMaxLength(100)
                .HasColumnName("PRENOM");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("TYPE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
