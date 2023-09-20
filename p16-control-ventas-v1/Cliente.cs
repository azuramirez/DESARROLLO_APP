public class Cliente{
    public string Nombre {get; set;}
    public string RFC {get; set;}
    public string Domicilio {get; set;}
    public string Correo {get; set;}
    public Venta Venta1 {get; set;}
    public Cliente(string nombre, string rfc, string domicilio, string correo, Venta venta) => (Nombre,RFC,Domicilio,Correo,Venta1) = (nombre,rfc,domicilio,correo,venta);
    public override string ToString() => $"Nombre: {Nombre}, RFC: {RFC}, Domicilio: {Domicilio}, Correo: {Correo}";
}