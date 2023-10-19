using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

public partial class Cliente
{
    [Key]
    public int IdCliente { get; set; }

    [Column("PNomb")]
    [StringLength(25)]
    public string Pnomb { get; set; } = null!;

    [Column("SNomb")]
    [StringLength(25)]
    public string? Snomb { get; set; }

    [Column("PApe")]
    [StringLength(25)]
    public string Pape { get; set; } = null!;

    [Column("SApe")]
    [StringLength(25)]
    public string? Sape { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string IdLocal { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string Cedula { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string? Celular { get; set; }

    public bool? Estado { get; set; }

    [StringLength(45)]
    public string? Correo { get; set; }

    [InverseProperty("IdClienteNavigation")]
    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    [ForeignKey("IdLocal")]
    [InverseProperty("Clientes")]
    public virtual Municipio IdLocalNavigation { get; set; } = null!;
}
