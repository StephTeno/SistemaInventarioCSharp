using System;
using System.Collections.Generic;
using MODELO.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
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

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<DetalleEntradum> DetalleEntrada { get; set; }

    public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; }

    public virtual DbSet<Entrada> Entradas { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Inventario> Inventarios { get; set; }

    public virtual DbSet<Municipio> Municipios { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<Salida> Salidas { get; set; }

    public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=STEPHANIE\\TENORIO;Database=ESInventario;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoriaProd>(entity =>
        {
            entity.HasKey(e => e.IdCat).HasName("PK__Categori__0FA7805E6B97BC2A");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__Clientes__D5946642BA2CF6D9");

            entity.Property(e => e.Cedula).IsFixedLength();
            entity.Property(e => e.Celular).IsFixedLength();
            entity.Property(e => e.Estado).HasDefaultValueSql("((1))");
            entity.Property(e => e.IdLocal).IsFixedLength();

            entity.HasOne(d => d.IdLocalNavigation).WithMany(p => p.Clientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Clientes__IdLoca__3C69FB99");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.IdDept).HasName("PK__Departam__F0682C9B51E04831");

            entity.Property(e => e.IdDept).IsFixedLength();
        });

        modelBuilder.Entity<DetalleEntradum>(entity =>
        {
            entity.HasKey(e => new { e.IdEntrada, e.IdProd }).HasName("PK__DetalleE__7556949B78DE793D");

            entity.Property(e => e.IdProd).IsFixedLength();

            entity.HasOne(d => d.IdEntradaNavigation).WithMany(p => p.DetalleEntrada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DetalleEn__IdEnt__4D94879B");

            entity.HasOne(d => d.IdProdNavigation).WithMany(p => p.DetalleEntrada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DetalleEn__IdPro__4E88ABD4");
        });

        modelBuilder.Entity<DetalleFactura>(entity =>
        {
            entity.HasKey(e => new { e.IdFactura, e.IdProd }).HasName("PK__DetalleF__9EA7638041C14F9E");

            entity.Property(e => e.IdFactura).IsFixedLength();
            entity.Property(e => e.IdProd).IsFixedLength();

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.DetalleFacturas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DetalleFa__IdFac__6754599E");

            entity.HasOne(d => d.IdProdNavigation).WithMany(p => p.DetalleFacturas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DetalleFa__IdPro__68487DD7");
        });

        modelBuilder.Entity<Entrada>(entity =>
        {
            entity.HasKey(e => e.IdEntrada).HasName("PK__Entradas__BB164DEA2284083F");

            entity.Property(e => e.Producto).IsFixedLength();
            entity.Property(e => e.Proveedor).IsFixedLength();
            entity.Property(e => e.Recibo).IsFixedLength();

            entity.HasOne(d => d.ProductoNavigation).WithMany(p => p.Entrada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Entradas__Produc__4AB81AF0");

            entity.HasOne(d => d.ProveedorNavigation).WithMany(p => p.Entrada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Entradas__Provee__49C3F6B7");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.IdFactura).HasName("PK__Facturas__50E7BAF11D4DFFE7");

            entity.Property(e => e.IdFactura).IsFixedLength();

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Facturas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Facturas__IdClie__6383C8BA");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.Facturas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Facturas__IdEmpl__6477ECF3");
        });

        modelBuilder.Entity<Inventario>(entity =>
        {
            entity.HasKey(e => e.Idi).HasName("PK__Inventar__C4971C351481C6B8");

            entity.Property(e => e.IdProd).IsFixedLength();

            entity.HasOne(d => d.IdProdNavigation).WithMany(p => p.Inventarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Inventari__IdPro__6E01572D");
        });

        modelBuilder.Entity<Municipio>(entity =>
        {
            entity.HasKey(e => e.IdMun).HasName("PK__Municipi__0D12D9D3044D735D");

            entity.Property(e => e.IdMun).IsFixedLength();
            entity.Property(e => e.Dept).IsFixedLength();

            entity.HasOne(d => d.DeptNavigation).WithMany(p => p.Municipios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Municipio__Dept__398D8EEE");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProd).HasName("PK__Producto__E40D971D188EB84B");

            entity.Property(e => e.IdProd).IsFixedLength();
            entity.Property(e => e.Proveedor).IsFixedLength();

            entity.HasOne(d => d.CategoriaNavigation).WithMany(p => p.Productos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Productos__Categ__46E78A0C");

            entity.HasOne(d => d.ProveedorNavigation).WithMany(p => p.Productos).HasConstraintName("FK__Productos__Prove__7A672E12");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.Ruc).HasName("PK__Proveedo__CAF3326AB0B544F0");

            entity.Property(e => e.Ruc).IsFixedLength();
            entity.Property(e => e.IdLocal).IsFixedLength();
            entity.Property(e => e.Telefono).IsFixedLength();

            entity.HasOne(d => d.IdLocalNavigation).WithMany(p => p.Proveedores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Proveedor__IdLoc__412EB0B6");
        });

        modelBuilder.Entity<Salida>(entity =>
        {
            entity.HasKey(e => e.IdSalida).HasName("PK__Salidas__5D69EC725F7525AA");

            entity.Property(e => e.IdProd).IsFixedLength();

            entity.HasOne(d => d.IdProdNavigation).WithMany(p => p.Salida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Salidas__IdProd__6B24EA82");
        });

        modelBuilder.Entity<TipoUsuario>(entity =>
        {
            entity.HasKey(e => e.IdTipoUser).HasName("PK__TipoUsua__276DE6F8B2C84226");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Username).HasName("PK__Usuario__536C85E51D2C3EBA");

            entity.HasOne(d => d.TipoNavigation).WithMany(p => p.Usuarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Usuario__Tipo__571DF1D5");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
