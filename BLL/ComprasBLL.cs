using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

public class  ComprasBLL
{
      public static int CrearProductos(Contexto contexto)
    {
        //guardar productos

        var producto1 = new Productos
        {
            Descripcion = "Huevos",
            Costo = 5,
            Precio = 7, 
            Existencia = 10
        };

        var producto2 = new Productos
        {
            Descripcion = "Cebolla",
            Costo = 50,
            Precio = 85,
            Existencia = 6
        };

        contexto.Productos.Add(producto1);
        contexto.Productos.Add(producto2);

        var insertados = contexto.SaveChanges();
        return insertados;
    }

    public static void GuardarCompra(Contexto contexto, Compras compra)
    {
        contexto.Compras.Add(compra);

        foreach (var item in compra.Detalle)
        {
            var producto = contexto.Productos.Find(item.ProductoId);

            producto.Existencia += item.Cantidad;

        }

        var insertados = contexto.SaveChanges();

        if (insertados == 0)
            Console.WriteLine("No se pudo insertar");
    }

    public static void ImprimirCompras(Contexto contexto)
    {
        var lista = contexto.Compras.Include(c => c.Detalle)
            .AsNoTracking()
            .ToList();

        foreach (var comp in lista)
        {
            Console.WriteLine(comp);
            foreach (var det in comp.Detalle)
            {
                Console.WriteLine($"\t\t{det}");
            }
        }
    }


}