using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

[Table("TipoUsuario")]
public partial class TipoUsuario
{
    [Key]
    public int IdTipoUser { get; set; }

    [StringLength(15)]
    public string Nombre { get; set; } = null!;

    [InverseProperty("TipoNavigation")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
