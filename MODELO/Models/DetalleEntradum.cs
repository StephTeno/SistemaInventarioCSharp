using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

[PrimaryKey("IdEntrada", "IdProd")]
public class DetalleEntradum
{
    [Key]
    [StringLength(4)]
    [Unicode(false)]
    public string IdEntrada { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string IdProd { get; set; } = null!;

    public int Cantidad { get; set; }

    [ForeignKey("IdEntrada")]
    [InverseProperty("DetalleEntrada")]
    public virtual Entrada IdEntradaNavigation { get; set; } = null!;

    [ForeignKey("IdProd")]
    [InverseProperty("DetalleEntrada")]
    public virtual Producto IdProdNavigation { get; set; } = null!;
}
