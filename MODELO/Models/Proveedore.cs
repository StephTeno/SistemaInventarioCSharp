using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

public partial class Proveedore
{
    [Key]
    [Column("RUC")]
    [StringLength(14)]
    [Unicode(false)]
    public string Ruc { get; set; } = null!;

    [StringLength(50)]
    public string Empresa { get; set; } = null!;

    [StringLength(60)]
    public string Representante { get; set; } = null!;

    [StringLength(60)]
    public string CargoPro { get; set; } = null!;

    [StringLength(6)]
    [Unicode(false)]
    public string IdLocal { get; set; } = null!;

    [StringLength(45)]
    public string? Correo { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? Telefono { get; set; }

    [InverseProperty("ProveedorNavigation")]
    public virtual ICollection<Entrada> Entrada { get; set; } = new List<Entrada>();

    [ForeignKey("IdLocal")]
    [InverseProperty("Proveedores")]
    public virtual Municipio IdLocalNavigation { get; set; } = null!;
}
