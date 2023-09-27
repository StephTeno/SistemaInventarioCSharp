using System;
using System.Collections.Generic;
using MODELO.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace MODELO.Data;

public partial class ESInventarioContext : DbContext
{
    public ESInventarioContext()
    {
    }

    public ESInventarioContext(DbContextOptions<ESInventarioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CategoriaProd> CategoriaProds { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<DetalleEntradum> DetalleEntrada { get; set; }

    public virtual DbSet<Entrada> Entradas { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Inventario> Inventarios { get; set; }

    public virtual DbSet<Localizacion> Localizacions { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<Salida> Salidas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ConnString"].ToString());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoriaProd>(entity =>
        {
            entity.HasKey(e => e.IdCat).HasName("PK__Categori__0FA7805E1C8B31B0");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__Clientes__D5946642F2E8F055");

            entity.Property(e => e.Cedula).IsFixedLength();
            entity.Property(e => e.Celular).IsFixedLength();

            entity.HasOne(d => d.IdLocalNavigation).WithMany(p => p.Clientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Clientes__IdLoca__398D8EEE");
        });

        modelBuilder.Entity<DetalleEntradum>(entity =>
        {
            entity.HasKey(e => new { e.IdEntrada, e.IdProd }).HasName("PK__DetalleE__7556949B6DBEFDA9");

            entity.Property(e => e.IdEntrada).IsFixedLength();
            entity.Property(e => e.IdProd).IsFixedLength();

            entity.HasOne(d => d.IdEntradaNavigation).WithMany(p => p.DetalleEntrada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DetalleEn__IdEnt__48CFD27E");

            entity.HasOne(d => d.IdProdNavigation).WithMany(p => p.DetalleEntrada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DetalleEn__IdPro__49C3F6B7");
        });

        modelBuilder.Entity<Entrada>(entity =>
        {
            entity.HasKey(e => e.IdEntrada).HasName("PK__Entradas__BB164DEA4795774E");

            entity.Property(e => e.IdEntrada).IsFixedLength();

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Entrada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Entradas__IdProv__4316F928");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.IdFactura).HasName("PK__Facturas__50E7BAF176CABB18");

            entity.Property(e => e.IdFactura).IsFixedLength();

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Facturas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Facturas__IdClie__4CA06362");
        });

        modelBuilder.Entity<Inventario>(entity =>
        {
            entity.HasKey(e => e.Idi).HasName("PK__Inventar__C4971C35D024DF29");

            entity.Property(e => e.IdProd).IsFixedLength();

            entity.HasOne(d => d.IdProdNavigation).WithMany(p => p.Inventarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Inventari__IdPro__534D60F1");
        });

        modelBuilder.Entity<Localizacion>(entity =>
        {
            entity.HasKey(e => e.IdLocal).HasName("PK__Localiza__C287B9BB205A01E5");

            entity.Property(e => e.IdLocal).ValueGeneratedNever();
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProd).HasName("PK__Producto__E40D971DCE5E886D");

            entity.Property(e => e.IdProd).IsFixedLength();

            entity.HasOne(d => d.CategoriaNavigation).WithMany(p => p.Productos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Productos__Categ__45F365D3");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).HasName("PK__Proveedo__E8B631AF338B48B7");

            entity.Property(e => e.CelularP).IsFixedLength();

            entity.HasOne(d => d.IdLocalNavigation).WithMany(p => p.Proveedores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Proveedor__IdLoc__3D5E1FD2");
        });

        modelBuilder.Entity<Salida>(entity =>
        {
            entity.HasKey(e => new { e.IdProd, e.IdFactura }).HasName("PK__Salidas__E103ECB28B2E2616");

            entity.Property(e => e.IdProd).IsFixedLength();
            entity.Property(e => e.IdFactura).IsFixedLength();

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.Salida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Salidas__IdFactu__5070F446");

            entity.HasOne(d => d.IdProdNavigation).WithMany(p => p.Salida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Salidas__IdProd__4F7CD00D");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__5B65BF97E399BBD1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
