using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

public partial class Entrada
{
    [Key]
    public int IdEntrada { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string Proveedor { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string Producto { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Recibo { get; set; } = null!;

    [Column(TypeName = "numeric(6, 2)")]
    public decimal PreCompra { get; set; }

    [Column(TypeName = "date")]
    public DateTime FechaCompra { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal TotalCompra { get; set; }

    [InverseProperty("IdEntradaNavigation")]
    public virtual ICollection<DetalleEntradum> DetalleEntrada { get; set; } = new List<DetalleEntradum>();

    [ForeignKey("Producto")]
    [InverseProperty("Entrada")]
    public virtual Producto ProductoNavigation { get; set; } = null!;

    [ForeignKey("Proveedor")]
    [InverseProperty("Entrada")]
    public virtual Proveedore ProveedorNavigation { get; set; } = null!;
}
