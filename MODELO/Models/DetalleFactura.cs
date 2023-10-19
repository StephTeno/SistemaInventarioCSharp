using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

[PrimaryKey("IdFactura", "IdProd")]
[Table("DetalleFactura")]
public partial class DetalleFactura
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string IdFactura { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string IdProd { get; set; } = null!;

    public int Cantidad { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal SubTotal { get; set; }

    [ForeignKey("IdFactura")]
    [InverseProperty("DetalleFacturas")]
    public virtual Factura IdFacturaNavigation { get; set; } = null!;

    [ForeignKey("IdProd")]
    [InverseProperty("DetalleFacturas")]
    public virtual Producto IdProdNavigation { get; set; } = null!;
}
