using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

public partial class Salida
{
    [Key]
    public int IdSalida { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string IdProd { get; set; } = null!;

    public int Cantidad { get; set; }

    public int Total { get; set; }

    [ForeignKey("IdProd")]
    [InverseProperty("Salida")]
    public virtual Producto IdProdNavigation { get; set; } = null!;
}
