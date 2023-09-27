using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MODELO.Models;

public class Producto
{
    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string IdProd { get; set; } = null!;

    [StringLength(50)]
    public string NombreProd { get; set; } = null!;

    public int Categoria { get; set; }

    [StringLength(50)]
    public string Especificaciones { get; set; } = null!;

    [Column("CUnitario", TypeName = "numeric(6, 2)")]
    public decimal Cunitario { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal PreVenta { get; set; }

    [ForeignKey("Categoria")]
    [InverseProperty("Productos")]
    public virtual CategoriaProd CategoriaNavigation { get; set; } = null!;

    [InverseProperty("IdProdNavigation")]
    public virtual ICollection<DetalleEntradum> DetalleEntrada { get; set; } = new List<DetalleEntradum>();

    [InverseProperty("IdProdNavigation")]
    public virtual ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();

    [InverseProperty("IdProdNavigation")]
    public virtual ICollection<Salida> Salida { get; set; } = new List<Salida>();
}
