using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

public class Proveedore
{
    [Key]
    public int IdProveedor { get; set; }

    [StringLength(60)]
    public string NombrePro { get; set; } = null!;

    [StringLength(60)]
    public string CargoPro { get; set; } = null!;

    [StringLength(50)]
    public string Empresa { get; set; } = null!;

    public int IdLocal { get; set; }

    [StringLength(45)]
    public string? Correo { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? CelularP { get; set; }

    [Column("RUC")]
    [StringLength(50)]
    public string? Ruc { get; set; }

    [InverseProperty("IdProveedorNavigation")]
    public virtual ICollection<Entrada> Entrada { get; set; } = new List<Entrada>();

    [ForeignKey("IdLocal")]
    [InverseProperty("Proveedores")]
    public virtual Localizacion IdLocalNavigation { get; set; } = null!;
}
