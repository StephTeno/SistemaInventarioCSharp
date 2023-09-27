using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

[Table("Localizacion")]
public class Localizacion
{
    [Key]
    public int IdLocal { get; set; }

    [StringLength(45)]
    public string Departamento { get; set; } = null!;

    [StringLength(45)]
    public string Municipio { get; set; } = null!;

    [InverseProperty("IdLocalNavigation")]
    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    [InverseProperty("IdLocalNavigation")]
    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();
}
