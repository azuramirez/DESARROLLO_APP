public class InicializadorBD {
    public static void Inicializar(ContextoDatos contexto) {
        if(contexto.Jugadores.Any()) {
            return;
        }
        var jugadores = new Jugador[] {
           new Jugador {Nombre="Osvaldo Ordaz",FechaNac=DateTime.Parse("1/1/2003"),NoPlayera=11,Posicion="Defensa",Apariciones=3,Goles=3},
           new Jugador {Nombre="Mario Avila",FechaNac=DateTime.Parse("24/10/2003"),NoPlayera=7,Posicion="Medio",Apariciones=2,Goles=1},
           new Jugador {Nombre="Victor Castro",FechaNac=DateTime.Parse("30/5/2004"),NoPlayera=8,Posicion="Portero",Apariciones=2,Goles=0},
           new Jugador {Nombre="Luis Vargas",FechaNac=DateTime.Parse("10/1/2004"),NoPlayera=4,Posicion="Lateral",Apariciones=3,Goles=2},
        };
        contexto.Jugadores.AddRange(jugadores);
        contexto.SaveChanges();
    }
}