public class Academia{
    public string Nombre {get; set;}
    public string Propietario {get; set;}
    public string Domicilio {get; set;}
    public List<Jugador> Jugadores {get; set;}

    public Academia() => Jugadores = new List<Jugador>();
    public Academia(string nombre,string propietario,string domicilio) : this() =>
        (Nombre,Propietario,Domicilio) = (nombre,propietario,domicilio);

    public void AgregarJugador(Jugador jugador) => Jugadores.Add(jugador);

    public double Total() {
        double total=0;
        foreach(Jugador jugador in Jugadores)
          total = total + jugador.SubTotal();
        return total;
    }

    public double TotalVentas() {
        int total=0;
        foreach(Jugador jugador in Jugadores)
          total = total + jugador.Categorias.Count();
        return total;
    }

    public override string ToString() => $"Nombre: {Nombre}\nPropietario: {Propietario}\nDomicilio: {Domicilio}";
    
}