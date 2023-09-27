using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

[Table("Usuario")]
public class Usuario
{
    [Key]
    public int IdUsuario { get; set; }

    [StringLength(50)]
    public string Username { get; set; } = null!;

    [StringLength(25)]
    public string Tipo { get; set; } = null!;

    [StringLength(50)]
    public string Contrasena { get; set; } = null!;
}
