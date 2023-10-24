using System;
using System.Collections.Generic;
using MODELO.Models;
using Microsoft.EntityFrameworkCore;

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
            entity.HasKey(e => e.IdCat).HasName("PK__Categori__0FA7805EA723A4FD");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__Clientes__D594664206845368");

            entity.Property(e => e.Cedula).IsFixedLength();
            entity.Property(e => e.Celular).IsFixedLength();
            entity.Property(e => e.Estado).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.MunicipioNavigation).WithMany(p => p.Clientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Clientes__Munici__412EB0B6");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.IdDept).HasName("PK__Departam__F0682C9B53EEDDC3");

            entity.Property(e => e.IdDept).IsFixedLength();
        });

        modelBuilder.Entity<DetalleEntradum>(entity =>
        {
            entity.HasKey(e => new { e.IdEntrada, e.IdProd }).HasName("PK__DetalleE__7556949BA51239C3");

            entity.Property(e => e.IdProd).IsFixedLength();

            entity.HasOne(d => d.IdEntradaNavigation).WithMany(p => p.DetalleEntrada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DetalleEn__IdEnt__52593CB8");

            entity.HasOne(d => d.IdProdNavigation).WithMany(p => p.DetalleEntrada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DetalleEn__IdPro__534D60F1");
        });

        modelBuilder.Entity<DetalleFactura>(entity =>
        {
            entity.HasKey(e => new { e.IdFactura, e.IdProd }).HasName("PK__DetalleF__9EA76380F8E45E58");

            entity.Property(e => e.IdFactura).IsFixedLength();
            entity.Property(e => e.IdProd).IsFixedLength();

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.DetalleFacturas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DetalleFa__IdFac__59FA5E80");

            entity.HasOne(d => d.IdProdNavigation).WithMany(p => p.DetalleFacturas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DetalleFa__IdPro__5AEE82B9");
        });

        modelBuilder.Entity<Entrada>(entity =>
        {
            entity.HasKey(e => e.IdEntrada).HasName("PK__Entradas__BB164DEAAE59566C");

            entity.Property(e => e.Proveedor).IsFixedLength();
            entity.Property(e => e.Recibo).IsFixedLength();

            entity.HasOne(d => d.ProveedorNavigation).WithMany(p => p.Entrada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Entradas__Provee__4E88ABD4");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.IdFactura).HasName("PK__Facturas__50E7BAF18B6CA3E3");

            entity.Property(e => e.IdFactura).IsFixedLength();

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Facturas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Facturas__IdClie__5629CD9C");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.Facturas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Facturas__IdEmpl__571DF1D5");
        });

        modelBuilder.Entity<Inventario>(entity =>
        {
            entity.HasKey(e => e.Idi).HasName("PK__Inventar__C4971C357ADCADAE");

            entity.Property(e => e.IdProd).IsFixedLength();

            entity.HasOne(d => d.IdProdNavigation).WithMany(p => p.Inventarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Inventari__IdPro__60A75C0F");
        });

        modelBuilder.Entity<Municipio>(entity =>
        {
            entity.HasKey(e => e.IdMun).HasName("PK__Municipi__0D12D9D32EF3B4CB");

            entity.Property(e => e.Dept).IsFixedLength();

            entity.HasOne(d => d.DeptNavigation).WithMany(p => p.Municipios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Municipio__Dept__3E52440B");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProd).HasName("PK__Producto__E40D971DD2121959");

            entity.Property(e => e.IdProd).IsFixedLength();
            entity.Property(e => e.Proveedor).IsFixedLength();

            entity.HasOne(d => d.CategoriaNavigation).WithMany(p => p.Productos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Productos__Categ__4BAC3F29");

            entity.HasOne(d => d.ProveedorNavigation).WithMany(p => p.Productos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Productos__Prove__619B8048");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.Ruc).HasName("PK__Proveedo__CAF3326A749BA95A");

            entity.Property(e => e.Ruc).IsFixedLength();
            entity.Property(e => e.Telefono).IsFixedLength();

            entity.HasOne(d => d.MunicipioNavigation).WithMany(p => p.Proveedores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Proveedor__Munic__45F365D3");
        });

        modelBuilder.Entity<Salida>(entity =>
        {
            entity.HasKey(e => e.IdSalida).HasName("PK__Salidas__5D69EC72C64F14B1");

            entity.Property(e => e.IdProd).IsFixedLength();

            entity.HasOne(d => d.IdProdNavigation).WithMany(p => p.Salida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Salidas__IdProd__5DCAEF64");
        });

        modelBuilder.Entity<TipoUsuario>(entity =>
        {
            entity.HasKey(e => e.IdTipoUser).HasName("PK__TipoUsua__276DE6F8DEE7B8D5");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Username).HasName("PK__Usuario__536C85E5CE58BA86");

            entity.HasOne(d => d.TipoNavigation).WithMany(p => p.Usuarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Usuario__Tipo__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
