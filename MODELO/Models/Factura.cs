using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

public class Factura
{
    [Key]
    [StringLength(4)]
    [Unicode(false)]
    public string IdFactura { get; set; } = null!;

    public int IdCliente { get; set; }

    [Column(TypeName = "date")]
    public DateTime Fecha { get; set; }

    public int CantTotal { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal Total { get; set; }

    [Column("IVA", TypeName = "numeric(4, 2)")]
    public decimal Iva { get; set; }

    [ForeignKey("IdCliente")]
    [InverseProperty("Facturas")]
    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    [InverseProperty("IdFacturaNavigation")]
    public virtual ICollection<Salida> Salida { get; set; } = new List<Salida>();
}
