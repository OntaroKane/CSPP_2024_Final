using System;
using System.Collections.Generic;
using Imdb_API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Imdb_API.Data;

public partial class ImdbDbContext : DbContext
{
    public ImdbDbContext()
    {
    }

    public ImdbDbContext(DbContextOptions<ImdbDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<name_basic> name_basics { get; set; }

    public virtual DbSet<title_basic> title_basics { get; set; }

    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseNpgsql("Server=localhost;Port=5432;User Id=postgres;Password=123456;Database=imdb;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<name_basic>(entity =>
        {
            entity.HasKey(e => e.nconst).HasName("name_basics_pkey");

            entity.Property(e => e.nconst).IsFixedLength();
            entity.Property(e => e.birthyear).IsFixedLength();
            entity.Property(e => e.deathyear).IsFixedLength();
        });

        modelBuilder.Entity<title_basic>(entity =>
        {
            entity.HasKey(e => e.tconst).HasName("title_basics_pkey");

            entity.Property(e => e.tconst).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
