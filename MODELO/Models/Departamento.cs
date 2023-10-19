using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

[Table("Departamento")]
public partial class Departamento
{
    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string IdDept { get; set; } = null!;

    [StringLength(25)]
    public string Nombre { get; set; } = null!;

    [InverseProperty("DeptNavigation")]
    public virtual ICollection<Municipio> Municipios { get; set; } = new List<Municipio>();
}
