public class InicializadorBD {
    public static void Inicializar(ContextoDatos contexto) {
        if(contexto.Articulos.Any()) {
            return;
        }
        var articulos = new Articulo[] {
            new Articulo {Descripcion="Cepillo Dental",FechaAlta=DateTime.Parse("1/1/2023"),Cantidad=50,Precio=18.50,UdeMedida="Caja"},
            new Articulo {Descripcion="Rollo",FechaAlta=DateTime.Parse("1/10/2023"),Cantidad=30,Precio=10.50,UdeMedida="Caja"},
            new Articulo {Descripcion="Azucar",FechaAlta=DateTime.Parse("1/05/2023"),Cantidad=10,Precio=17.00,UdeMedida="Kilo"},
            new Articulo {Descripcion="Veladora",FechaAlta=DateTime.Parse("1/2/2023"),Cantidad=18,Precio=16.50,UdeMedida="Pieza"},
            new Articulo {Descripcion="Detergente",FechaAlta=DateTime.Parse("1/1/2023"),Cantidad=30,Precio=25.50,UdeMedida="Kilo"},
        };
        contexto.Articulos.AddRange(articulos);
        contexto.SaveChanges();
    }
}