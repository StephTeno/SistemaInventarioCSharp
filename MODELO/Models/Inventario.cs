using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

[Table("Inventario")]
public partial class Inventario
{
    [Key]
    [Column("IDI")]
    public int Idi { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string IdProd { get; set; } = null!;

    public int Existencia { get; set; }

    public int CantIng { get; set; }

    public int CantRet { get; set; }

    [Column("TEgresos", TypeName = "numeric(6, 2)")]
    public decimal Tegresos { get; set; }

    [Column("TIngresos", TypeName = "numeric(6, 2)")]
    public decimal Tingresos { get; set; }

    [ForeignKey("IdProd")]
    [InverseProperty("Inventarios")]
    public virtual Producto IdProdNavigation { get; set; } = null!;
}
