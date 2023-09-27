using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

[PrimaryKey("IdProd", "IdFactura")]
public class Salida
{
    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string IdProd { get; set; } = null!;

    [Key]
    [StringLength(4)]
    [Unicode(false)]
    public string IdFactura { get; set; } = null!;

    public int Cantidad { get; set; }

    public int Total { get; set; }

    [ForeignKey("IdFactura")]
    [InverseProperty("Salida")]
    public virtual Factura IdFacturaNavigation { get; set; } = null!;

    [ForeignKey("IdProd")]
    [InverseProperty("Salida")]
    public virtual Producto IdProdNavigation { get; set; } = null!;
}
