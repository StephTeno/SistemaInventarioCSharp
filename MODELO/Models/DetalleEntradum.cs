using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

[PrimaryKey("IdEntrada", "IdProd")]
public partial class DetalleEntradum
{
    [Key]
    public int IdEntrada { get; set; }

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string IdProd { get; set; } = null!;

    public int Cantidad { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal SubTotal { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal PreCompra { get; set; }

    [ForeignKey("IdEntrada")]
    [InverseProperty("DetalleEntrada")]
    public virtual Entrada IdEntradaNavigation { get; set; } = null!;

    [ForeignKey("IdProd")]
    [InverseProperty("DetalleEntrada")]
    public virtual Producto IdProdNavigation { get; set; } = null!;
}
