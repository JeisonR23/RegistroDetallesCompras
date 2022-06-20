using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Productos
{
    [Key]
    public int ProductoId { get; set; }
    public int CompraId {get; set;}
    public String? Descripcion { get; set; }
    public double Cantidad {get; set;}
    public double Costo { get; set; }
    public double Precio { get; set; }
    public double Existencia { get; set; }
    [ForeignKey("ProductoId")]
    public virtual List<ComprasDetalles> comprasDetalles{ get; set; } = new List<ComprasDetalles>();
    
}