using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

[Table("Municipio")]
public partial class Municipio
{
    [Key]
    public int IdMun { get; set; }

    [Column("Municipio")]
    [StringLength(25)]
    public string Municipio1 { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string Dept { get; set; } = null!;

    [InverseProperty("MunicipioNavigation")]
    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    [ForeignKey("Dept")]
    [InverseProperty("Municipios")]
    public virtual Departamento DeptNavigation { get; set; } = null!;

    [InverseProperty("MunicipioNavigation")]
    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();
}
