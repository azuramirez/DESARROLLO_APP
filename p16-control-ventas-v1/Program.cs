// Control de ventas
// Probar clase Ventas
Venta venta = new Venta(0);
venta.SCantidad(2);
venta.SPrecio(50);
Console.WriteLine($"Subtotal: {venta.Subtotal}");
// Probar clase Cliente
Cliente cliente1 = new Cliente("Carlos Lopez","123456789","Las lomas","carlos@hotmail.com",venta);
Console.WriteLine($"\nDatos del cliente : {cliente1.ToString()}");
Console.WriteLine($"Saldo cuenta: {cliente1.Venta1.Subtotal}");
Cliente cliente2 = new Cliente("Azu Ramirez","145678999","Soledad","azur@nsn.com",venta);
Console.WriteLine($"\nDatos del cliente : {cliente2.ToString()}");
Console.WriteLine($"Subtotal venta: {cliente2.Venta1.Subtotal}");
// Probar la clase Tienda
Tienda mitienda = new Tienda("Super+","Arboledas");
mitienda.AgregarCliente(cliente1);
mitienda.AgregarCliente(cliente2);
mitienda.AgregarCliente(new Cliente("Carlos Lopez","123456789","Las lomas","carlos@hotmail.com"));
Console.WriteLine(mitienda.ToString());
Console.WriteLine($"La tienda tiene {mitienda.Clientes.Count} clientes");
foreach(Cliente cl in mitienda.Clientes) {
    Console.WriteLine($"Cliente : {cl.ToString()}");
    Console.WriteLine($"Subtotal   : {cl.Venta1.Subtotal}");
}
