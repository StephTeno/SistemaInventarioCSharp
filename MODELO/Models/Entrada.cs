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

    [StringLength(10)]
    [Unicode(false)]
    public string Recibo { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime FechaCompra { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal TotalCompra { get; set; }

    [InverseProperty("IdEntradaNavigation")]
    public virtual ICollection<DetalleEntradum> DetalleEntrada { get; set; } = new List<DetalleEntradum>();

    [ForeignKey("Proveedor")]
    [InverseProperty("Entrada")]
    public virtual Proveedore ProveedorNavigation { get; set; } = null!;
}
