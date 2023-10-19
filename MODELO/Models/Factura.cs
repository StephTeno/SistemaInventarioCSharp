using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

public partial class Factura
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string IdFactura { get; set; } = null!;

    public int IdCliente { get; set; }

    [StringLength(10)]
    public string IdEmpleado { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime Fecha { get; set; }

    public int CantTotal { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal SubTotal { get; set; }

    [Column("IVA", TypeName = "numeric(4, 2)")]
    public decimal Iva { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal Total { get; set; }

    [InverseProperty("IdFacturaNavigation")]
    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();

    [ForeignKey("IdCliente")]
    [InverseProperty("Facturas")]
    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    [ForeignKey("IdEmpleado")]
    [InverseProperty("Facturas")]
    public virtual Usuario IdEmpleadoNavigation { get; set; } = null!;
}
