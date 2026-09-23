using Microsoft.EntityFrameworkCore;
using PersonenVerwaltung.DataAccess.Models;

namespace PersonenVerwaltung.DataAccess;

public partial class PersonenVerwaltungContext : DbContext
{
    public PersonenVerwaltungContext()
    {
    }

    public PersonenVerwaltungContext(DbContextOptions<PersonenVerwaltungContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Anschrift> Anschrifts { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Telefonverbindung> Telefonverbindungs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=PersonenVerwaltung;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Anschrift>(entity =>
        {
            entity.ToTable("Anschrift");

            entity.Property(e => e.Hausnummer).HasMaxLength(10);
            entity.Property(e => e.Ort).HasMaxLength(100);
            entity.Property(e => e.Plz)
                .HasMaxLength(10)
                .HasColumnName("PLZ");
            entity.Property(e => e.Strasse).HasMaxLength(100);

            entity.HasOne(d => d.Person).WithMany(p => p.Anschrifts)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Anschrift_Person");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.ToTable("Person");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Vorname).HasMaxLength(100);
        });

        modelBuilder.Entity<Telefonverbindung>(entity =>
        {
            entity.HasKey(e => e.TelefonNummerRecordId);

            entity.ToTable("Telefonverbindung");

            entity.Property(e => e.Nummer).HasMaxLength(30);

            entity.HasOne(d => d.Person).WithMany(p => p.Telefonverbindungs)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Telefonverbindung_Person");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
