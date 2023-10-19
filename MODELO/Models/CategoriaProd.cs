using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

[Table("CategoriaProd")]
public partial class CategoriaProd
{
    [Key]
    public int IdCat { get; set; }

    [StringLength(25)]
    public string Nombre { get; set; } = null!;

    [InverseProperty("CategoriaNavigation")]
    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
