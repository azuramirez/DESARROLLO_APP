public class Tienda{
    public string Nombre{get; set;}
    public string Propietario{get; set;}
    public string Domicilio{get; set;}
    public List<Cliente> Clientes {get; set;}

    public Tienda() => Clientes = new List<Cliente>();
    public Tienda(string nombre,string propietario,string domicilio) : this() => (Nombre,Propietario,Domicilio) = (nombre,propietario,domicilio);
    public void AgregarCliente(Cliente cliente) => Clientes.Add(cliente);
    public override string ToString() => $"Nombre:{Nombre}, Propietario:{Propietario}, Domicilio:{Domicilio}";
}