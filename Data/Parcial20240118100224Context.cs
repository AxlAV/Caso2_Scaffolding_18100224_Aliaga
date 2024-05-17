﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ParcialWEBCaso1.Data;

public partial class Parcial20240118100224Context : DbContext
{
    public Parcial20240118100224Context()
    {
    }

    public Parcial20240118100224Context(DbContextOptions<Parcial20240118100224Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Sport> Sport { get; set; }

    public virtual DbSet<Team> Team { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=Parcial20240118100224;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sport>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
