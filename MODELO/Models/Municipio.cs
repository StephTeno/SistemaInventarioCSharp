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
    [StringLength(6)]
    [Unicode(false)]
    public string IdMun { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string Dept { get; set; } = null!;

    [InverseProperty("IdLocalNavigation")]
    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    [ForeignKey("Dept")]
    [InverseProperty("Municipios")]
    public virtual Departamento DeptNavigation { get; set; } = null!;

    [InverseProperty("IdLocalNavigation")]
    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();
}
