Academia miacademia = new Academia {Nombre="Academia Santos Laguna",Propietario="Francisco Nava",Domicilio="Aguanaval 123, Hidraulica"};

//Agregar jugadores a la academia
miacademia.AgregarJugador(new Jugador{Nombre="Alexander Lopez",AñoNac=2006,Sexo="Hombre",Becado=false});
miacademia.AgregarJugador(new Jugador{Nombre="Uriel Puga",AñoNac=2007,Sexo="Hombre",Becado=true});
miacademia.AgregarJugador(new Jugador{Nombre="Alejandra Escalona",AñoNac=2008,Sexo="Mujer",Becado=false});
miacademia.AgregarJugador(new Jugador{Nombre="Armando Santana",AñoNac=2009,Sexo="Hombre",Becado=false});
miacademia.AgregarJugador(new Jugador{Nombre="Daniel mijares",AñoNac=2010,Sexo="Hombre",Becado=true});
miacademia.AgregarJugador(new Jugador{Nombre="Antonio Hernandez",AñoNac=2011,Sexo="Mujer",Becado=true});
miacademia.AgregarJugador(new Jugador{Nombre="Andrea Solis",AñoNac=2012,Sexo="Mujer",Becado=true});
miacademia.AgregarJugador(new Jugador{Nombre="Marissa Hernandez",AñoNac=2013,Sexo="Mujer",Becado=true});
miacademia.AgregarJugador(new Jugador{Nombre="Diana Soto",AñoNac=2014,Sexo="Mujer",Becado=false});

//Agregar categorias a los jugadores
miacademia.Jugadores[0].AgregarCategoria(new Categoria {Nombre="Junior A",Rango="2006/2007/2008",Cantidad=10,Costo=1250.00} );
miacademia.Jugadores[1].AgregarCategoria(new Categoria {Nombre="Junior A",Rango="2006/2007/2008",Cantidad=10,Costo=1250.00} );
miacademia.Jugadores[2].AgregarCategoria(new Categoria {Nombre="Junior A",Rango="2006/2007/2008",Cantidad=10,Costo=1250.00} );
miacademia.Jugadores[3].AgregarCategoria(new Categoria {Nombre="Junior B",Rango="2009/2010/2011",Cantidad=10,Costo=850.00} );
miacademia.Jugadores[4].AgregarCategoria(new Categoria {Nombre="Junior B",Rango="2009/2010/2011",Cantidad=10,Costo=850.00} );
miacademia.Jugadores[5].AgregarCategoria(new Categoria {Nombre="Junior B",Rango="2009/2010/2011",Cantidad=10,Costo=850.00} );
miacademia.Jugadores[6].AgregarCategoria(new Categoria {Nombre="Pony A",Rango="2012/2013/2014",Cantidad=10,Costo=700.00} );
miacademia.Jugadores[7].AgregarCategoria(new Categoria {Nombre="Pony A",Rango="2012/2013/2014",Cantidad=10,Costo=700.00} );
miacademia.Jugadores[8].AgregarCategoria(new Categoria {Nombre="Pony A",Rango="2012/2013/2014",Cantidad=10,Costo=700.00} );

//Reporte
Console.Clear();
Console.WriteLine("REPORTE DEL CLUB DEPORTIVO\n");
Console.WriteLine(miacademia.ToString());
Console.WriteLine($"\nTotal de Jugadores: {miacademia.Jugadores.Count()}");
Console.WriteLine($"Total de Categorias: {miacademia.TotalVentas()}");

Console.WriteLine("\n>> Datos generales de las Categorias:\n");
foreach(Jugador jugador in miacademia.Jugadores)
    Console.WriteLine(jugador.ToString());

Console.WriteLine("\n>> Jugadores por Categoria:\n");
foreach(Jugador jugador in miacademia.Jugadores) {
    Console.WriteLine($"\n> {jugador.Nombre} - {jugador.AñoNac} - ({jugador.Categorias.Count()})\n");
    foreach(Categoria categoria in jugador.Categorias)
      Console.WriteLine(categoria.ToString());
    Console.WriteLine($"\n- SubTotal : {jugador.SubTotal(),36:c2}\n");
}

Console.WriteLine($"\n\n-Total : {miacademia.Total(),40:c2}\n");
