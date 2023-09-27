using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

public class Cliente
{
    [Key]
    public int IdCliente { get; set; }

    [StringLength(60)]
    public string Nombres { get; set; } = null!;

    [StringLength(60)]
    public string Apellidos { get; set; } = null!;

    public int IdLocal { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string Cedula { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string? Celular { get; set; }

    [StringLength(20)]
    public string? Estado { get; set; }

    [StringLength(45)]
    public string? Correo { get; set; }

    [InverseProperty("IdClienteNavigation")]
    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    [ForeignKey("IdLocal")]
    [InverseProperty("Clientes")]
    public virtual Localizacion IdLocalNavigation { get; set; } = null!;
}
