using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

public partial class Producto
{
    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string IdProd { get; set; } = null!;

    [StringLength(50)]
    public string NombreProd { get; set; } = null!;

    public int Categoria { get; set; }

    [StringLength(50)]
    public string Especificaciones { get; set; } = null!;

    [Column("CUnitario", TypeName = "numeric(6, 2)")]
    public decimal Cunitario { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal PreVenta { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string Proveedor { get; set; } = null!;

    [ForeignKey("Categoria")]
    [InverseProperty("Productos")]
    public virtual CategoriaProd CategoriaNavigation { get; set; } = null!;

    [InverseProperty("IdProdNavigation")]
    public virtual ICollection<DetalleEntradum> DetalleEntrada { get; set; } = new List<DetalleEntradum>();

    [InverseProperty("IdProdNavigation")]
    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();

    [InverseProperty("ProductoNavigation")]
    public virtual ICollection<Entrada> Entrada { get; set; } = new List<Entrada>();

    [InverseProperty("IdProdNavigation")]
    public virtual ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();

    [ForeignKey("Proveedor")]
    [InverseProperty("Productos")]
    public virtual Proveedore ProveedorNavigation { get; set; } = null!;

    [InverseProperty("IdProdNavigation")]
    public virtual ICollection<Salida> Salida { get; set; } = new List<Salida>();
}
