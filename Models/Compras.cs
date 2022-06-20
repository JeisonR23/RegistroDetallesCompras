using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class Compras
{
    [Key]
    public int CompraId { get; set; }

    public int ProductoId{get; set;}
    public string Descripcion { get; set; }
    public DateTime Fecha { get; set; }

    public double Total { get; set; }

    [ForeignKey("CompraId")]
    public List<ComprasDetalles> Detalle { get; set; } = new List<ComprasDetalles>();

    public override string? ToString()
    {
        return $"Compra: Id={CompraId}, Fecha={Fecha}, Total={Total}";
    }
    
}