public class Venta{
    public double Articulo {get; set;}
    public double Precio {get; set;}
    public double Cantidad {get; set;}
    public double Subtotal {get; set;}

    public Venta(double total) => Subtotal = total;
    public string Sarticulo() => Articulo = articulo;
    public void Scantidad(double cantidad) => Cantidad = cantidad;
    public void Sprecio(double precio) => Precio = precio;

    public void Agregar(double can) => Subtotal += can;




}