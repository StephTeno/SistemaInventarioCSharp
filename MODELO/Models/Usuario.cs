using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

[Table("Usuario")]
public partial class Usuario
{
    [Key]
    [StringLength(10)]
    public string Username { get; set; } = null!;

    public int Tipo { get; set; }

    [StringLength(20)]
    public string Contrasena { get; set; } = null!;

    [InverseProperty("IdEmpleadoNavigation")]
    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    [ForeignKey("Tipo")]
    [InverseProperty("Usuarios")]
    public virtual TipoUsuario TipoNavigation { get; set; } = null!;
}
