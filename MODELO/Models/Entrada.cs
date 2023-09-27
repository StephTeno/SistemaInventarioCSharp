using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

public class Entrada
{
    [Key]
    [StringLength(4)]
    [Unicode(false)]
    public string IdEntrada { get; set; } = null!;

    public int IdProveedor { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal PreCompra { get; set; }

    [Column(TypeName = "date")]
    public DateTime FechaCompra { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal TotalCompra { get; set; }

    [StringLength(45)]
    public string Tipo { get; set; } = null!;

    [InverseProperty("IdEntradaNavigation")]
    public virtual ICollection<DetalleEntradum> DetalleEntrada { get; set; } = new List<DetalleEntradum>();

    [ForeignKey("IdProveedor")]
    [InverseProperty("Entrada")]
    public virtual Proveedore IdProveedorNavigation { get; set; } = null!;
}
