using System.ComponentModel.DataAnnotations;

public class ComprasDetalles
{
    [Key]
    public int CompraDetalleId { get; set; }
    public int CompraId { get; set; }
    public int ProductoId { get; set; }
    public string Descripcion { get; set; }
    public double Cantidad { get; set; }
    public double Costo { get; set; }
    public double Importe {get; set;}

    public override string? ToString()
    {
        return $"Detalle # {CompraDetalleId}, ProductoId= {ProductoId} , cantidad={Cantidad} ";
    }

}